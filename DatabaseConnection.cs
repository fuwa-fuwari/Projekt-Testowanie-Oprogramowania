using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
        public bool CheckLogin(string login)
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
                return true;
            }
        }
        public bool ResetUserPassword(string login, string passwordHash)
        {
            if (!CheckLogin(login))
            {
                return false;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
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
        public DataTable GetItemTypes()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT RodzajID, Nazwa FROM RodzajeTowarow ORDER BY Nazwa";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania rodzajów towarów: " + ex.Message, "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool RegisterNewItem(string name, int typeId, string unit, string description, decimal netPrice, decimal quantity, decimal vatRate, string supplier, DateTime deliveryDate, int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertItemQuery = "INSERT INTO Towary (Nazwa, RodzajID, JednostkaMiary, Opis) VALUES (@name, @typeId, @unit, @description); SELECT SCOPE_IDENTITY();";
                            int itemId;
                            using (SqlCommand cmd = new SqlCommand(insertItemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@typeId", typeId);
                                cmd.Parameters.AddWithValue("@unit", unit);
                                cmd.Parameters.AddWithValue("@description", string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description);
                                itemId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            string insertVatQuery = "INSERT INTO StawkiVAT (TowarID, WartoscVAT, ObowiazujeOd) VALUES (@itemId, @vatRate, @date)";
                            using (SqlCommand cmd = new SqlCommand(insertVatQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.Parameters.AddWithValue("@vatRate", vatRate);
                                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                                cmd.ExecuteNonQuery();
                            }

                            string insertStockQuery = "INSERT INTO StanyMagazynowe (TowarID, IloscDostepna) VALUES (@itemId, @quantity)";
                            using (SqlCommand cmd = new SqlCommand(insertStockQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.ExecuteNonQuery();
                            }

                            string insertDeliveryQuery = @"INSERT INTO RejestracjaDostaw 
                                             (TowarID, Ilosc, CenaNetto, ZastosowanyVAT, Dostawca, DataDostawy, RejestrujacyUzytkownikID) 
                                             VALUES (@itemId, @quantity, @netPrice, @vatRate, @supplier, @deliveryDate, @userId)";
                            using (SqlCommand cmd = new SqlCommand(insertDeliveryQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@netPrice", netPrice);
                                cmd.Parameters.AddWithValue("@vatRate", vatRate);
                                cmd.Parameters.AddWithValue("@supplier", supplier);
                                cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisu w bazie danych:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void DisplayItemTypes(DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT RodzajID, Nazwa FROM RodzajeTowarow ORDER BY Nazwa";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // --- WYJĄTEK E3: Brak rodzajów towarów ---
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Brak rodzajów towarów.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv.DataSource = null;
                        }
                        else
                        {
                            dgv.DataSource = dt;
                            if (dgv.Columns["RodzajID"] != null)
                            {
                                dgv.Columns["RodzajID"].Visible = false;
                            }
                            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania listy rodzajów towarów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckIfItemTypeExists(string typeName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM RodzajeTowarow WHERE Nazwa = @name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", typeName);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd sprawdzania unikalności: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        public bool AddNewItemType(string typeName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO RodzajeTowarow (Nazwa) VALUES (@name)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", typeName);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd dodawania rodzaju towaru: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CheckIfItemTypeInUse(int typeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Towary WHERE RodzajID = @typeId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@typeId", typeId);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd sprawdzania przypisania rodzaju towaru: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        public bool DeleteItemType(int typeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM RodzajeTowarow WHERE RodzajID = @typeId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@typeId", typeId);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd usuwania rodzaju towaru: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CheckIfItemHasHistory(int itemId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    (SELECT COUNT(1) FROM RejestracjaDostaw WHERE TowarID = @itemId) +
                    (SELECT COUNT(1) FROM PozycjeSprzedazy WHERE TowarID = @itemId) AS TotalHistory";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);
                        int historyCount = Convert.ToInt32(cmd.ExecuteScalar());

                        return historyCount > 0; // True oznacza, że towar był używany i nie można go usunąć
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd weryfikacji historii towaru: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        public bool DeleteItem(int itemId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string deleteVatQuery = "DELETE FROM StawkiVAT WHERE TowarID = @itemId";
                            using (SqlCommand cmd = new SqlCommand(deleteVatQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.ExecuteNonQuery();
                            }
                            string deleteStockQuery = "DELETE FROM StanyMagazynowe WHERE TowarID = @itemId";
                            using (SqlCommand cmd = new SqlCommand(deleteStockQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.ExecuteNonQuery();
                            }
                            string deleteItemQuery = "DELETE FROM Towary WHERE TowarID = @itemId";
                            using (SqlCommand cmd = new SqlCommand(deleteItemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania towaru: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool SearchWarehouseItems(DataGridView dgv, string searchPhrase, DateTime? historyDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        t.TowarID,
                        t.Nazwa AS [Nazwa towaru],
                        rt.Nazwa AS [Rodzaj towaru],
                        CASE 
                            WHEN @historyDate IS NULL THEN sm.IloscDostepna
                            ELSE (
                                SELECT CASE WHEN ObliczonyStan < 0 THEN 0 ELSE ObliczonyStan END
                                FROM (
                                    SELECT (
                                        ISNULL((SELECT SUM(Ilosc) FROM RejestracjaDostaw WHERE TowarID = t.TowarID AND DataDostawy <= @historyDate), 0)
                                        - 
                                        ISNULL((SELECT SUM(ps.Ilosc) FROM PozycjeSprzedazy ps JOIN Sprzedaz s ON ps.SprzedazID = s.SprzedazID WHERE ps.TowarID = t.TowarID AND CAST(s.DataSprzedazy AS DATE) <= @historyDate), 0)
                                    ) AS ObliczonyStan
                                ) AS Temp
                            )
                        END AS [Wielkość stanu magazynowego],
                        ISNULL(CAST(CAST(@historyDate AS DATE) AS NVARCHAR), CAST(CAST(GETDATE() AS DATE) AS NVARCHAR)) AS [Data stanu]
                    FROM Towary t
                    JOIN RodzajeTowarow rt ON t.RodzajID = rt.RodzajID
                    LEFT JOIN StanyMagazynowe sm ON t.TowarID = sm.TowarID
                    WHERE 
                        (@phrase IS NULL OR @phrase = '' OR
                         t.Nazwa LIKE '%' + @phrase + '%' OR
                         rt.Nazwa LIKE '%' + @phrase + '%' OR
                         EXISTS (
                             SELECT 1 FROM RejestracjaDostaw rd 
                             JOIN Uzytkownicy u ON rd.RejestrujacyUzytkownikID = u.UzytkownikID 
                             WHERE rd.TowarID = t.TowarID AND 
                             (u.Imie + ' ' + u.Nazwisko LIKE '%' + @phrase + '%' OR u.Nazwisko + ' ' + u.Imie LIKE '%' + @phrase + '%')
                         )
                        )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@phrase", string.IsNullOrWhiteSpace(searchPhrase) ? (object)DBNull.Value : searchPhrase);
                        cmd.Parameters.AddWithValue("@historyDate", historyDate.HasValue ? (object)historyDate.Value.Date : DBNull.Value);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // --- Wyjątek E2: Brak towarów w bazie ---
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Brak towarów spełniających podane kryteria.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                            else
                            {
                                dgv.DataSource = dt;
                                if (dgv.Columns["TowarID"] != null)
                                {
                                    dgv.Columns["TowarID"].Visible = false;
                                }
                                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wyszukiwania towarów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool GetItemReplenishmentHistory(DataGridView dgv, int itemId, DateTime? dateFrom, DateTime? dateTo, string employeeName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        rd.Ilosc AS [Dodana Ilość],
                        rd.CenaNetto AS [Cena Netto],
                        rd.ZastosowanyVAT AS [VAT (%)],
                        rd.Dostawca,
                        CAST(rd.DataDostawy AS DATE) AS [Data Dostawy],
                        CAST(rd.DataRejestracji AS DATE) AS [Data Wprowadzenia do Systemu],
                        u.Imie + ' ' + u.Nazwisko AS [Zarejestrował Pracownik]
                    FROM RejestracjaDostaw rd
                    JOIN Uzytkownicy u ON rd.RejestrujacyUzytkownikID = u.UzytkownikID
                    WHERE rd.TowarID = @itemId
                      AND (@dateFrom IS NULL OR CAST(rd.DataRejestracji AS DATE) >= @dateFrom)
                      AND (@dateTo IS NULL OR CAST(rd.DataRejestracji AS DATE) <= @dateTo)
                      AND (@employee IS NULL OR @employee = '' OR u.Imie + ' ' + u.Nazwisko LIKE '%' + @employee + '%' OR u.Nazwisko + ' ' + u.Imie LIKE '%' + @employee + '%')
                    ORDER BY rd.DataRejestracji DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);
                        cmd.Parameters.AddWithValue("@dateFrom", dateFrom.HasValue ? (object)dateFrom.Value.Date : DBNull.Value);
                        cmd.Parameters.AddWithValue("@dateTo", dateTo.HasValue ? (object)dateTo.Value.Date : DBNull.Value);
                        cmd.Parameters.AddWithValue("@employee", string.IsNullOrWhiteSpace(employeeName) ? (object)DBNull.Value : employeeName);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                return false; 
                            }
                            else
                            {
                                dgv.DataSource = dt;
                                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania historii uzupełnień: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Dictionary<string, string> GetItemExtraDetails(int itemId)
        {
            var details = new Dictionary<string, string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    t.Nazwa,
                    t.Opis, 
                    t.JednostkaMiary, 
                    rt.Nazwa AS Rodzaj 
                FROM Towary t
                JOIN RodzajeTowarow rt ON t.RodzajID = rt.RodzajID
                WHERE t.TowarID = @itemId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                details["Nazwa"] = reader["Nazwa"].ToString();
                                details["Opis"] = reader["Opis"].ToString();
                                details["JednostkaMiary"] = reader["JednostkaMiary"].ToString();
                                details["Rodzaj"] = reader["Rodzaj"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania dodatkowych szczegółów towaru: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return details;
        }
        public decimal GetCurrentItemVat(int itemId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TOP 1 WartoscVAT FROM StawkiVAT WHERE TowarID = @itemId ORDER BY ObowiazujeOd DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToDecimal(result) : -1;
                    }
                }
            }
            catch { return -1; }
        }

        public bool CheckIfCategoryNeedsVatChange(int categoryId, decimal newVat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT COUNT(1) FROM Towary t
                OUTER APPLY (SELECT TOP 1 WartoscVAT FROM StawkiVAT v WHERE v.TowarID = t.TowarID ORDER BY ObowiazujeOd DESC) lastVat
                WHERE t.RodzajID = @categoryId AND ISNULL(lastVat.WartoscVAT, -1) != @newVat";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        cmd.Parameters.AddWithValue("@newVat", newVat);
                        int itemsToUpdate = Convert.ToInt32(cmd.ExecuteScalar());

                        return itemsToUpdate > 0;
                    }
                }
            }
            catch { return false; }
        }
        public bool SaveVatChangeForItem(int itemId, decimal newVat, DateTime dateFrom)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Zmiana na ObowiazujeOd
                    string query = "INSERT INTO StawkiVAT (TowarID, WartoscVAT, ObowiazujeOd) VALUES (@itemId, @newVat, @dateFrom)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);
                        cmd.Parameters.AddWithValue("@newVat", newVat);
                        cmd.Parameters.AddWithValue("@dateFrom", dateFrom.Date);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu VAT: " + ex.Message);
                return false;
            }
        }
        public bool SaveVatChangeForCategory(int categoryId, decimal newVat, DateTime dateFrom)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO StawkiVAT (TowarID, WartoscVAT, ObowiazujeOd) SELECT TowarID, @newVat, @dateFrom FROM Towary WHERE RodzajID = @categoryId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        cmd.Parameters.AddWithValue("@newVat", newVat);
                        cmd.Parameters.AddWithValue("@dateFrom", dateFrom.Date);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu masowego VAT: " + ex.Message);
                return false;
            }
        }

        public Dictionary<string, string> GetItemFullDetailsForReplenish(int itemId)
        {
            var details = new Dictionary<string, string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT TOP 1 
                    t.Nazwa, t.Opis, t.JednostkaMiary, rt.Nazwa AS Rodzaj, 
                    rd.CenaNetto, rd.ZastosowanyVAT, rd.Dostawca
                FROM Towary t
                JOIN RodzajeTowarow rt ON t.RodzajID = rt.RodzajID
                LEFT JOIN RejestracjaDostaw rd ON t.TowarID = rd.TowarID
                WHERE t.TowarID = @id
                ORDER BY rd.DataRejestracji DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", itemId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                details["Nazwa"] = reader["Nazwa"].ToString();
                                details["Opis"] = reader["Opis"].ToString();
                                details["JednostkaMiary"] = reader["JednostkaMiary"].ToString();
                                details["Rodzaj"] = reader["Rodzaj"].ToString();

                                if (reader["CenaNetto"] != DBNull.Value)
                                {
                                    decimal cn = Convert.ToDecimal(reader["CenaNetto"]);
                                    details["CenaNetto"] = cn.ToString("0.00", new CultureInfo("pl-PL"));
                                }

                                if (reader["ZastosowanyVAT"] != DBNull.Value)
                                {
                                    decimal vat = Convert.ToDecimal(reader["ZastosowanyVAT"]);
                                    details["VAT"] = (vat == 0) ? "zw" : vat.ToString("0");
                                }

                                details["Dostawca"] = reader["Dostawca"] != DBNull.Value ? reader["Dostawca"].ToString() : "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Błąd pobierania danych towaru z bazy: " + ex.Message); }
            return details;
        }


        public bool ReplenishExistingItem(int itemId, decimal quantity, decimal netPrice, decimal vatRate, string supplier, DateTime deliveryDate, int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertDeliveryQuery = @"INSERT INTO RejestracjaDostaw (TowarID, Ilosc, CenaNetto, ZastosowanyVAT, Dostawca, DataDostawy, RejestrujacyUzytkownikID) 
                                                   VALUES (@itemId, @quantity, @netPrice, @vatRate, @supplier, @deliveryDate, @userId)";
                            using (SqlCommand cmd = new SqlCommand(insertDeliveryQuery, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@netPrice", netPrice);
                                cmd.Parameters.AddWithValue("@vatRate", vatRate);
                                cmd.Parameters.AddWithValue("@supplier", supplier);
                                cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.ExecuteNonQuery();
                            }

                            string updateStockQuery = "UPDATE StanyMagazynowe SET IloscDostepna = IloscDostepna + @quantity WHERE TowarID = @itemId";
                            using (SqlCommand cmd = new SqlCommand(updateStockQuery, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@itemId", itemId);
                                cmd.Parameters.AddWithValue("@quantity", quantity); 
                                cmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                            return true;
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu dostawy: " + ex.Message);
                return false;
            }
        }

        public void SearchSalesHistory(DataGridView dgv, DateTime? dateFrom, DateTime? dateTo, string buyerName, string sellerName, string itemName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    s.SprzedazID,
                    s.DataSprzedazy AS [Data sprzedaży],
                    s.NazwaKlienta AS [Nabywca],
                    ISNULL(u.Imie + ' ' + u.Nazwisko, 'Nieznany (Baza)') AS [Sprzedawca],
                    ISNULL((
                        SELECT SUM(ps.Ilosc * ISNULL(rd.CenaNetto, 0) * (1 + ISNULL(v.WartoscVAT, 0) / 100))
                        FROM PozycjeSprzedazy ps
                        LEFT JOIN (
                            SELECT TowarID, MAX(CenaNetto) as CenaNetto
                            FROM RejestracjaDostaw
                            GROUP BY TowarID
                        ) rd ON ps.TowarID = rd.TowarID
                        LEFT JOIN (
                            SELECT TowarID, MAX(WartoscVAT) as WartoscVAT
                            FROM StawkiVAT
                            GROUP BY TowarID
                        ) v ON ps.TowarID = v.TowarID
                        WHERE ps.SprzedazID = s.SprzedazID
                    ), 0) AS [Łączna wartość sprzedaży]
                FROM Sprzedaz s
                LEFT JOIN Uzytkownicy u ON s.SprzedawcaID = u.UzytkownikID
                WHERE 1=1";

                    if (dateFrom.HasValue) query += " AND CAST(s.DataSprzedazy AS DATE) >= @dateFrom";
                    if (dateTo.HasValue) query += " AND CAST(s.DataSprzedazy AS DATE) <= @dateTo";
                    if (!string.IsNullOrEmpty(buyerName)) query += " AND s.NazwaKlienta LIKE '%' + @buyerName + '%'";

                    if (!string.IsNullOrEmpty(sellerName))
                    {
                        query += " AND (u.Imie + ' ' + u.Nazwisko LIKE '%' + @sellerName + '%' OR u.Nazwisko + ' ' + u.Imie LIKE '%' + @sellerName + '%')";
                    }

                    if (!string.IsNullOrEmpty(itemName))
                    {
                        query += @" AND EXISTS (
                        SELECT 1 FROM PozycjeSprzedazy ps 
                        JOIN Towary t ON ps.TowarID = t.TowarID 
                        WHERE ps.SprzedazID = s.SprzedazID AND t.Nazwa LIKE '%' + @itemName + '%'
                    )";
                    }

                    query += " ORDER BY s.DataSprzedazy DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (dateFrom.HasValue) cmd.Parameters.AddWithValue("@dateFrom", dateFrom.Value.Date);
                        if (dateTo.HasValue) cmd.Parameters.AddWithValue("@dateTo", dateTo.Value.Date);
                        if (!string.IsNullOrEmpty(buyerName)) cmd.Parameters.AddWithValue("@buyerName", buyerName);
                        if (!string.IsNullOrEmpty(sellerName)) cmd.Parameters.AddWithValue("@sellerName", sellerName);
                        if (!string.IsNullOrEmpty(itemName)) cmd.Parameters.AddWithValue("@itemName", itemName);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgv.DataSource = dt;
                            if (dgv.Columns["SprzedazID"] != null) dgv.Columns["SprzedazID"].Visible = false;
                            if (dgv.Columns["Łączna wartość sprzedaży"] != null) dgv.Columns["Łączna wartość sprzedaży"].DefaultCellStyle.Format = "C2";
                            if (dt.Rows.Count == 0)
                            {
                                dgv.DataSource = null; 
                                MessageBox.Show("Brak wyników spełniających podane kryteria.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania historii sprzedaży: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetSaleDetails(int sprzedazId, out string clientName, out string clientAddress, out string saleDate, out string sellerName)
        {
            clientName = ""; clientAddress = ""; saleDate = ""; sellerName = "";
            DataTable itemsTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string headerQuery = @"
                SELECT s.NazwaKlienta, s.AdresKlienta, s.DataSprzedazy, u.Imie + ' ' + u.Nazwisko AS Sprzedawca
                FROM Sprzedaz s
                JOIN Uzytkownicy u ON s.SprzedawcaID = u.UzytkownikID
                WHERE s.SprzedazID = @id";

                    using (SqlCommand cmd = new SqlCommand(headerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", sprzedazId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clientName = reader["NazwaKlienta"].ToString();
                                clientAddress = reader["AdresKlienta"].ToString();
                                saleDate = Convert.ToDateTime(reader["DataSprzedazy"]).ToString("yyyy-MM-dd HH:mm");
                                sellerName = reader["Sprzedawca"].ToString();
                            }
                        }
                    }

                    string itemsQuery = @"
                SELECT 
                    t.Nazwa AS [Towar], 
                    ps.Ilosc AS [Ilość],
                    t.JednostkaMiary AS [J.m.],
                    ISNULL(rd.CenaNetto, 0) AS [Cena Netto],
                    ISNULL(v.WartoscVAT, 0) AS [VAT %],
                    CAST(ISNULL(ps.Ilosc * rd.CenaNetto * (1 + v.WartoscVAT / 100), 0) AS DECIMAL(18,2)) AS [Wartość Brutto]
                FROM PozycjeSprzedazy ps
                JOIN Towary t ON ps.TowarID = t.TowarID
                LEFT JOIN (
                    SELECT TowarID, MAX(CenaNetto) as CenaNetto
                    FROM RejestracjaDostaw
                    GROUP BY TowarID
                ) rd ON ps.TowarID = rd.TowarID
                LEFT JOIN (
                    SELECT TowarID, MAX(WartoscVAT) as WartoscVAT
                    FROM StawkiVAT
                    GROUP BY TowarID
                ) v ON ps.TowarID = v.TowarID
                WHERE ps.SprzedazID = @id";

                    using (SqlDataAdapter da = new SqlDataAdapter(itemsQuery, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@id", sprzedazId);
                        da.Fill(itemsTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania szczegółów sprzedaży: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return itemsTable;
        }
    }
}
