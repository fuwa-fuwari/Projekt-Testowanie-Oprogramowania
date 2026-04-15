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
        public void display_table_users(DataGridView dvg_user_list, string query)
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
        public void ListaUprawnienClb(CheckedListBox checkedListBox)
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
        public void ListaUzytkownikowClb(CheckedListBox checkedListBox)
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
        public void ListaUprawnienDvg(DataGridView dataGridView)
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
        public void SynchronizujRole(List<int> userIds, List<int> roleIds)
        {
            if (!userIds.Any())
            {
                MessageBox.Show("Wybierz użytkowników.");
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
    }
}
