using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektMagazyn
{
    public class DatabaseConnection
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True";
        public void VerifyLogin(string login, string password, out int? userId, out string hash)
        {
            userId = null;
            hash = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UzytkownikID, HasloHash FROM Uzytkownicy WHERE Login = @login AND CzyZapomniany = 0";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = Convert.ToInt32(reader["UzytkownikID"]);
                                hash = reader["HasloHash"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd logowania: " + ex.Message);
            }
        }
        public void DisplayTableUsers(DataGridView dvg_user_list, string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Brak wyników.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dvg_user_list.DataSource = null;
                    }
                    else
                    {
                        dvg_user_list.DataSource = dt;

                        if (dvg_user_list.Columns["UzytkownikID"] != null)
                        {
                            dvg_user_list.Columns["UzytkownikID"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia z bazą: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RoleListClb(CheckedListBox checkedListBox)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UprawnienieID, Nazwa FROM Uprawnienia";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    checkedListBox.DataSource = dt;
                    checkedListBox.DisplayMember = "Nazwa";
                    checkedListBox.ValueMember = "UprawnienieID";
                    checkedListBox.ClearSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania listy uprawnień: " + ex.Message);
            }
        }
        public void UserListClb(CheckedListBox checkedListBox)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                             SELECT UzytkownikId, Imie + ' ' + Nazwisko AS Uzytkownicy
                             FROM Uzytkownicy
                             WHERE CzyZapomniany = 0";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    checkedListBox.DataSource = dt;
                    checkedListBox.DisplayMember = "Uzytkownicy";
                    checkedListBox.ValueMember = "UzytkownikId";
                    checkedListBox.ClearSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania listy użytkowników: " + ex.Message);
            }
        }
        public void RoleListDvg(DataGridView dataGridView)
        {
            string query = @"
                    SELECT 
                        u.UprawnienieID, 
                        u.Nazwa, 
                        COUNT(uu.UzytkownikID) AS PosiadaUprawnienie
                    FROM Uprawnienia u
                    LEFT JOIN Uzytkownicy_Uprawnienia uu ON u.UprawnienieID = uu.UprawnienieID
                    GROUP BY u.UprawnienieID, u.Nazwa";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<int> GetSelectedIds(CheckedListBox clb, string valueMember)
        {
            List<int> ids = new List<int>();

            foreach (var item in clb.CheckedItems)
            {
                if (item is DataRowView row)
                {
                    ids.Add((int)row[valueMember]);
                }
            }

            return ids;
        }
        public void SynchronizeRoles(List<int> userIds, List<int> roleIds)
        {
            if (!userIds.Any())
            {
                MessageBox.Show("Wybierz użytkowników.");
                return;
            }
            if (!roleIds.Any())
            {
                MessageBox.Show("Wybierz uprawnienie do dodania.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        int changes = 0;

                        int adminRoleId;
                        using (SqlCommand cmd = new SqlCommand(
                            "SELECT UprawnienieId FROM Uprawnienia WHERE Nazwa = 'Administrator'",
                            conn, tran))
                        {
                            adminRoleId = (int)cmd.ExecuteScalar();
                        }
                        
                        int adminBefore;
                        using (SqlCommand cmd = new SqlCommand(
                            @"SELECT COUNT(DISTINCT UzytkownikId)
                            FROM Uzytkownicy_Uprawnienia
                            WHERE UprawnienieId = @id",
                            conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@id", adminRoleId);
                            adminBefore = (int)cmd.ExecuteScalar();
                        }

                        foreach (int userId in userIds)
                        {
                            List<int> currentRoles = new List<int>();

                            using (SqlCommand cmd = new SqlCommand(
                                @"SELECT UprawnienieId 
                                FROM Uzytkownicy_Uprawnienia 
                                WHERE UzytkownikId = @userId",
                                conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@userId", userId);

                                using (SqlDataReader r = cmd.ExecuteReader())
                                {
                                    while (r.Read())
                                        currentRoles.Add((int)r["UprawnienieId"]);
                                }
                            }

                            var toAdd = roleIds.Except(currentRoles);

                            foreach (var roleId in toAdd)
                            {
                                using (SqlCommand cmd = new SqlCommand(
                                    @"INSERT INTO Uzytkownicy_Uprawnienia (UzytkownikId, UprawnienieId)
                                    VALUES (@u, @r)",
                                    conn, tran))
                                {
                                    cmd.Parameters.AddWithValue("@u", userId);
                                    cmd.Parameters.AddWithValue("@r", roleId);

                                    changes += cmd.ExecuteNonQuery();
                                }
                            }

                            var toRemove = currentRoles.Except(roleIds);

                            foreach (var roleId in toRemove)
                            {
                                using (SqlCommand cmd = new SqlCommand(
                                    @"DELETE FROM Uzytkownicy_Uprawnienia
                                    WHERE UzytkownikId = @u AND UprawnienieId = @r",
                                    conn, tran))
                                {
                                    cmd.Parameters.AddWithValue("@u", userId);
                                    cmd.Parameters.AddWithValue("@r", roleId);

                                    changes += cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        int adminAfter;
                        using (SqlCommand cmd = new SqlCommand(
                            @"SELECT COUNT(DISTINCT UzytkownikId)
                            FROM Uzytkownicy_Uprawnienia
                            WHERE UprawnienieId = @id",
                            conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@id", adminRoleId);
                            adminAfter = (int)cmd.ExecuteScalar();
                        }

                        if (adminAfter == 0)
                        {
                            tran.Rollback();
                            MessageBox.Show("Musi pozostać przynajmniej jeden administrator.");
                            return;
                        }

                        if (changes == 0)
                        {
                            tran.Rollback();
                            MessageBox.Show("Brak zmian.");
                            return;
                        }

                        tran.Commit();
                        MessageBox.Show("Zapisano zmiany.");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Błąd: " + ex.Message);
                    }
                }
            }
        }
        public bool ResetUserPassword(string login, string passwordHash)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"SELECT COUNT(*) 
                                  FROM Uzytkownicy 
                                  WHERE Login = @login AND CzyZapomniany = 0";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@login", login);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists == 0)
                        return false;
                }

                string updateQuery = @"UPDATE Uzytkownicy 
                                   SET HasloHash = @hash 
                                   WHERE Login = @login";

                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@hash", passwordHash);
                    updateCmd.Parameters.AddWithValue("@login", login);
                    updateCmd.ExecuteNonQuery();
                }

                return true;
            }
        }
    }
}
