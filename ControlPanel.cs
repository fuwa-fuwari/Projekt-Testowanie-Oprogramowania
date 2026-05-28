using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjektMagazyn
{
    public partial class ControlPanel : Form
    {
        private List<TabPage> masterMainTabs = new List<TabPage>();
        private int selectedUserId = -1;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True";
        private List<int> currentUserPermissions = new List<int>();
        private int currentViewUserId = -1;
        private bool isFiltered = false;
        private bool isItemFiltered = false;
        private int currentHistoryItemId = -1;
        private bool isHistoryFiltered = false;
        private int vatChangeMode = 0; // 1 = Pojedynczy towar, 2 = Rodzaj towaru
        private int selectedVatItemId = -1;
        private int replenishItemId = -1;

        private DataTable dtBasket;

        DatabaseConnection database = new DatabaseConnection();
        private ErrorProvider errorProvider = new ErrorProvider();

        // Zmienne do sprawdzania, czy wprowadzono zmiany (można usnąć, ale będą wysyłane zapytania do bazy nawet, jeśli nic się nie zmieniło)
        private string origName, origSurname, origGender, origPesel, origEmail, origPhone;
        private DateTime origBirthdate;
        private string origCity, origPostalCode, origStreet, origStreetNumber, origLocaleNumber;
        private int loggedUserId;
        public ControlPanel(int userId)
        {
            InitializeComponent();
            foreach (TabPage tab in dotNetBarTabControl_main_view.TabPages)
            {
                masterMainTabs.Add(tab);
            }
            InicjalizujKoszyk();
            PrzypiszAutomatyczneCzyszczenieBledow();
            loggedUserId = userId;
            LoadUserPermissions(loggedUserId);
            EnablePermittedTabs();
            this.Load += ControlPanel_Load;
            OdswiezUprawnieniaIZakladki();

            LoadData();
        }
        private void LoadData()
        {

            ZablokujPolaEdycji();

            if (dotNetBarTabControl_manage_users.TabPages.Contains(tabPage_view_user))
                dotNetBarTabControl_manage_users.TabPages.Remove(tabPage_view_user);

            if (tabPage_items.TabPages.Contains(tabPage_Item_History))
                tabPage_items.TabPages.Remove(tabPage_Item_History);

            if (tabPage_items.TabPages.Contains(tabPage_Delivery_Details))
                tabPage_items.TabPages.Remove(tabPage_Delivery_Details);

            if (tabPage_items.TabPages.Contains(tabPage_Vat_Change))
                tabPage_items.TabPages.Remove(tabPage_Vat_Change);

            if (tabControl_sales.TabPages.Contains(tabPage_sale_details))
                tabControl_sales.TabPages.Remove(tabPage_sale_details);
        }
        private void ControlPanel_Load(object sender, EventArgs e)
        {
            LoadMyProfile();
            LoadProfileRoles(loggedUserId);
        }
        private void dotNetBarTabControl_main_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dotNetBarTabControl_main_view.SelectedTab == tabPage_users)
            {
                btn_refresh_Click(null, null); 
                WczytajUzytkownikowDoListy();
            }
            else if (dotNetBarTabControl_main_view.SelectedTab == tabPage_roles)
            {
                database.RoleListDvg(dgv_roles);
                database.RoleListClb(clb_add_user_role);
                database.RoleListClb(clb_roles_group_edit);
                database.UserListClb(clb_users_group_edit);
                WczytajUprawnienia();
                WczytajUzytkownikowZUprawnieniami();
            }
            else if (dotNetBarTabControl_main_view.SelectedTab == tabPage_manage_warehouse)
            {
                LoadItemTypes();
                SetWarehousePermissions();
                LoadWarehouseItems();
            }
            else if (dotNetBarTabControl_main_view.SelectedTab == tabPage_manage_sales)
            {
                WczytajTowaryDoSprzedazy();
            }
            else if (dotNetBarTabControl_main_view.SelectedTab == tabPage_my_profile)
            {
                LoadMyProfile();
                LoadProfileRoles(loggedUserId);
            }
            if (dotNetBarTabControl_main_view.SelectedTab == tabPage_manage_sales)
            {
                WczytajTowaryDoSprzedazy();
                database.SearchSalesHistory(dgv_sales_history, null, null, "", "", "");
            }
            if (dotNetBarTabControl_main_view.SelectedTab == tabPage_manage_sales)
            {
                WczytajTowaryDoSprzedazy();
                database.SearchSalesHistory(dgv_sales_history, null, null, "", "", "");
            }
            else
            {
                if (tabControl_sales.TabPages.Contains(tabPage_sale_details))
                {
                    tabControl_sales.TabPages.Remove(tabPage_sale_details);
                }
            }

            if (dotNetBarTabControl_main_view.SelectedTab == tabPage_manage_sales)
            {
                WczytajTowaryDoSprzedazy();
                btn_search_sales_Click(null, null);
            }
            else
            {
                if (tabControl_sales.TabPages.Contains(tabPage_sale_details))
                {
                    tabControl_sales.TabPages.Remove(tabPage_sale_details);
                }
            }
        }
        private void tabControl_sales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_sales.SelectedTab == tabPage_sales_history)
            {
                btn_search_sales_Click(null, null);
            }

            if (tabControl_sales.SelectedTab != tabPage_sale_details && tabControl_sales.TabPages.Contains(tabPage_sale_details))
            {
                tabControl_sales.TabPages.Remove(tabPage_sale_details);
            }
        }

        private void LoadUserPermissions(int userId)
        {
            currentUserPermissions.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                        SELECT UprawnienieID 
                        FROM Uzytkownicy_Uprawnienia 
                        WHERE UzytkownikID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            currentUserPermissions.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
        }
        private void EnablePermittedTabs()
        {
            //1 - Administrator
            //2 - Kierownik magazynu
            //3 - Pracownik magazynu
            //4 - Kierownik sprzedazy
            //5 - Sprzedawca
            if (!currentUserPermissions.Contains(1))
            {
                dotNetBarTabControl_main_view.TabPages.Remove(tabPage_users);
                dotNetBarTabControl_main_view.TabPages.Remove(tabPage_roles);
                dotNetBarTabControl_main_view.TabPages.Remove(tabPage_overview);
            }
            if (!currentUserPermissions.Contains(2) && !currentUserPermissions.Contains(3))
            {
                dotNetBarTabControl_main_view.TabPages.Remove(tabPage_manage_warehouse);
            }
            if (!currentUserPermissions.Contains(4) && !currentUserPermissions.Contains(5))
            {
                dotNetBarTabControl_main_view.TabPages.Remove(tabPage_manage_sales);
            }
        }
        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            errorProvider.Clear(); 

            var login = msktbx_user_login.Text.Trim();
            var name = msktbx_user_name.Text.Trim();
            var surname = msktbx_user_surname.Text.Trim();
            var gender = cmbx_gender.Text.Trim();
            var pesel = msktbx_pesel.Text.Replace(" ", "").Trim();
            var email = msktbx_email.Text.Trim();
            var phone = msktbx_phone.Text.Replace(" ", "").Trim();
            var birthdate = dtpckr_birthdate.Value.Date;
            var city = msktbx_city.Text.Trim();
            var postal_code = msktbx_postal_code.Text.Trim();
            var street = msktbx_street.Text.Trim();
            var street_number = msktbx_street_number.Text.Trim();
            var locale_number = msktbx_locale_number.Text.Trim();
            int invalids = 0;

            List<Control> textboxes = new List<Control>
            {
                msktbx_user_login, msktbx_user_name, msktbx_user_surname, cmbx_gender,
                msktbx_pesel, msktbx_email, msktbx_phone, dtpckr_birthdate,
                msktbx_city, msktbx_street, msktbx_postal_code, msktbx_street_number, msktbx_locale_number
            };

            foreach (var textbox in textboxes) textbox.BackColor = Color.White;
            clb_add_user_role.BackColor = Color.White;

            if (!validation.valid_login(login))
            {
                invalids++; msktbx_user_login.BackColor = Color.Red;
                errorProvider.SetError(msktbx_user_login, "Brak wymaganych pól");
            }
            if (clb_add_user_role.CheckedItems.Count == 0)
            {
                invalids++; clb_add_user_role.BackColor = Color.Red;
                errorProvider.SetError(clb_add_user_role, "Brak wymaganych pól");
            }
            if (!validation.valid_name(name))
            {
                invalids++; msktbx_user_name.BackColor = Color.Red;
                errorProvider.SetError(msktbx_user_name, "Brak wymaganych pól");
            }
            if (!validation.valid_surname(surname))
            {
                invalids++; msktbx_user_surname.BackColor = Color.Red;
                errorProvider.SetError(msktbx_user_surname, "Brak wymaganych pól");
            }
            if (!validation.valid_gender(gender, pesel))
            {
                invalids++; cmbx_gender.BackColor = Color.Red;
                errorProvider.SetError(cmbx_gender, "Brak wymaganych pól");
            }
            if (!validation.valid_birthdate(birthdate.Date, pesel))
            {
                invalids++; dtpckr_birthdate.BackColor = Color.Red; msktbx_pesel.BackColor = Color.Red;
                errorProvider.SetError(dtpckr_birthdate, "Wiek użytkownika musi być większy bądź równy 18 lat");
            }
            if (!validation.valid_pesel(pesel, birthdate.Date, gender))
            {
                invalids++; msktbx_pesel.BackColor = Color.Red;
                errorProvider.SetError(msktbx_pesel, "Wprowadzono błędny numer pesel\nWymagania numeru pesel:\n- Pierwsze sześć cyfr odpowiada dacie urodzenia: RRMMDD\n- Przedostatnia cyfra odpowiada płci:\n  Nieparzyste – mężczyźni\n  Parzyste i zero – kobiety\n- Cyfra kontrolna, zgodnie z: https://www.gov.pl/web/gov/czym-jest-numer-pesel");
            }
            if (!validation.valid_email(email))
            {
                invalids++; msktbx_email.BackColor = Color.Red;
                errorProvider.SetError(msktbx_email, "Wprowadzono błędny adres email.\nWymagania Adresu e-mail:\n- Zawiera dokładnie jeden znak: @\n- Zawiera składnię, zgodnie z: nazwa_użytkownika@nazwa_domeny_serwera_poczty\n- Domena_serwera_poczty = domena_wyższego_poziomu.domena_najwyższego_poziomu\n- Liczba znaków: max 255");
            }
            if (!validation.valid_phone(phone))
            {
                invalids++; msktbx_phone.BackColor = Color.Red;
                errorProvider.SetError(msktbx_phone, "Wprowadzono błędny numer telefonu\nWymagania numeru telefonu:\n- 9 cyfr");
            }
            if (!validation.valid_city(city))
            {
                invalids++; msktbx_city.BackColor = Color.Red;
                errorProvider.SetError(msktbx_city, "Brak wymaganych pól");
            }
            if (!validation.valid_postal_code(postal_code))
            {
                invalids++; msktbx_postal_code.BackColor = Color.Red;
                errorProvider.SetError(msktbx_postal_code, "Wprowadzono błędny kod pocztowy\nWymagany format XX-XXX");
            }
            if (!validation.valid_street_number(street_number))
            {
                invalids++; msktbx_street_number.BackColor = Color.Red;
                errorProvider.SetError(msktbx_street_number, "Brak wymaganych pól");
            }
            
            if (invalids != 0)
            {
                validation.incorrect_input();
                return;
            }

            bool emailExists = false, peselExists = false, loginExists = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT Email, PESEL, Login FROM Uzytkownicy WHERE Email = @email OR PESEL = @pesel OR Login = @login";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@email", email);
                    checkCmd.Parameters.AddWithValue("@pesel", pesel);
                    checkCmd.Parameters.AddWithValue("@login", login);
                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Email"].ToString() == email) emailExists = true;
                            if (reader["PESEL"].ToString() == pesel) peselExists = true;
                            if (reader["Login"].ToString() == login) loginExists = true;
                        }
                    }
                }
            }

            if (emailExists || peselExists || loginExists)
            {
                if (loginExists) { msktbx_user_login.BackColor = Color.Red; errorProvider.SetError(msktbx_user_login, "Ten login już istnieje w bazie"); }
                if (peselExists) { msktbx_pesel.BackColor = Color.Red; errorProvider.SetError(msktbx_pesel, "Ten numer pesel już istnieje w bazie"); }
                if (emailExists) { msktbx_email.BackColor = Color.Red; errorProvider.SetError(msktbx_email, "Ten adres email już istnieje w bazie"); }
                validation.incorrect_input();
                return;
            }

            try
            {
                RecoveryMail recoveryMail = new RecoveryMail();
                string newPassword = recoveryMail.GeneratePassword();
                string hashed_password = SecurePasswordHasher.Hash(newPassword);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Uzytkownicy
                        (Login, HasloHash, Imie, Nazwisko, Miejscowosc, KodPocztowy, Ulica, NumerPosesji, NumerLokalu, PESEL, DataUrodzenia, Plec, Email, Telefon)
                        VALUES
                        (@login, @haslo, @imie, @nazwisko, @miasto, @kod, @ulica, @nrPos, @nrLok, @pesel, @dataUr, @plec, @email, @telefon);
                        SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@haslo", hashed_password);
                        cmd.Parameters.AddWithValue("@imie", name);
                        cmd.Parameters.AddWithValue("@nazwisko", surname);
                        cmd.Parameters.AddWithValue("@miasto", city);
                        cmd.Parameters.AddWithValue("@kod", postal_code);
                        cmd.Parameters.AddWithValue("@ulica", street ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@nrPos", street_number);
                        cmd.Parameters.AddWithValue("@nrLok", string.IsNullOrEmpty(locale_number) ? (object)DBNull.Value : locale_number);
                        cmd.Parameters.AddWithValue("@pesel", pesel);
                        cmd.Parameters.AddWithValue("@dataUr", birthdate);
                        cmd.Parameters.AddWithValue("@plec", gender);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefon", phone);
                        int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                        string insertPermQuery = "INSERT INTO Uzytkownicy_Uprawnienia (UzytkownikID, UprawnienieID) VALUES (@uid, @pid)";
                        using (SqlCommand role_cmd = new SqlCommand(insertPermQuery, conn))
                        {
                            role_cmd.Parameters.Add("@uid", SqlDbType.Int).Value = newUserId;
                            role_cmd.Parameters.Add("@pid", SqlDbType.Int);

                            foreach (DataRowView item in clb_add_user_role.CheckedItems)
                            {
                                role_cmd.Parameters["@pid"].Value = (int)item["UprawnienieID"];
                                role_cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Dodano użytkownika do bazy");
                WczytajUzytkownikowDoListy();
                ClearAddUserData(textboxes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void ClearAddUserData(List<Control> textboxes)
        {
            errorProvider.Clear(); 
            foreach (var textbox in textboxes)
            {
                textbox.Text = "";
                textbox.BackColor = Color.White;
            }
            for (int i = 0; i < clb_add_user_role.Items.Count; i++)
            {
                clb_add_user_role.SetItemChecked(i, false);
            }
            clb_add_user_role.ClearSelected();
            clb_add_user_role.BackColor = Color.White;

            dtpckr_birthdate.Value = DateTime.Today;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            List<Control> textboxes = new List<Control>
            {
                    msktbx_user_login,
                    msktbx_user_name,
                    msktbx_user_surname,
                    cmbx_gender,
                    msktbx_pesel,
                    msktbx_email,
                    msktbx_phone,
                    dtpckr_birthdate,
                    msktbx_city,
                    msktbx_street,
                    msktbx_street_number,
                    msktbx_locale_number
            };

            ClearAddUserData(textboxes);
            dotNetBarTabControl_main_view.SelectedTab = tabPage_overview;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = @"
                SELECT 
                    UzytkownikID, 
                    Login, 
                    Imie + ' ' + Nazwisko AS [Imię i Nazwisko], 
                    Email, 
                    PESEL 
                FROM Uzytkownicy 
                WHERE CzyZapomniany = 0
                ORDER BY Nazwisko";
            databaseConnection.DisplayTableUsers(dvg_user_list, query);
            WczytajUzytkownikowDoListy(); 
            OdswiezUprawnieniaIZakladki();
        }

        private void btn_forget_Click(object sender, EventArgs e)
        {
            if (dvg_user_list.CurrentRow == null)
            {
                MessageBox.Show("Wybierz użytkownika z listy.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dvg_user_list.CurrentRow.Cells["UzytkownikID"].Value);
            string imieINazwisko = dvg_user_list.CurrentRow.Cells["Imię i Nazwisko"].Value.ToString();

            var potwierdzenie = MessageBox.Show(
                $"Czy na pewno chcesz zanonimizować dane użytkownika {imieINazwisko}?\n\nOperacja jest NIEODWRACALNA.",
                "Potwierdzenie anonimizacji",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (potwierdzenie != DialogResult.Yes)
                return;

            string randomString = Guid.NewGuid().ToString("N");
            string fakePesel = Math.Abs(DateTime.Now.Ticks).ToString().Substring(0, 11);
            string fakeEmail = $"del_{id}_{randomString.Substring(0, 10)}@anon.pl";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string deleteUprawnieniaQuery = "DELETE FROM Uzytkownicy_Uprawnienia WHERE UzytkownikID = @id";
                            using (SqlCommand cmdUprawnienia = new SqlCommand(deleteUprawnieniaQuery, conn, transaction))
                            {
                                cmdUprawnienia.Parameters.AddWithValue("@id", id);
                                cmdUprawnienia.ExecuteNonQuery();
                            }

                            string anonimizacjaQuery = @"
                        UPDATE Uzytkownicy SET
                            Imie = 'Zanonimizowano',
                            Nazwisko = 'Zanonimizowano',
                            Login = @fakeLogin,
                            Email = @fakeEmail,
                            PESEL = @fakePesel, 
                            DataUrodzenia = '1900-01-01',
                            Plec = 'zanonimizowano',
                            Miejscowosc = '***',
                            Ulica = '***',
                            Telefon = '000000000',
                            HasloHash = 'ZABLOKOWANE',
                            CzyZapomniany = 1,
                            DataZapomnienia = GETDATE(),
                            ZapomnianyPrzezID = 1
                        WHERE UzytkownikID = @id";

                            using (SqlCommand cmdAnonimizacja = new SqlCommand(anonimizacjaQuery, conn, transaction))
                            {
                                cmdAnonimizacja.Parameters.AddWithValue("@id", id);
                                cmdAnonimizacja.Parameters.AddWithValue("@fakeLogin", $"del_{id}_{randomString.Substring(0, 8)}");
                                cmdAnonimizacja.Parameters.AddWithValue("@fakeEmail", fakeEmail);
                                cmdAnonimizacja.Parameters.AddWithValue("@fakePesel", fakePesel);
                                cmdAnonimizacja.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Zapomniano użytkownika.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btn_refresh_Click(sender, e);
                        }
                        catch (Exception exTransaction)
                        {
                            transaction.Rollback();
                            throw exTransaction;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas anonimizacji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string match = tbx_search.Text.Trim();

            if (string.IsNullOrEmpty(match))
            {
                MessageBox.Show("Podaj informacje do wyszukania!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT UzytkownikID, Login, Imie + ' ' + Nazwisko AS [Imię i Nazwisko], Email, PESEL 
                    FROM Uzytkownicy
                    WHERE CzyZapomniany = 0
                    AND (
                        Login LIKE @match OR 
                        Email LIKE @match OR 
                        PESEL LIKE @match OR 
                        Imie LIKE @match OR 
                        Nazwisko LIKE @match
                    )
                    ORDER BY Nazwisko";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@match", "%" + match + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Brak wyników spełniających podane kryteria.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dvg_user_list.DataSource = dt;
                    if (dvg_user_list.Columns["UzytkownikID"] != null) dvg_user_list.Columns["UzytkownikID"].Visible = false;
                }
            }
        }

        private void btn_show_forgotten_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = @"
                SELECT 
                    u1.UzytkownikID, 
                    u1.Login, 
                    u1.Imie + ' ' + u1.Nazwisko AS [Imię i Nazwisko], 
                    u1.Email, 
                    u1.PESEL,
                    u1.DataZapomnienia AS [Data usunięcia],
                    u2.Login AS [Usunięty przez]
                FROM Uzytkownicy u1
                LEFT JOIN Uzytkownicy u2 ON u1.ZapomnianyPrzezID = u2.UzytkownikID
                WHERE u1.CzyZapomniany = 1
                ORDER BY u1.Nazwisko";
            databaseConnection.DisplayTableUsers(dvg_user_list, query);
        }

        private void dvg_user_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentViewUserId = Convert.ToInt32(dvg_user_list.Rows[e.RowIndex].Cells["UzytkownikID"].Value);

                ZaladujPodgladUzytkownika(currentViewUserId);

                PokazZakladkePodgladu();
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            msktbx_user_login.Text = "langusta";
            msktbx_user_name.Text = "Ola";
            msktbx_user_surname.Text = "Nobel";
            cmbx_gender.Text = "kobieta";
            msktbx_pesel.Text = "00231900100";
            msktbx_email.Text = "aa@aaaa.a";
            msktbx_phone.Text = "222222222";
            dtpckr_birthdate.Value = new DateTime(2000, 3, 19);
            msktbx_city.Text = "Chrząszczowice";
            msktbx_street.Text = "Łęczna";
            msktbx_street_number.Text = "22";
            msktbx_locale_number.Text = "22";
        }

        private void btn_close_view_Click(object sender, EventArgs e)
        {
            dotNetBarTabControl_manage_users.SelectedIndex = 0;

            dotNetBarTabControl_manage_users.TabPages.Remove(tabPage_view_user);
        }

        private void btn_edit_from_view_Click(object sender, EventArgs e)
        {
            if (currentViewUserId == -1) return;

            UkryjZakladkePodgladu();

            dotNetBarTabControl_manage_users.SelectedTab = tabPage_edit_user;

            cmbx_select_user_edit.SelectedValue = currentViewUserId;
        }

        private void WczytajUzytkownikowDoListy()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UzytkownikID, Login + ' - ' + Imie + ' ' + Nazwisko AS DisplayText FROM Uzytkownicy WHERE ISNULL(CzyZapomniany, 0) = 0";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbx_select_user_edit.DataSource = dt;
                    cmbx_select_user_edit.DisplayMember = "DisplayText";
                    cmbx_select_user_edit.ValueMember = "UzytkownikID";
                    cmbx_select_user_edit.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania listy użytkowników: " + ex.Message);
            }
        }

        private void ZablokujPolaEdycji()
        {
            var controls = new List<Control> 
            {
                msktbx_user_login_edit,
                msktbx_user_name_edit, 
                msktbx_user_surname_edit, 
                cmbx_gender_edit, 
                msktbx_pesel_edit, 
                msktbx_email_edit, 
                msktbx_phone_edit, 
                dtpckr_birthdate_edit, 
                msktbx_city_edit,
                msktbx_postal_code_edit,
                msktbx_street_edit, 
                msktbx_street_number_edit, 
                msktbx_locale_number_edit,
                tbx_admin_password_reset,
                btn_admin_password_reset
            };
            foreach (var ctrl in controls) ctrl.Enabled = false;
        }

        private void cmbx_select_user_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_select_user_edit.SelectedIndex == -1) return;

            if (cmbx_select_user_edit.SelectedValue is int)
            {
                selectedUserId = (int)cmbx_select_user_edit.SelectedValue;
            }
            else if (cmbx_select_user_edit.SelectedValue is DataRowView drv)
            {
                selectedUserId = Convert.ToInt32(drv["UzytkownikID"]);
            }
            else
            {
                int.TryParse(cmbx_select_user_edit.SelectedValue.ToString(), out selectedUserId);
            }

            ZablokujPolaEdycji();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Uzytkownicy WHERE UzytkownikID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedUserId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                msktbx_user_login_edit.Text = reader["Login"].ToString();
                                msktbx_user_name_edit.Text = reader["Imie"].ToString();
                                msktbx_user_surname_edit.Text = reader["Nazwisko"].ToString();
                                cmbx_gender_edit.Text = reader["Plec"].ToString();
                                msktbx_pesel_edit.Text = reader["PESEL"].ToString();
                                msktbx_email_edit.Text = reader["Email"].ToString();
                                msktbx_phone_edit.Text = reader["Telefon"].ToString();
                                dtpckr_birthdate_edit.Value = Convert.ToDateTime(reader["DataUrodzenia"]);
                                msktbx_city_edit.Text = reader["Miejscowosc"].ToString();
                                msktbx_postal_code_edit.Text = reader["KodPocztowy"].ToString();
                                msktbx_street_edit.Text = reader["Ulica"].ToString();
                                msktbx_street_number_edit.Text = reader["NumerPosesji"].ToString();
                                msktbx_locale_number_edit.Text = reader["NumerLokalu"].ToString();
                                origName = msktbx_user_name_edit.Text.Trim();
                                origSurname = msktbx_user_surname_edit.Text.Trim();
                                origGender = cmbx_gender_edit.Text.Trim();
                                origPesel = msktbx_pesel_edit.Text.Replace(" ", "").Trim();
                                origEmail = msktbx_email_edit.Text.Trim();
                                origPhone = msktbx_phone_edit.Text.Replace(" ", "").Trim();
                                origBirthdate = dtpckr_birthdate_edit.Value.Date;
                                origCity = msktbx_city_edit.Text.Trim();
                                origPostalCode = msktbx_postal_code_edit.Text.Trim();
                                origStreet = msktbx_street_edit.Text.Trim();
                                origStreetNumber = msktbx_street_number_edit.Text.Trim();
                                origLocaleNumber = msktbx_locale_number_edit.Text.Trim();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania danych: " + ex.Message);
            }
        }

        private void btn_unlock_edit_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Najpierw wybierz użytkownika z listy.");
                return;
            }

            var controls = new List<Control> 
            { 
                msktbx_user_name_edit,
                msktbx_user_surname_edit, 
                cmbx_gender_edit, 
                msktbx_pesel_edit, 
                msktbx_email_edit, 
                msktbx_phone_edit, 
                dtpckr_birthdate_edit, 
                msktbx_city_edit,
                msktbx_postal_code_edit,
                msktbx_street_edit, 
                msktbx_street_number_edit, 
                msktbx_locale_number_edit,
                tbx_admin_password_reset,
                btn_admin_password_reset
            };
            foreach (var ctrl in controls) ctrl.Enabled = true;

            MessageBox.Show("Pola zostały odblokowane. Możesz wprowadzić zmiany.");
        }

        private void btn_save_edit_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1) return;

            Validation validation = new Validation();
            errorProvider.Clear(); 
            int invalids = 0;

            var name = msktbx_user_name_edit.Text.Trim();
            var surname = msktbx_user_surname_edit.Text.Trim();
            var gender = cmbx_gender_edit.Text.Trim();
            var pesel = msktbx_pesel_edit.Text.Replace(" ", "").Trim();
            var email = msktbx_email_edit.Text.Trim();
            var phone = msktbx_phone_edit.Text.Replace(" ", "").Trim();
            var birthdate = dtpckr_birthdate_edit.Value.Date;
            var city = msktbx_city_edit.Text.Trim();
            var postal_code = msktbx_postal_code_edit.Text.Trim();
            var street = msktbx_street_edit.Text.Trim();
            var street_number = msktbx_street_number_edit.Text.Trim();
            var locale_number = msktbx_locale_number_edit.Text.Trim();

            bool hasChanges =
                name != origName || surname != origSurname || gender != origGender ||
                pesel != origPesel || email != origEmail || phone != origPhone ||
                birthdate != origBirthdate || city != origCity || postal_code != origPostalCode || street != origStreet ||
                street_number != origStreetNumber || locale_number != origLocaleNumber;

            if (!hasChanges)
            {
                MessageBox.Show("Nie wprowadzono żadnych zmian.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ZablokujPolaEdycji();
                return;
            }

            var textboxes = new List<Control>
            {
                    msktbx_user_name_edit,
                    msktbx_user_surname_edit,
                    cmbx_gender_edit,
                    msktbx_pesel_edit,
                    msktbx_email_edit,
                    msktbx_phone_edit,
                    dtpckr_birthdate_edit,
                    msktbx_city_edit,
                    msktbx_postal_code_edit,
                    msktbx_street_edit,
                    msktbx_street_number_edit,
                    msktbx_locale_number_edit
            };
            foreach (var textbox in textboxes) textbox.BackColor = Color.White;


            if (!validation.valid_name(name))
            { 
                invalids++; msktbx_user_name_edit.BackColor = Color.Red; 
                errorProvider.SetError(msktbx_user_name_edit, "Brak wymaganych pól"); 
            }
            if (!validation.valid_surname(surname)) 
            { 
                invalids++; msktbx_user_surname_edit.BackColor = Color.Red; 
                errorProvider.SetError(msktbx_user_surname_edit, "Brak wymaganych pól"); 
            }
            if (!validation.valid_gender(gender, pesel)) 
            { 
                invalids++; cmbx_gender_edit.BackColor = Color.Red; 
                errorProvider.SetError(cmbx_gender_edit, "Brak wymaganych pól"); 
            }
            if (!validation.valid_birthdate(birthdate.Date, pesel)) 
            { 
                invalids++; dtpckr_birthdate_edit.BackColor = Color.Red; msktbx_pesel_edit.BackColor = Color.Red; 
                errorProvider.SetError(dtpckr_birthdate_edit, "Wiek użytkownika musi być większy bądź równy 18 lat"); 
            }
            if (!validation.valid_pesel(pesel, birthdate.Date, gender))
            { 
                invalids++; msktbx_pesel_edit.BackColor = Color.Red; 
                errorProvider.SetError(msktbx_pesel_edit, "Wprowadzono błędny numer pesel\nWymagania numeru pesel:\n- Pierwsze sześć cyfr odpowiada dacie urodzenia: RRMMDD\n- Przedostatnia cyfra odpowiada płci:\n  Nieparzyste – mężczyźni\n  Parzyste i zero – kobiety\n- Cyfra kontrolna, zgodnie z: https://www.gov.pl/web/gov/czym-jest-numer-pesel"); 
            }
            if (!validation.valid_email(email)) 
            { 
                invalids++; msktbx_email_edit.BackColor = Color.Red;
                errorProvider.SetError(msktbx_email_edit, "Wprowadzono błędny adres email.\nWymagania Adresu e-mail:\n- Zawiera dokładnie jeden znak: @\n- Zawiera składnię, zgodnie z: nazwa_użytkownika@nazwa_domeny_serwera_poczty\n- Domena_serwera_poczty = domena_wyższego_poziomu.domena_najwyższego_poziomu\n- Liczba znaków: max 255"); 
            }
            if (!validation.valid_phone(phone)) 
            { 
                invalids++; msktbx_phone_edit.BackColor = Color.Red; 
                errorProvider.SetError(msktbx_phone_edit, "Wprowadzono błędny numer telefonu\nWymagania numeru telefonu:\n- 9 cyfr"); 
            }
            if (!validation.valid_city(city)) 
            { 
                invalids++; msktbx_city_edit.BackColor = Color.Red; 
                errorProvider.SetError(msktbx_city_edit, "Brak wymaganych pól"); 
            }
            if (!validation.valid_postal_code(postal_code))
            {
                invalids++; msktbx_postal_code.BackColor = Color.Red;
                errorProvider.SetError(msktbx_postal_code, "Wprowadzono błędny kod pocztowy\nWymagany format XX-XXX");
            }
            if (!validation.valid_street_number(street_number)) 
            {
                invalids++; msktbx_street_number_edit.BackColor = Color.Red; 
                errorProvider.SetError(msktbx_street_number_edit, "Brak wymaganych pól"); 
            }

            if (invalids != 0)
            {
                validation.incorrect_input();
                return;
            }

            bool emailExists = false, peselExists = false, loginExists = false;
            var login = msktbx_user_login_edit.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = @"
                    SELECT Email, PESEL, Login 
                    FROM Uzytkownicy 
                    WHERE UzytkownikID != @id 
                    AND (Email = @email OR PESEL = @pesel OR Login = @login)";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@email", email);
                    checkCmd.Parameters.AddWithValue("@pesel", pesel);
                    checkCmd.Parameters.AddWithValue("@login", login);
                    checkCmd.Parameters.AddWithValue("@id", selectedUserId);

                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Email"].ToString() == email) emailExists = true;
                            if (reader["PESEL"].ToString() == pesel) peselExists = true;
                            if (reader["Login"].ToString() == login) loginExists = true;
                        }
                    }
                }
            }
            // Jeżeli znaleziono jakikolwiek duplikat, przerywamy zapis i kolorujemy odpowiednie pola na czerwono

            if (emailExists || peselExists || loginExists)
            {
                string msg = "Poniższe dane są już przypisane do innego konta w systemie:\n\n";

                if (loginExists) { msktbx_user_login_edit.BackColor = Color.Red; msg += "- Login\n"; errorProvider.SetError(msktbx_user_login_edit, "Poniższe dane są już przypisane do innego konta w systemie: - Login"); }
                if (peselExists) { msktbx_pesel_edit.BackColor = Color.Red; msg += "- Numer PESEL\n"; errorProvider.SetError(msktbx_pesel_edit, "Poniższe dane są już przypisane do innego konta w systemie: - numer pesel"); }
                if (emailExists) { msktbx_email_edit.BackColor = Color.Red; msg += "- Adres e-mail\n"; errorProvider.SetError(msktbx_email_edit, "Poniższe dane są już przypisane do innego konta w systemie: - Adres e-mail"); }

                MessageBox.Show(msg, "Konflikt unikalności", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        UPDATE Uzytkownicy SET 
                        Imie = @imie, Nazwisko = @nazwisko, Miejscowosc = @miasto, 
                        KodPocztowy = @postal_code, Ulica = @ulica, NumerPosesji = @nrPos, NumerLokalu = @nrLok, 
                        PESEL = @pesel, DataUrodzenia = @dataUr, Plec = @plec, 
                        Email = @email, Telefon = @telefon
                        WHERE UzytkownikID = @id";
                        
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@imie", name);
                        cmd.Parameters.AddWithValue("@nazwisko", surname);
                        cmd.Parameters.AddWithValue("@miasto", city);
                        cmd.Parameters.AddWithValue("@postal_code", postal_code);
                        cmd.Parameters.AddWithValue("@ulica", string.IsNullOrEmpty(street) ? (object)DBNull.Value : street);
                        cmd.Parameters.AddWithValue("@nrPos", street_number);
                        cmd.Parameters.AddWithValue("@nrLok", string.IsNullOrEmpty(locale_number) ? (object)DBNull.Value : locale_number);
                        cmd.Parameters.AddWithValue("@pesel", pesel);
                        cmd.Parameters.AddWithValue("@dataUr", birthdate);
                        cmd.Parameters.AddWithValue("@plec", gender);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefon", phone);
                        cmd.Parameters.AddWithValue("@id", selectedUserId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Dane użytkownika zostały pomyślnie zaktualizowane.");
                WczytajUzytkownikowDoListy();
                ZablokujPolaEdycji();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu: " + ex.Message);
            }
        }

        private void btn_cancel_edit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ZablokujPolaEdycji();
            cmbx_select_user_edit_SelectedIndexChanged(null, null);
            dotNetBarTabControl_manage_users.SelectedTab = tabPage_add_user; 
        }

        private void dotNetBarTabControl_manage_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dotNetBarTabControl_manage_users.SelectedTab == tabPage_edit_user)
            {
                WczytajUzytkownikowDoListy();
            }
            if (dotNetBarTabControl_manage_users.SelectedTab == tabPage_my_profile)
            {
                LoadMyProfile();
            }
        }

        private void ZaladujPodgladUzytkownika(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Uzytkownicy WHERE UzytkownikID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                msktbx_user_login_view.Text = reader["Login"].ToString();
                                msktbx_user_name_view.Text = reader["Imie"].ToString();
                                msktbx_user_surname_view.Text = reader["Nazwisko"].ToString();
                                cmbx_gender_view.Text = reader["Plec"].ToString();
                                msktbx_pesel_view.Text = reader["PESEL"].ToString();
                                msktbx_email_view.Text = reader["Email"].ToString();
                                msktbx_phone_view.Text = reader["Telefon"].ToString();
                                dtpckr_birthdate_view.Value = Convert.ToDateTime(reader["DataUrodzenia"]);
                                msktbx_city_view.Text = reader["Miejscowosc"].ToString();
                                msktbx_street_view.Text = reader["Ulica"].ToString();
                                msktbx_street_number_view.Text = reader["NumerPosesji"].ToString();
                                msktbx_locale_number_view.Text = reader["NumerLokalu"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania szczegółów: " + ex.Message);
            }
        }

        private void PokazZakladkePodgladu()
        {

            if (!dotNetBarTabControl_manage_users.TabPages.Contains(tabPage_view_user))
            {
                dotNetBarTabControl_manage_users.TabPages.Add(tabPage_view_user);
            }

            dotNetBarTabControl_main_view.SelectedTab = tabPage_users;

            dotNetBarTabControl_manage_users.SelectedTab = tabPage_view_user;
        }

        private void btn_save_role_changes_Click(object sender, EventArgs e)
        {
            if (cmbx_select_user_role_edit.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz użytkownika przed zapisaniem zmian.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clb_roles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Wybierz uprawnienia przed zapisania zmian.");
                return;
            }

            int userId = Convert.ToInt32(cmbx_select_user_role_edit.SelectedValue);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        using (SqlCommand deleteCmd = new SqlCommand(
                            "DELETE FROM Uzytkownicy_Uprawnienia WHERE UzytkownikID = @UserID", conn, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@UserID", userId);
                            deleteCmd.ExecuteNonQuery();
                        }

                        foreach (var item in clb_roles.CheckedItems)
                        {
                            DataRowView drv = (DataRowView)item;
                            int uprawnienieId = Convert.ToInt32(drv["UprawnienieID"]);

                            using (SqlCommand insertCmd = new SqlCommand(
                                "INSERT INTO Uzytkownicy_Uprawnienia (UzytkownikID, UprawnienieID) VALUES (@UserID, @UprawnienieID)",
                                conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@UserID", userId);
                                insertCmd.Parameters.AddWithValue("@UprawnienieID", uprawnienieId);
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Uprawnienia zapisane pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania uprawnień: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ZaladujUprawnieniaUzytkownika(userId);
            OdswiezUprawnieniaIZakladki();
        }

        private void btn_cancel_role_Click(object sender, EventArgs e)
        {
            dotNetBarTabControl_manage_roles.SelectedTab = tabPage_roles_overview;
        }

 

        private void UkryjZakladkePodgladu()
        {
            if (dotNetBarTabControl_manage_users.TabPages.Contains(tabPage_view_user))
            {
                if (dotNetBarTabControl_manage_users.SelectedTab == tabPage_view_user)
                {
                    dotNetBarTabControl_manage_users.SelectedIndex = 0;
                }

                dotNetBarTabControl_manage_users.TabPages.Remove(tabPage_view_user);
            }
        }
        private void dotNetBarTabControl_manage_roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dotNetBarTabControl_manage_roles.SelectedTab.Name == "tabPage_roles_overview")
            {
                database.RoleListDvg(dgv_roles);
            }
        }

        private void btn_group_edit_save_Click(object sender, EventArgs e)
        {
            var users = database.GetSelectedIds(clb_users_group_edit, "UzytkownikId");
            var roles = database.GetSelectedIds(clb_roles_group_edit, "UprawnienieId");

            database.SynchronizeRoles(users, roles);

            OdswiezUprawnieniaIZakladki();
        }

        private void btn_group_edit_cancel_Click(object sender, EventArgs e)
        {
            dotNetBarTabControl_manage_roles.SelectedTab = tabPage_roles_overview;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyloguj", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void tabPage_edit_roles_Enter(object sender, EventArgs e)
        {
            if (cmbx_select_user_role_edit.DataSource == null)
                ZaladujListeUzytkownikow();

            if (clb_roles.DataSource == null)
                ZaladujListeUprawnien();
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            string oldPass = tbx_profile_old_password.Text;
            string newPass = tbx_profile_new_password.Text;
            string repeat = tbx_profile_repeat_password.Text;

            Validation validation = new Validation();

            if (string.IsNullOrWhiteSpace(oldPass) ||
                string.IsNullOrWhiteSpace(newPass) ||
                string.IsNullOrWhiteSpace(repeat))
            {
                MessageBox.Show("Wszystkie pola hasła muszą być wypełnione.");
                return;
            }

            if (newPass != repeat)
            {
                MessageBox.Show("Nowe hasła nie są takie same.");
                return;
            }
            if (!validation.valid_password(newPass))
            {
                MessageBox.Show(@"Hasło nie spełnia wymaganych kryteriów:
                - długość od 8 do 15 znaków
                - co najmniej jedna wielka litera
                - co najmniej jedna mała litera
                - co najmniej jedna cyfra oraz znak specjalny");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getHashQuery = "SELECT HasloHash FROM Uzytkownicy WHERE UzytkownikID = @id";

                string currentHash = "";

                using (SqlCommand cmd = new SqlCommand(getHashQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", loggedUserId);
                    currentHash = cmd.ExecuteScalar()?.ToString();
                }

                if (!SecurePasswordHasher.Verify(oldPass, currentHash))
                {
                    MessageBox.Show("Stare hasło jest niepoprawne.");
                    return;
                }

                string newHash = SecurePasswordHasher.Hash(newPass);

                string updateQuery = "UPDATE Uzytkownicy SET HasloHash = @pass WHERE UzytkownikID = @id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@pass", newHash);
                    cmd.Parameters.AddWithValue("@id", loggedUserId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Hasło zostało zmienione.");

            tbx_profile_old_password.Clear();
            tbx_profile_new_password.Clear();
            tbx_profile_repeat_password.Clear();
        }

        private void btn_filter_perms_Click(object sender, EventArgs e)
        {
            if (!isFiltered)
            {
                if (cmbx_permissions.SelectedIndex <= 0 || cmbx_permissions.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Wybierz najpierw uprawnienie z listy rozwijanej.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int wybraneUprawnienieId = Convert.ToInt32(cmbx_permissions.SelectedValue);

                WczytajUzytkownikowZUprawnieniami(wybraneUprawnienieId);

                if (dgv_users_perms.DataSource != null)
                {
                    isFiltered = true;
                    btn_filter_perms.Text = "Odfiltruj";
                    btn_filter_perms.BackColor = Color.LightCoral; 
                    cmbx_permissions.Enabled = false;
                }
            }
            else
            {
                WczytajUzytkownikowZUprawnieniami();

                isFiltered = false;
                btn_filter_perms.Text = "Filtruj";
                btn_filter_perms.BackColor = SystemColors.Control;
                cmbx_permissions.Enabled = true;
                cmbx_permissions.SelectedIndex = 0; 
            }
        }

        private void btn_register_sale_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int invalids = 0;
            StringBuilder errorMessages = new StringBuilder();

            string clientName = tbx_sale_client_name.Text.Trim();
            string clientAddress = tbx_sale_client_address.Text.Trim();
            DateTime saleDate = dtp_sale_date.Value.Date;

            if (saleDate < DateTime.Today)
            {
                errorProvider.SetError(dtp_sale_date, "Data sprzedaży nie może być datą wsteczną");
                dtp_sale_date.BackColor = Color.Red;
                invalids++;
            }
            if (string.IsNullOrEmpty(clientName)) { errorProvider.SetError(tbx_sale_client_name, "Brak wymaganych pól"); tbx_sale_client_name.BackColor = Color.Red; invalids++; }
            if (string.IsNullOrEmpty(clientAddress)) { errorProvider.SetError(tbx_sale_client_address, "Brak wymaganych pól"); tbx_sale_client_address.BackColor = Color.Red; invalids++; }

            if (dtBasket.Rows.Count == 0)
            {
                MessageBox.Show("Koszyk jest pusty! Dodaj przynajmniej jeden towar przed zapisaniem sprzedaży.", "Brak pozycji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (invalids > 0)
            {
                MessageBox.Show("Popraw podświetlone pola formularza danych klienta.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        string insertHeader = "INSERT INTO Sprzedaz (NazwaKlienta, AdresKlienta, DataSprzedazy, SprzedawcaID) VALUES (@klient, @adres, @data, @sprzedawcaId); SELECT SCOPE_IDENTITY();";
                        int sprzedazId = 0;
                        using (SqlCommand cmd = new SqlCommand(insertHeader, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@klient", clientName);
                            cmd.Parameters.AddWithValue("@adres", clientAddress);
                            cmd.Parameters.AddWithValue("@data", saleDate);
                            cmd.Parameters.AddWithValue("@sprzedawcaId", loggedUserId);
                            sprzedazId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        foreach (DataRow row in dtBasket.Rows)
                        {
                            int tId = (int)row["TowarID"];
                            decimal qty = (decimal)row["Ilość"];
                            string insertItem = "INSERT INTO PozycjeSprzedazy (SprzedazID, TowarID, Ilosc) VALUES (@sId, @tId, @qty)";
                            using (SqlCommand cmd = new SqlCommand(insertItem, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@sId", sprzedazId);
                                cmd.Parameters.AddWithValue("@tId", tId);
                                cmd.Parameters.AddWithValue("@qty", qty);
                                cmd.ExecuteNonQuery();
                            }

                            string updateStock = "UPDATE StanyMagazynowe SET IloscDostepna = IloscDostepna - @qty WHERE TowarID = @tId";
                            using (SqlCommand cmd = new SqlCommand(updateStock, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@qty", qty);
                                cmd.Parameters.AddWithValue("@tId", tId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                        MessageBox.Show("Sprzedaż została zarejestrowana pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtBasket.Rows.Clear();
                        tbx_sale_client_name.Clear();
                        tbx_sale_client_address.Clear();
                        dtp_sale_date.Value = DateTime.Today;
                        tbx_sale_client_name.Enabled = true;
                        tbx_sale_client_address.Enabled = true;
                        dtp_sale_date.Enabled = true;
                        WczytajTowaryDoSprzedazy();
                        database.SearchSalesHistory(dgv_sales_history, null, null, "", "", "");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Krytyczny błąd zapisu transakcji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_add_to_basket_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            DateTime saleDate = dtp_sale_date.Value.Date;
            if (saleDate < DateTime.Today)
            {
                MessageBox.Show("Data sprzedaży nie może być datą wsteczną. Popraw datę przed dodaniem towarów do koszyka.", "Błędna data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_sale_date.BackColor = Color.Red;
                errorProvider.SetError(dtp_sale_date, "Data sprzedaży nie może być datą wsteczną.");
                return;
            }

            
            if (string.IsNullOrWhiteSpace(tbx_sale_client_name.Text) || string.IsNullOrWhiteSpace(tbx_sale_client_address.Text))
            {
                MessageBox.Show("Najpierw uzupełnij nazwę i adres klienta, zanim zaczniesz dodawać towary do koszyka.", "Brak danych klienta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrWhiteSpace(tbx_sale_client_name.Text)) tbx_sale_client_name.BackColor = Color.Red;
                if (string.IsNullOrWhiteSpace(tbx_sale_client_address.Text)) tbx_sale_client_address.BackColor = Color.Red;
                return;
            }

            if (cmbx_sale_product.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbx_sale_product, "Wybierz towar z listy.");
                cmbx_sale_product.BackColor = Color.Red;
                MessageBox.Show("Wybierz towar z rozwijanej listy przed dodaniem go do koszyka.", "Brak wybranego towaru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string quantityStr = tbx_sale_quantity.Text.Trim();
            if (!Regex.IsMatch(quantityStr, @"^\d+(\.\d+)?$") || quantityStr == "0")
            {
                errorProvider.SetError(tbx_sale_quantity, "Wprowadź poprawną ilość.");
                tbx_sale_quantity.BackColor = Color.Red;
                MessageBox.Show("Ilość nie może być zerowa, ujemna ani zawierać błędnych znaków.", "Błąd formatu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int towarId = (int)cmbx_sale_product.SelectedValue;
            decimal requestedQty = decimal.Parse(quantityStr, CultureInfo.InvariantCulture);

            
            string rawComboText = cmbx_sale_product.Text;
            string towarNazwa = rawComboText;
            int bracketIndex = rawComboText.LastIndexOf(" (Dostępne:");
            if (bracketIndex > 0)
            {
                towarNazwa = rawComboText.Substring(0, bracketIndex);
            }

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT sm.IloscDostepna, t.JednostkaMiary FROM StanyMagazynowe sm JOIN Towary t ON sm.TowarID = t.TowarID WHERE sm.TowarID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", towarId);
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            decimal stockQty = Convert.ToDecimal(r["IloscDostepna"]);
                            string unit = r["JednostkaMiary"].ToString();

                            if (unit == "Sztuki" && requestedQty % 1 != 0)
                            {
                                errorProvider.SetError(tbx_sale_quantity, "System blokuje ułamki dla Sztuk.");
                                tbx_sale_quantity.BackColor = Color.Red;
                                MessageBox.Show("Dla jednostki 'Sztuki' nie można wprowadzać wartości ułamkowych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            decimal alreadyInBasket = 0;
                            foreach (DataRow basketRow in dtBasket.Rows)
                            {
                                if ((int)basketRow["TowarID"] == towarId)
                                    alreadyInBasket += (decimal)basketRow["Ilość"];
                            }

                            if ((requestedQty + alreadyInBasket) > stockQty)
                            {
                                errorProvider.SetError(tbx_sale_quantity, "Przekroczenie stanu magazynowego.");
                                tbx_sale_quantity.BackColor = Color.Red;
                                MessageBox.Show($"Błąd: Niewystarczająca ilość towaru w magazynie (Dostępna: {stockQty}, w koszyku: {alreadyInBasket})", "Przekroczenie stanu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }

            bool rowFound = false;
            foreach (DataRow basketRow in dtBasket.Rows)
            {
                if ((int)basketRow["TowarID"] == towarId)
                {
                    basketRow["Ilość"] = (decimal)basketRow["Ilość"] + requestedQty;
                    rowFound = true;
                    break;
                }
            }

            if (!rowFound)
            {
                dtBasket.Rows.Add(towarId, towarNazwa, requestedQty);
            }

            tbx_sale_quantity.Clear();

            
            tbx_sale_client_name.Enabled = false;
            tbx_sale_client_address.Enabled = false;
            dtp_sale_date.Enabled = false;
            WczytajTowaryDoSprzedazy();
        }


        private void WczytajTowaryDoSprzedazy()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT t.TowarID, t.Nazwa, sm.IloscDostepna, t.JednostkaMiary
                FROM Towary t
                JOIN StanyMagazynowe sm ON t.TowarID = sm.TowarID
                WHERE sm.IloscDostepna > 0";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dtItems = new DataTable();
                    da.Fill(dtItems);
                    DataTable dtComboBoxSource = new DataTable();
                    dtComboBoxSource.Columns.Add("TowarID", typeof(int));
                    dtComboBoxSource.Columns.Add("DisplayText", typeof(string));

                    foreach (DataRow row in dtItems.Rows)
                    {
                        int towarId = (int)row["TowarID"];
                        string nazwa = row["Nazwa"].ToString();
                        decimal maxStock = Convert.ToDecimal(row["IloscDostepna"]);
                        string unit = row["JednostkaMiary"].ToString();
                        decimal qtyInBasket = 0;
                        if (dtBasket != null)
                        {
                            foreach (DataRow basketRow in dtBasket.Rows)
                            {
                                if ((int)basketRow["TowarID"] == towarId)
                                    qtyInBasket += (decimal)basketRow["Ilość"];
                            }
                        }

                        decimal dynamicAvailable = maxStock - qtyInBasket;

                        if (dynamicAvailable > 0)
                        {
                            string displayText = $"{nazwa} (Dostępne: {dynamicAvailable} {unit})";
                            dtComboBoxSource.Rows.Add(towarId, displayText);
                        }
                    }

                    cmbx_sale_product.DataSource = null;
                    cmbx_sale_product.DisplayMember = "DisplayText";
                    cmbx_sale_product.ValueMember = "TowarID";
                    cmbx_sale_product.DataSource = dtComboBoxSource;
                    cmbx_sale_product.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania towarów do sprzedaży: " + ex.Message);
            }
        }

        private void btn_search_sales_Click(object sender, EventArgs e)
        {
            dtp_sales_history_from.BackColor = Color.White;
            dtp_sales_history_to.BackColor = Color.White;

            DateTime? from = null;
            DateTime? to = null;

            if (chk_sales_history_dates.Checked)
            {
                if (dtp_sales_history_from.Value.Date > dtp_sales_history_to.Value.Date)
                {
                    MessageBox.Show("Data 'Od' nie może być późniejsza niż data 'Do'.",
                                    "Błąd zakresu dat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtp_sales_history_from.BackColor = Color.Red;
                    dtp_sales_history_to.BackColor = Color.Red;
                    return; 
                }

                from = dtp_sales_history_from.Value.Date;
                to = dtp_sales_history_to.Value.Date;
            }
            database.SearchSalesHistory(
                dgv_sales_history,
                from,
                to,
                tbx_history_buyer.Text.Trim(),
                tbx_history_seller.Text.Trim(),
                tbx_history_item.Text.Trim()
            );
        }

        private void dgv_sales_history_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int sprzedazId = Convert.ToInt32(dgv_sales_history.Rows[e.RowIndex].Cells["SprzedazID"].Value);
                string clientName, clientAddress, saleDate, sellerName;

                DataTable itemsTable = database.GetSaleDetails(sprzedazId, out clientName, out clientAddress, out saleDate, out sellerName);

                tbx_detail_buyer.Text = clientName;
                tbx_detail_address.Text = clientAddress;
                tbx_detail_date.Text = saleDate;
                tbx_detail_seller.Text = sellerName;

                dgv_sale_details.DataSource = itemsTable;

                if (!tabControl_sales.TabPages.Contains(tabPage_sale_details))
                {
                    tabControl_sales.TabPages.Add(tabPage_sale_details);
                }
                tabControl_sales.SelectedTab = tabPage_sale_details;
            }
        }

        private void btn_close_details_Click(object sender, EventArgs e)
        {
            if (tabControl_sales.TabPages.Contains(tabPage_sale_details))
            {
                tabControl_sales.SelectedTab = tabPage_sales_history;
                tabControl_sales.TabPages.Remove(tabPage_sale_details);
            }
        }

        private void LoadItemTypes()
        {
            DataTable typesTable = database.GetItemTypes();

            if (typesTable != null && typesTable.Rows.Count > 0)
            {
                cmbx_item_type.DataSource = typesTable;
                cmbx_item_type.DisplayMember = "Nazwa";
                cmbx_item_type.ValueMember = "RodzajID";
                cmbx_item_type.SelectedIndex = -1;
            }
        }

        private void btn_register_item_save_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int invalids = 0;

            StringBuilder errorMessages = new StringBuilder();
            bool showGenericError = false;

            DateTime deliveryDate = dtp_item_deliveryDate.Value.Date;
            if (deliveryDate > DateTime.Today)
            {
                errorProvider.SetError(dtp_item_deliveryDate, "Data dostawy nie może być z przyszłości.");
                errorMessages.AppendLine("Wskazana data dostawy jest nieprawidłowa. Data nie może być z przyszłości.\n");
                invalids++;
            }

            string name = tbx_item_name.Text.Trim();
            string description = tbx_item_description.Text.Trim();
            string supplier = tbx_item_supplier.Text.Trim();

            var inputs = new List<Control> { tbx_item_name, cmbx_item_type, cmbx_item_unit, tbx_item_quantity, tbx_item_price, cmbx_item_vat, tbx_item_description, tbx_item_supplier };
            foreach (var input in inputs) input.BackColor = Color.White;

            if (string.IsNullOrEmpty(name)) { errorProvider.SetError(tbx_item_name, "Brak wymaganych pól"); tbx_item_name.BackColor = Color.Red; invalids++; showGenericError = true; }
            if (string.IsNullOrEmpty(description)) { errorProvider.SetError(tbx_item_description, "Brak wymaganych pól"); tbx_item_description.BackColor = Color.Red; invalids++; showGenericError = true; }
            if (string.IsNullOrEmpty(supplier)) { errorProvider.SetError(tbx_item_supplier, "Brak wymaganych pól"); tbx_item_supplier.BackColor = Color.Red; invalids++; showGenericError = true; }
            if (cmbx_item_type.SelectedIndex == -1) { errorProvider.SetError(cmbx_item_type, "Brak wymaganych pól"); cmbx_item_type.BackColor = Color.Red; invalids++; showGenericError = true; }
            if (cmbx_item_unit.SelectedIndex == -1) { errorProvider.SetError(cmbx_item_unit, "Brak wymaganych pól"); cmbx_item_unit.BackColor = Color.Red; invalids++; showGenericError = true; }
            if (cmbx_item_vat.SelectedIndex == -1) { errorProvider.SetError(cmbx_item_vat, "Brak wymaganych pól"); cmbx_item_vat.BackColor = Color.Red; invalids++; showGenericError = true; }

            if (showGenericError)
            {
                errorMessages.AppendLine("Wypełnij wszystkie wymagane pola zaznaczone na czerwono.\n");
            }

            string priceStr = tbx_item_price.Text.Trim();
            decimal netPrice = 0m;

            if (string.IsNullOrEmpty(priceStr))
            {
                errorProvider.SetError(tbx_item_price, "Brak wymaganych pól");
                tbx_item_price.BackColor = Color.Red;
                invalids++;
            }
            else if (!Regex.IsMatch(priceStr, @"^\d+(,\d{1,2})?$"))
            {
                errorProvider.SetError(tbx_item_price, "Wprowadzono błędną cenę netto");
                tbx_item_price.BackColor = Color.Red;
                invalids++;

                errorMessages.AppendLine("Wprowadzono błędną cenne netto");
                errorMessages.AppendLine("Wymagania cenny netto:");
                errorMessages.AppendLine("- Format walutowy: Cena musi mieć maksymalnie dwa miejsca po przecinku (np. 10,50)");
                errorMessages.AppendLine("- Wartości nienumeryczne: Cena nie może zawierać niczego innego oprócz cyfr i separatora ( , )");
                errorMessages.AppendLine("- Wartości ujemne: Cena nie może być ujemna");
                errorMessages.AppendLine("- Błędny separator: Użycie znaku, którego system nie rozpoznaje (np. 10;50)\n");
            }
            else
            {
                netPrice = decimal.Parse(priceStr, new CultureInfo("pl-PL"));
            }

            string quantityStr = tbx_item_quantity.Text.Trim();
            decimal quantity = 0m;
            string unit = cmbx_item_unit.Text;
            bool isQuantityFormatError = false;

            if (string.IsNullOrEmpty(quantityStr))
            {
                errorProvider.SetError(tbx_item_quantity, "Brak wymaganych pól");
                tbx_item_quantity.BackColor = Color.Red;
                invalids++;
            }
            else
            {
                bool formatOk = Regex.IsMatch(quantityStr, @"^\d+(\.\d+)?$");
                decimal parsedQty = 0m;

                if (formatOk)
                {
                    decimal.TryParse(quantityStr, NumberStyles.Any, CultureInfo.InvariantCulture, out parsedQty);
                }

                if (!formatOk || parsedQty <= 0 || (unit == "Sztuki" && parsedQty % 1 != 0))
                {
                    errorProvider.SetError(tbx_item_quantity, "Wprowadzono błędną ilość/liczbę rejestrowanego towaru");
                    tbx_item_quantity.BackColor = Color.Red;
                    invalids++;
                    isQuantityFormatError = true;
                }
                else
                {
                    quantity = parsedQty;
                }
            }

            if (isQuantityFormatError)
            {
                errorMessages.AppendLine("Wprowadzono błędną ilość/liczbę rejestrowanego towaru");
                errorMessages.AppendLine("Wymagania ilości/liczby rejestrowanego towaru:");
                errorMessages.AppendLine("- Wartości nienumeryczne: ilość/liczba rejestrowanego towaru nie może zawierać niczego innego oprócz cyfr i separatora (.)");
                errorMessages.AppendLine("- Wartości ujemne: Ilość/liczba nie może być ujemna");
                errorMessages.AppendLine("- Wartości zerowe: ilość/liczba nie może być zerowa");
                errorMessages.AppendLine("- Błędny separator: Użycie znaku, którego system nie rozpoznaje (np. 1;5)");
                errorMessages.AppendLine("- Niezgodność z jednostką miary: Nie można dodać niecałkowitej liczby sztuk.\n");
            }

            if (invalids > 0)
            {
                MessageBox.Show(errorMessages.ToString().Trim(), "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal vatRate = 0m;
            string vatText = cmbx_item_vat.Text.Replace("%", "").Trim();
            if (vatText != "zw") vatRate = decimal.Parse(vatText);

            int typeId = (int)cmbx_item_type.SelectedValue;
            bool success = false;

            if (replenishItemId == -1)
            {
                success = database.RegisterNewItem(name, typeId, unit, description, netPrice, quantity, vatRate, supplier, deliveryDate, loggedUserId);
            }
            else
            {
                success = database.ReplenishExistingItem(replenishItemId, quantity, netPrice, vatRate, supplier, deliveryDate, loggedUserId);
            }

            if (success)
            {
                MessageBox.Show("Operacja zakończona pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_register_item_cancel_Click(null, null); 
                LoadWarehouseItems();
                WczytajTowaryDoSprzedazy();
            }
        }
        private void RejectItemQuantity()
        {
            errorProvider.SetError(tbx_item_quantity, "Wprowadzono błędną ilość rejestrowanego towaru");
            tbx_item_quantity.BackColor = Color.Red;
            string errorMsg = "Wprowadzono błędną ilość rejestrowanego towaru.\n\nWymagania ilości rejestrowanego towaru:\n- Wartości nienumeryczne: ilość nie może zawierać niczego innego oprócz cyfr i separatora (.)\n- Wartości ujemne: Ilość nie może być ujemna\n- Wartości zerowe: Ilość nie może być zerowa\n- Błędny separator: wymagany separator to . (kropka)";
            MessageBox.Show(errorMsg, "Błąd formatu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_register_item_cancel_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            replenishItemId = -1;
            var inputsToUnlock = new List<Control> { tbx_item_name, cmbx_item_type, cmbx_item_unit, tbx_item_price, cmbx_item_vat, tbx_item_description, tbx_item_supplier };
            foreach (var input in inputsToUnlock)
            {
                input.Enabled = true;
                input.BackColor = Color.White;
            }

            tbx_item_name.Clear();
            tbx_item_description.Clear();
            tbx_item_supplier.Clear();
            tbx_item_price.Clear();
            tbx_item_quantity.Clear();

            dtp_item_deliveryDate.Value = DateTime.Today; 

            cmbx_item_type.SelectedIndex = -1;
            cmbx_item_unit.SelectedIndex = -1;
            cmbx_item_vat.SelectedIndex = -1;
        }

        private void btn_add_item_type_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            tbx_item_type_name.BackColor = Color.White;

            string typeName = tbx_item_type_name.Text.Trim();

            // --- WYJĄTEK E1: Brak wymaganego pola ---
            if (string.IsNullOrEmpty(typeName))
            {
                errorProvider.SetError(tbx_item_type_name, "Brak wymaganych pól");
                tbx_item_type_name.BackColor = Color.Red;
                MessageBox.Show("Brak wymaganych pól", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- WYJĄTEK E2: Próba dodania duplikatu ---
            if (database.CheckIfItemTypeExists(typeName))
            {
                errorProvider.SetError(tbx_item_type_name, "Taki rodzaj towaru już istnieje");
                tbx_item_type_name.BackColor = Color.Red;
                MessageBox.Show("Podany rodzaj towaru już istnieje w systemie. Wprowadź inną nazwę.", "Konflikt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- SCENARIUSZ POZYTYWNY: Zapis i odświeżenie ---
            if (database.AddNewItemType(typeName))
            {
                MessageBox.Show("Rodzaj towaru został zarejestrowany pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbx_item_type_name.Clear();
                database.DisplayItemTypes(dgv_item_types);
                LoadItemTypes();
            }
        }

        private void btn_cancel_item_type_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            tbx_item_type_name.BackColor = Color.White;
            tbx_item_type_name.Clear();
        }

        private void dotNetBarTabControl_Add_Item_Type_Click(object sender, EventArgs e)
        {
            database.DisplayItemTypes(dgv_item_types);
        }

        private void btn_delete_item_type_Click(object sender, EventArgs e)
        {
            if (dgv_item_types.CurrentRow == null || dgv_item_types.CurrentRow.Index < 0)
            {
                MessageBox.Show("Wybierz rodzaj towaru z listy do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int typeId = Convert.ToInt32(dgv_item_types.CurrentRow.Cells["RodzajID"].Value);
            var result = MessageBox.Show("Czy na pewno chcesz usunąć wybrany rodzaj towaru?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            // --- SCENARIUSZ WYJĄTKU E1: Rodzaj towaru jest przypisany do towaru ---
            if (database.CheckIfItemTypeInUse(typeId))
            {
                MessageBox.Show("Ten rodzaj towaru jest przypisany do towaru. Najpierw usuń towar z tym rodzajem towaru", "Błąd usuwania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // --- SCENARIUSZ POZYTYWNY: Usunięcie i odświeżenie ---
            if (database.DeleteItemType(typeId))
            {
                MessageBox.Show("Rodzaj towaru został usunięty pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                database.DisplayItemTypes(dgv_item_types);
                LoadItemTypes();
            }
        }

        private void btn_delete_item_Click(object sender, EventArgs e)
        {
            if (dgv_warehouse_items.CurrentRow == null || dgv_warehouse_items.CurrentRow.Index < 0)
            {
                MessageBox.Show("Wybierz towar z listy do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int itemId = Convert.ToInt32(dgv_warehouse_items.CurrentRow.Cells["TowarID"].Value);
            string itemName = dgv_warehouse_items.CurrentRow.Cells["Nazwa towaru"].Value.ToString();
            var result = MessageBox.Show($"Czy na pewno chcesz usunąć towar: {itemName}?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // --- Weryfikacja historii towaru ---
            if (database.CheckIfItemHasHistory(itemId))
            {
                MessageBox.Show("Nie można usunąć tego towaru, ponieważ widnieje on w historii dostaw lub sprzedaży.\n\nSkontaktuj się z administratorem w celu wycofania towaru z oferty.", "Blokada usunięcia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Scenariusz Pozytywny: Usunięcie ---
            if (database.DeleteItem(itemId))
            {
                MessageBox.Show("Towar został usunięty pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WczytajTowaryDoSprzedazy();
                LoadWarehouseItems();
            }
        }

        private void chk_use_history_date_CheckedChanged(object sender, EventArgs e)
        {
            dtp_history_date.Enabled = chk_use_history_date.Checked;
        }
        private void btn_search_items_Click(object sender, EventArgs e)
        {
            if (!isItemFiltered)
            {
                string searchPhrase = tbx_item_search.Text.Trim();
                DateTime? selectedDate = null;

                if (chk_use_history_date.Checked)
                {
                    selectedDate = dtp_history_date.Value.Date;
                }

                if (string.IsNullOrEmpty(searchPhrase) && !chk_use_history_date.Checked)
                {
                    MessageBox.Show("Wprowadź kryteria wyszukiwania lub wybierz datę historyczną.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool isFound = database.SearchWarehouseItems(dgv_warehouse_items, searchPhrase, selectedDate);

                if (isFound)
                {
                    isItemFiltered = true;
                    btn_search_items.Text = "Odfiltruj";
                    btn_search_items.BackColor = Color.LightCoral;

                    tbx_item_search.Enabled = false;
                    chk_use_history_date.Enabled = false;
                    dtp_history_date.Enabled = false;
                }
            }
            else
            {
                LoadWarehouseItems();

                isItemFiltered = false;
                btn_search_items.Text = "Wyszukaj";
                btn_search_items.BackColor = SystemColors.Control;

                tbx_item_search.Clear();
                tbx_item_search.Enabled = true;

                SetWarehousePermissions();
            }
        }
        private void dgv_item_history_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_item_history.Rows[e.RowIndex];

                tbx_det_quantity.Text = row.Cells["Dodana Ilość"].Value.ToString();
                tbx_det_netPrice.Text = row.Cells["Cena Netto"].Value.ToString();
                tbx_det_vat.Text = row.Cells["VAT (%)"].Value.ToString();
                tbx_det_supplier.Text = row.Cells["Dostawca"].Value.ToString();

                tbx_det_deliveryDate.Text = Convert.ToDateTime(row.Cells["Data Dostawy"].Value).ToShortDateString();
                tbx_det_sysDate.Text = Convert.ToDateTime(row.Cells["Data Wprowadzenia do Systemu"].Value).ToShortDateString();

                tbx_det_employee.Text = row.Cells["Zarejestrował Pracownik"].Value.ToString();

                var extraDetails = database.GetItemExtraDetails(currentHistoryItemId);
                if (extraDetails.Count > 0)
                {
                    tbx_det_itemName.Text = extraDetails["Nazwa"];
                    tbx_det_description.Text = extraDetails["Opis"];
                    tbx_det_unit.Text = extraDetails["JednostkaMiary"];
                    tbx_det_itemType.Text = extraDetails["Rodzaj"];
                }

                if (!tabPage_items.TabPages.Contains(tabPage_Delivery_Details))
                {
                    tabPage_items.TabPages.Add(tabPage_Delivery_Details);
                }

                tabPage_items.SelectedTab = tabPage_Delivery_Details;
            }
        }
        private void ZaladujListeUzytkownikow()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UzytkownikID, Login + ' - ' + Imie + ' ' + Nazwisko AS DisplayText FROM Uzytkownicy WHERE ISNULL(CzyZapomniany, 0) = 0";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbx_select_user_role_edit.DisplayMember = "DisplayText";
                    cmbx_select_user_role_edit.ValueMember = "UzytkownikID";
                    cmbx_select_user_role_edit.DataSource = dt;
                    cmbx_select_user_role_edit.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania listy użytkowników: " + ex.Message);
            }
        }
        private void ZaladujListeUprawnien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UprawnienieID, Nazwa FROM Uprawnienia";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    clb_roles.DataSource = dt;
                    clb_roles.DisplayMember = "Nazwa";
                    clb_roles.ValueMember = "UprawnienieID";
                    clb_roles.ClearSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania listy uprawnień: " + ex.Message);
            }
        }

        private void dgv_warehouse_items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!currentUserPermissions.Contains(2) && !currentUserPermissions.Contains(1))
                {
                    MessageBox.Show("Brak uprawnień. Tylko Kierownik magazynu może przeglądać historię uzupełnień.", "Brak dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int itemId = Convert.ToInt32(dgv_warehouse_items.Rows[e.RowIndex].Cells["TowarID"].Value);

                ShowItemHistoryTab(itemId);
            }
        }
        private void chk_history_use_dates_CheckedChanged(object sender, EventArgs e)
        {
            dtp_history_from.Enabled = chk_history_use_dates.Checked;
            dtp_history_to.Enabled = chk_history_use_dates.Checked;
        }

        private void btn_history_filter_Click(object sender, EventArgs e)
        {
            if (currentHistoryItemId == -1) return;

            if (!isHistoryFiltered)
            {
                DateTime? dateFrom = null;
                DateTime? dateTo = null;
                string employee = tbx_history_employee.Text.Trim();

                if (chk_history_use_dates.Checked)
                {
                    dateFrom = dtp_history_from.Value.Date;
                    dateTo = dtp_history_to.Value.Date;

                    if (dateFrom > dateTo)
                    {
                        MessageBox.Show("Data 'Od' nie może być późniejsza niż data 'Do'.", "Błąd daty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (!chk_history_use_dates.Checked && string.IsNullOrEmpty(employee))
                {
                    MessageBox.Show("Wprowadź imię i nazwisko pracownika lub włącz filtrowanie po datach.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool found = database.GetItemReplenishmentHistory(dgv_item_history, currentHistoryItemId, dateFrom, dateTo, employee);

                if (found)
                {
                    isHistoryFiltered = true;
                    btn_history_filter.Text = "Odfiltruj";
                    btn_history_filter.BackColor = Color.LightCoral;

                    chk_history_use_dates.Enabled = false;
                    dtp_history_from.Enabled = false;
                    dtp_history_to.Enabled = false;
                    tbx_history_employee.Enabled = false;
                }
                else
                {
                    if (chk_history_use_dates.Checked && string.IsNullOrEmpty(employee))
                    {
                        MessageBox.Show("Brak wpisów w historii uzupełnień dla wybranego zakresu dat.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (!string.IsNullOrEmpty(employee) && !chk_history_use_dates.Checked)
                    {
                        MessageBox.Show("Brak wpisów w historii uzupełnień dla wskazanego pracownika.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Brak wyników spełniających połączone kryteria (data i pracownik).", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                database.GetItemReplenishmentHistory(dgv_item_history, currentHistoryItemId, null, null, null);

                isHistoryFiltered = false;
                btn_history_filter.Text = "Filtruj";
                btn_history_filter.BackColor = SystemColors.Control;

                chk_history_use_dates.Enabled = true;
                dtp_history_from.Enabled = chk_history_use_dates.Checked; 
                dtp_history_to.Enabled = chk_history_use_dates.Checked;
                tbx_history_employee.Enabled = true;
                tbx_history_employee.Clear();
            }
        }

        private void btn_history_close_Click(object sender, EventArgs e)
        {
            if (tabPage_items.TabPages.Contains(tabPage_Item_History))
            {
 
                tabPage_items.SelectedTab = tabPage_Warehouse;

                tabPage_items.TabPages.Remove(tabPage_Item_History);
            }
        }
        private void ShowItemHistoryTab(int itemId)
        {
            currentHistoryItemId = itemId;
            isHistoryFiltered = false;

            dtp_history_from.Value = DateTime.Today.AddMonths(-1);
            dtp_history_to.Value = DateTime.Today;
            chk_history_use_dates.Checked = false;
            dtp_history_from.Enabled = false;
            dtp_history_to.Enabled = false;
            tbx_history_employee.Clear();
            tbx_history_employee.Enabled = true;

            btn_history_filter.Text = "Filtruj";
            btn_history_filter.BackColor = SystemColors.Control;

            bool hasHistory = database.GetItemReplenishmentHistory(dgv_item_history, currentHistoryItemId, null, null, null);

            if (!hasHistory)
            {
                MessageBox.Show("Wybrany towar nie posiada jeszcze żadnej historii uzupełnień.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_item_history.DataSource = null;

                if (tabPage_items.TabPages.Contains(tabPage_Item_History))
                {
                    tabPage_items.TabPages.Remove(tabPage_Item_History);
                }

                return;
            }

            if (!tabPage_items.TabPages.Contains(tabPage_Item_History))
            {
                tabPage_items.TabPages.Add(tabPage_Item_History);
            }
            tabPage_items.SelectedTab = tabPage_Item_History;
        }

        private void btn_det_close_Click(object sender, EventArgs e)
        {
            if (tabPage_items.TabPages.Contains(tabPage_Delivery_Details))
            {
                tabPage_items.SelectedTab = tabPage_Item_History;
                tabPage_items.TabPages.Remove(tabPage_Delivery_Details);

                tbx_det_itemName.Clear();
                tbx_det_quantity.Clear();
                tbx_det_netPrice.Clear();
                tbx_det_vat.Clear();
                tbx_det_supplier.Clear();
                tbx_det_deliveryDate.Clear();
                tbx_det_sysDate.Clear();
                tbx_det_employee.Clear();
                tbx_det_description.Clear();
                tbx_det_unit.Clear();
                tbx_det_itemType.Clear();
            }
        }

        private void btn_change_item_vat_Click(object sender, EventArgs e)
        {
            if (!currentUserPermissions.Contains(2) && !currentUserPermissions.Contains(1))
            {
                MessageBox.Show("Brak uprawnień. Tylko Kierownik magazynu może zmieniać stawki VAT.", "Brak dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_warehouse_items.CurrentRow == null || dgv_warehouse_items.CurrentRow.Index < 0)
            {
                MessageBox.Show("Wybierz towar z listy.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            vatChangeMode = 1;
            selectedVatItemId = Convert.ToInt32(dgv_warehouse_items.CurrentRow.Cells["TowarID"].Value);

            lbl_vat_mode_title.Text = "Zmiana stawki VAT dla towaru";
            tbx_vat_item_name.Visible = true;
            tbx_vat_item_name.Text = dgv_warehouse_items.CurrentRow.Cells["Nazwa towaru"].Value.ToString();
            cmb_vat_category.Visible = false;

            cmb_vat_category.BackColor = SystemColors.Window;
            dtp_vat_date.Value = DateTime.Today.AddDays(1); 

            ShowVatChangeTab();
        }

        private void btn_change_category_vat_Click(object sender, EventArgs e)
        {
            if (!currentUserPermissions.Contains(2) && !currentUserPermissions.Contains(1))
            {
                MessageBox.Show("Brak uprawnień.", "Brak dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            vatChangeMode = 2;

            lbl_vat_mode_title.Text = "Masowa zmiana stawki VAT dla rodzaju towaru";
            tbx_vat_item_name.Visible = false;
            cmb_vat_category.Visible = true;
            cmb_vat_category.BackColor = SystemColors.Window;

            LoadItemTypesToComboBox(cmb_vat_category);
            dtp_vat_date.Value = DateTime.Today.AddDays(1);

            ShowVatChangeTab();
        }
        private void cmbx_select_user_role_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_select_user_role_edit.SelectedIndex == -1)
                return;

            int userId = Convert.ToInt32(cmbx_select_user_role_edit.SelectedValue);

            if (clb_roles.DataSource != null)
                ZaladujUprawnieniaUzytkownika(userId);
        }

        private void btn_vat_save_Click(object sender, EventArgs e)
        {
            // E7: Brak wymaganego wyboru rodzaju towaru (Tryb 2)
            if (vatChangeMode == 2 && cmb_vat_category.SelectedValue == null)
            {
                cmb_vat_category.BackColor = Color.LightCoral;
                MessageBox.Show("Brak wymaganych pól", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmb_vat_category.BackColor = SystemColors.Window; 

            if (cmb_new_vat.SelectedItem == null)
            {
                MessageBox.Show("Wybierz nową stawkę VAT.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal newVat = Convert.ToDecimal(cmb_new_vat.SelectedItem);
            DateTime selectedDate = dtp_vat_date.Value.Date;
            if (selectedDate <= DateTime.Today)
            {
                MessageBox.Show("Data obowiązywania nowej stawki musi być datą przyszłą", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = false;

            if (vatChangeMode == 1) 
            {
                decimal currentVat = database.GetCurrentItemVat(selectedVatItemId);

                // E1: Brak zmian stawki VAT towaru
                if (currentVat == newVat)
                {
                    MessageBox.Show("Nie wprowadzono żadnych zmian", "Blokada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                success = database.SaveVatChangeForItem(selectedVatItemId, newVat, selectedDate);
            }
            else if (vatChangeMode == 2) 
            {
                int selectedCategoryId = Convert.ToInt32(cmb_vat_category.SelectedValue);

                // E2: Brak zmian stawki VAT rodzaju towaru
                if (!database.CheckIfCategoryNeedsVatChange(selectedCategoryId, newVat))
                {
                    MessageBox.Show("Nie wprowadzono żadnych zmian (wszystkie towary w tej kategorii mają już tę stawkę)", "Blokada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                success = database.SaveVatChangeForCategory(selectedCategoryId, newVat, selectedDate);
            }

            if (success)
            {
                MessageBox.Show("Zmiany zostały zapisane", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseVatChangeTab();
            }
        }

        private void btn_vat_cancel_Click(object sender, EventArgs e)
        {
            CloseVatChangeTab();
        }

        private void ZaladujUprawnieniaUzytkownika(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT UprawnienieID
                FROM Uzytkownicy_Uprawnienia
                WHERE UzytkownikID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    for (int i = 0; i < clb_roles.Items.Count; i++)
                        clb_roles.SetItemChecked(i, false);

                    while (reader.Read())
                    {
                        int uprawnienieId = reader.GetInt32(0);
                        for (int i = 0; i < clb_roles.Items.Count; i++)
                        {
                            DataRowView drv = (DataRowView)clb_roles.Items[i];
                            if ((int)drv["UprawnienieID"] == uprawnienieId)
                            {
                                clb_roles.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                    clb_roles.ClearSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania uprawnień użytkownika: " + ex.Message);
            }
        }
        

        private void WczytajUprawnienia()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UprawnienieID, Nazwa FROM Uprawnienia";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow emptyRow = dt.NewRow();
                    emptyRow["UprawnienieID"] = DBNull.Value;
                    emptyRow["Nazwa"] = "--- Wybierz uprawnienie ---";
                    dt.Rows.InsertAt(emptyRow, 0);

                    cmbx_permissions.DataSource = dt;
                    cmbx_permissions.DisplayMember = "Nazwa";
                    cmbx_permissions.ValueMember = "UprawnienieID";
                    cmbx_permissions.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania listy uprawnień: " + ex.Message);
            }
        }

        private void btn_replenish_item_Click(object sender, EventArgs e)
        {
            if (dgv_warehouse_items.CurrentRow == null || dgv_warehouse_items.CurrentRow.Index < 0)
            {
                MessageBox.Show("zaznacz towar na liście, a następnie kliknij przycisk, aby uzupełnić jego stan.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            errorProvider.Clear();

            var allInputs = new List<Control> { tbx_item_name, cmbx_item_type, cmbx_item_unit, tbx_item_quantity, tbx_item_price, cmbx_item_vat, tbx_item_description, tbx_item_supplier };
            foreach (var input in allInputs)
            {
                input.BackColor = Color.White;
            }

            replenishItemId = Convert.ToInt32(dgv_warehouse_items.CurrentRow.Cells["TowarID"].Value);
            var details = database.GetItemFullDetailsForReplenish(replenishItemId);

            if (details.Count > 0)
            {
                tbx_item_name.Text = details.ContainsKey("Nazwa") ? details["Nazwa"] : "";
                tbx_item_description.Text = details.ContainsKey("Opis") ? details["Opis"] : "";
                cmbx_item_unit.Text = details.ContainsKey("JednostkaMiary") ? details["JednostkaMiary"] : "";
                cmbx_item_type.Text = details.ContainsKey("Rodzaj") ? details["Rodzaj"] : "";

                tbx_item_price.Text = details.ContainsKey("CenaNetto") ? details["CenaNetto"] : "";
                tbx_item_supplier.Text = details.ContainsKey("Dostawca") ? details["Dostawca"] : "";

                if (details.ContainsKey("VAT"))
                {
                    cmbx_item_vat.Text = details["VAT"];
                }

                dtp_item_deliveryDate.Value = DateTime.Today;
                tbx_item_quantity.Clear();

                var inputsToLock = new List<Control> { tbx_item_name, cmbx_item_type, cmbx_item_unit, tbx_item_price, cmbx_item_vat, tbx_item_description, tbx_item_supplier };
                foreach (var input in inputsToLock) input.Enabled = false;

                tbx_item_quantity.Focus();

                MessageBox.Show("Dane towaru zostały załadowane. Wpisz ilość oraz wskaż datę dostawy, a następnie kliknij Zapisz.", "Tryb uzupełniania", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void WczytajUzytkownikowZUprawnieniami(int? uprawnienieId = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                            SELECT 
                                u.Imie,
                                u.Nazwisko,
                                STRING_AGG(CAST(uu.UprawnienieID AS VARCHAR(10)), ', ') AS Uprawnienia
                            FROM Uzytkownicy u
                            LEFT JOIN Uzytkownicy_Uprawnienia uu 
                                ON u.UzytkownikID = uu.UzytkownikID
                            WHERE ISNULL(u.CzyZapomniany, 0) = 0";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (uprawnienieId.HasValue)
                    {
                        query += @"
                            AND u.UzytkownikID IN (
                            SELECT UzytkownikID 
                            FROM Uzytkownicy_Uprawnienia 
                            WHERE UprawnienieID = @permId)";

                        cmd.Parameters.AddWithValue("@permId", uprawnienieId.Value);
                    }

                    query += @"
                            GROUP BY u.Imie, u.Nazwisko
                            ORDER BY u.Nazwisko, u.Imie";

                    cmd.CommandText = query;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_users_perms.DataSource = dt;
                    dgv_users_perms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (uprawnienieId.HasValue && dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "Nie znaleziono użytkowników o wskazanym uprawnieniu",
                            "Brak wyników",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania danych: " + ex.Message);
            }
        }

        private void LoadMyProfile()
        {
            if (loggedUserId == -1) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT Login, Imie, Nazwisko, Email
            FROM Uzytkownicy
            WHERE UzytkownikID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", loggedUserId);

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            tbx_profile_login.Text = r["Login"].ToString();
                            tbx_profile_name.Text = r["Imie"].ToString();
                            tbx_profile_surname.Text = r["Nazwisko"].ToString();
                            tbx_profile_email.Text = r["Email"].ToString();
                        }
                    }
                }
            }
        }

        private void btn_remove_from_basket_Click(object sender, EventArgs e)
        {
            if (dgv_sale_basket.CurrentRow == null || dgv_sale_basket.CurrentRow.Index < 0)
            {
                MessageBox.Show("Zaznacz pozycję w koszyku, którą chcesz usunąć.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selectedRowView = (DataRowView)dgv_sale_basket.CurrentRow.DataBoundItem;
            DataRow rowToDelete = selectedRowView.Row;
            dtBasket.Rows.Remove(rowToDelete);
            if (dtBasket.Rows.Count == 0)
            {
                tbx_sale_client_name.Enabled = true;
                tbx_sale_client_address.Enabled = true;
                dtp_sale_date.Enabled = true;
            }
            WczytajTowaryDoSprzedazy();
        }

        private void btn_cancel_sale_Click(object sender, EventArgs e)
        {
            if (dtBasket != null && dtBasket.Rows.Count > 0)
            {
                var result = MessageBox.Show("Czy na pewno chcesz anulować obecną sprzedaż? Koszyk zostanie wyczyszczony, a wprowadzone dane klienta usunięte.", "Potwierdzenie anulowania", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;
            }

            if (dtBasket != null) dtBasket.Rows.Clear();

            tbx_sale_client_name.Clear();
            tbx_sale_client_address.Clear();
            dtp_sale_date.Value = DateTime.Today;
            tbx_sale_quantity.Clear();
            cmbx_sale_product.SelectedIndex = -1;
            tbx_sale_client_name.Enabled = true;
            tbx_sale_client_address.Enabled = true;
            dtp_sale_date.Enabled = true;

            errorProvider.Clear(); 

            var inputsToReset = new List<Control> {
        tbx_sale_client_name,
        tbx_sale_client_address,
        dtp_sale_date,
        cmbx_sale_product,
        tbx_sale_quantity
    };

            foreach (var input in inputsToReset)
            {
                input.BackColor = Color.White;
            }
            WczytajTowaryDoSprzedazy();
        }

        private void btn_admin_password_reset_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();

            string newPassword = tbx_admin_password_reset.Text.Trim();

            if(string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Brak wymaganych pól");
                return;
            }

            if (!validation.valid_password(newPassword))
            {
                MessageBox.Show(@"Hasło nie spełnia wymaganych kryteriów:
                - długość od 8 do 15 znaków
                - co najmniej jedna wielka litera
                - co najmniej jedna mała litera
                - co najmniej jedna cyfra oraz znak specjalny");
                return;
            }

            string newHash = SecurePasswordHasher.Hash(newPassword);
            string login = msktbx_user_login_edit.Text.Trim();
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = "UPDATE Uzytkownicy SET HasloHash = @password WHERE Login = @login";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@password", newHash);
                            cmd.Parameters.AddWithValue("@login", login);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();

                        MessageBox.Show("Hasło zostało zmienione.");
                        tbx_admin_password_reset.Text = "";
                    }
                    catch (Exception exTransaction)
                    {
                        transaction.Rollback();
                        throw exTransaction;
                    }
                }
            }
        }

        private void chk_sales_history_dates_CheckedChanged(object sender, EventArgs e)
        {
            dtp_sales_history_from.Enabled = chk_sales_history_dates.Checked;
            dtp_sales_history_to.Enabled = chk_sales_history_dates.Checked;
        }
        

        private void LoadProfileRoles(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT UprawnienieID, Nazwa
                    FROM Uprawnienia";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            clb_profile_roles.Items.Clear();

                            while (reader.Read())
                            {
                                var uprawnienieID = reader.GetInt32(0);
                                var nazwa = reader.GetString(1);

                                clb_profile_roles.Items.Add(new { UprawnienieID = uprawnienieID, Nazwa = nazwa });
                            }
                        }
                    }

                    clb_profile_roles.DisplayMember = "Nazwa";

                    clb_profile_roles.Enabled = false;

                    foreach (var permissionId in currentUserPermissions)
                    {
                        for (int i = 0; i < clb_profile_roles.Items.Count; i++)
                        {
                            var item = (dynamic)clb_profile_roles.Items[i];
                            if (item.UprawnienieID == permissionId)
                            {
                                clb_profile_roles.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania ról: " + ex.Message);
            }
        }

        private void SetWarehousePermissions()
        {
            bool isManager = currentUserPermissions.Contains(2);

            chk_use_history_date.Enabled = isManager;
            dtp_history_date.MaxDate = DateTime.Today;

            if (!isManager)
            {
                chk_use_history_date.Checked = false;
                dtp_history_date.Enabled = false;
            }
        }

        private void LoadWarehouseItems()
        {
            database.SearchWarehouseItems(dgv_warehouse_items, "", null);
        }
        private void ShowVatChangeTab()
        {
            if (!tabPage_items.TabPages.Contains(tabPage_Vat_Change))
            {
                tabPage_items.TabPages.Add(tabPage_Vat_Change);
            }
            tabPage_items.SelectedTab = tabPage_Vat_Change;
        }
        private void CloseVatChangeTab()
        {
            if (tabPage_items.TabPages.Contains(tabPage_Vat_Change))
            {
                tabPage_items.SelectedTab = tabPage_Warehouse;
                tabPage_items.TabPages.Remove(tabPage_Vat_Change);
            }
        }
        private void LoadItemTypesToComboBox(System.Windows.Forms.ComboBox targetComboBox)
        {
            System.Data.DataTable typesTable = database.GetItemTypes();

            if (typesTable != null && typesTable.Rows.Count > 0)
            {
                targetComboBox.DataSource = typesTable;
                targetComboBox.DisplayMember = "Nazwa";
                targetComboBox.ValueMember = "RodzajID";
                targetComboBox.SelectedIndex = -1; 
            }
        }

        private void InicjalizujKoszyk()
        {
            dtBasket = new DataTable();
            dtBasket.Columns.Add("TowarID", typeof(int));
            dtBasket.Columns.Add("Nazwa towaru", typeof(string));
            dtBasket.Columns.Add("Ilość", typeof(decimal));
            dgv_sale_basket.DataSource = dtBasket;
            if (dgv_sale_basket.Columns["TowarID"] != null) dgv_sale_basket.Columns["TowarID"].Visible = false;
            dgv_sale_basket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PrzypiszAutomatyczneCzyszczenieBledow()
        {
            var controls = new List<Control> {
                tbx_sale_client_name, tbx_sale_client_address, tbx_sale_quantity, cmbx_sale_product, dtp_sale_date,
                tbx_item_name, tbx_item_quantity, tbx_item_price, tbx_item_supplier, tbx_item_description, cmbx_item_type, cmbx_item_unit, cmbx_item_vat
            };

            foreach (var ctrl in controls)
            {
                if (ctrl is System.Windows.Forms.TextBox || ctrl is MaskedTextBox)
                    ctrl.TextChanged += (s, e) => { ctrl.BackColor = Color.White; errorProvider.SetError(ctrl, ""); };
                else if (ctrl is System.Windows.Forms.ComboBox)
                    ((System.Windows.Forms.ComboBox)ctrl).SelectedIndexChanged += (s, e) => { ctrl.BackColor = Color.White; errorProvider.SetError(ctrl, ""); };
                else if (ctrl is DateTimePicker)
                    ((DateTimePicker)ctrl).ValueChanged += (s, e) => { ctrl.BackColor = Color.White; errorProvider.SetError(ctrl, ""); };
            }
        }

        public void OdswiezUprawnieniaIZakladki()
        {
            LoadUserPermissions(loggedUserId);
            TabPage previouslySelected = dotNetBarTabControl_main_view.SelectedTab;
            dotNetBarTabControl_main_view.TabPages.Clear();

            foreach (TabPage tab in masterMainTabs)
            {
                bool hasAccess = false;

                if (tab == tabPage_my_profile)
                {
                    hasAccess = true; 
                }
                else if (tab == tabPage_overview || tab == tabPage_users || tab == tabPage_roles)
                {
                    hasAccess = currentUserPermissions.Contains(1); 
                }
                else if (tab == tabPage_manage_warehouse)
                {
                    hasAccess = currentUserPermissions.Contains(2) || currentUserPermissions.Contains(3);
                }
                else if (tab == tabPage_manage_sales)
                {
                    hasAccess = currentUserPermissions.Contains(2) || currentUserPermissions.Contains(4);
                }

                if (hasAccess)
                {
                    dotNetBarTabControl_main_view.TabPages.Add(tab);
                }
            }

            if (previouslySelected != null && dotNetBarTabControl_main_view.TabPages.Contains(previouslySelected))
            {
                dotNetBarTabControl_main_view.SelectedTab = previouslySelected;
            }
            else if (dotNetBarTabControl_main_view.TabPages.Count > 0)
            {
                dotNetBarTabControl_main_view.SelectedIndex = 0;
            }

            SetWarehousePermissions();
        }
    }
}
