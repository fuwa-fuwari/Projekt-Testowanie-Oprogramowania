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
        private int selectedUserId = -1;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True";
        private int currentViewUserId = -1;

        // Zmienne do sprawdzania, czy wprowadzono zmiany (można usnąć, ale będą wysyłane zapytania do bazy nawet, jeśli nic się nie zmieniło)
        private string origName, origSurname, origGender, origPesel, origEmail, origPhone;
        private DateTime origBirthdate;
        private string origCity, origStreet, origStreetNumber, origLocaleNumber;
        public ControlPanel()
        {
            InitializeComponent();
            WczytajUzytkownikowDoListy();
            ZablokujPolaEdycji();
            tbx_search.GotFocus += tbx_search_GotFocus;
            
            //Ukrywanie zakładki z podglądem
            if (dotNetBarTabControl_manage_users.TabPages.Contains(tabPage_view_user))
            {
                dotNetBarTabControl_manage_users.TabPages.Remove(tabPage_view_user);
            }

        }
        private void tbx_search_GotFocus(object sender, EventArgs e)
        {
            tbx_search.Clear();
        }
        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            var login = msktbx_user_login.Text;
            var password = msktbx_password.Text;
            var name = msktbx_user_name.Text;
            var surname = msktbx_user_surname.Text;
            var gender = cmbx_gender.Text;
            var pesel = msktbx_pesel.Text;
            var email = msktbx_email.Text;
            var phone = msktbx_phone.Text;
            var birthdate = dtpckr_birthdate.Value.Date;
            var city = msktbx_city.Text;
            var street = msktbx_street.Text;
            var street_number = msktbx_street_number.Text;
            var locale_number = msktbx_locale_number.Text;
            int invalids = 0;

            List<Control> textboxes = new List<Control>
                {
                    msktbx_user_login,
                    msktbx_password,
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
            foreach (var textbox in textboxes)
            {
                textbox.BackColor = Color.White;
            }

            if (!validation.valid_login(login))
            {

                invalids++;
                msktbx_user_login.BackColor = Color.Red;
            }
            if (!validation.valid_password(password))
            {
                invalids++;
                msktbx_password.BackColor = Color.Red;
            }
            if (!validation.valid_name(name))
            {
                
                invalids++;
                 msktbx_user_name.BackColor = Color.Red; 
            }
            if (!validation.valid_surname(surname))
            {
                
                invalids++;
                msktbx_user_surname.BackColor = Color.Red; 
            }
            if (!validation.valid_gender(gender, pesel))
            {
                
                invalids++;
                cmbx_gender.BackColor = Color.Red; 
            }
            if (!validation.valid_birthdate(birthdate.Date, pesel))
            {
                
                invalids++;
                dtpckr_birthdate.BackColor = Color.Red; 
                msktbx_pesel.BackColor = Color.Red;
            }
            if (!validation.valid_pesel(pesel, birthdate.Date, gender))
            {
                
                invalids++;
                msktbx_pesel.BackColor = Color.Red; 
            }
            if (!validation.valid_email(email))
            {
                
                invalids++;
                msktbx_email.BackColor = Color.Red; 
            }
            if (!validation.valid_phone(phone))
            {
                
                invalids++;
                msktbx_phone.BackColor = Color.Red; 
            }
            if (!validation.valid_city(city))
            {
                
                invalids++;
                msktbx_city.BackColor = Color.Red;
            }
            if (!validation.valid_street_number(street_number))
            {
                
                invalids++;
                msktbx_street_number.BackColor = Color.Red;
            }
            if(invalids != 0)
            {
                validation.incorrect_input();
            }
            else
            {


                try
                {
                    var hashed_password = SecurePasswordHasher.Hash(password);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = @"
                        INSERT INTO Uzytkownicy
                        (Login, HasloHash, Imie, Nazwisko, Miejscowosc, KodPocztowy, Ulica, NumerPosesji, NumerLokalu, PESEL, DataUrodzenia, Plec, Email, Telefon)
                        VALUES
                        (@login, @haslo, @imie, @nazwisko, @miasto, @kod, @ulica, @nrPos, @nrLok, @pesel, @dataUr, @plec, @email, @telefon)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@login", login);
                            cmd.Parameters.AddWithValue("@haslo", hashed_password);
                            cmd.Parameters.AddWithValue("@imie", name);
                            cmd.Parameters.AddWithValue("@nazwisko", surname);
                            cmd.Parameters.AddWithValue("@miasto", city);
                            cmd.Parameters.AddWithValue("@kod", "00-000"); 
                            cmd.Parameters.AddWithValue("@ulica", street ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@nrPos", street_number);
                            cmd.Parameters.AddWithValue("@nrLok", string.IsNullOrEmpty(locale_number) ? (object)DBNull.Value : locale_number);
                            cmd.Parameters.AddWithValue("@pesel", pesel);
                            cmd.Parameters.AddWithValue("@dataUr", birthdate);
                            cmd.Parameters.AddWithValue("@plec", gender);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@telefon", phone);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Dodano użytkownika do bazy");
                    WczytajUzytkownikowDoListy();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
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
            databaseConnection.display_table_users(dvg_user_list, query);
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
                    DataZapomnienia = GETDATE()
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

            if (!string.IsNullOrEmpty(match))
            {
                string name = null;
                string surname = null;
                long? pesel = null;

                if (long.TryParse(match, out long parsedPesel))
                {
                    pesel = parsedPesel;
                }
                else
                {
                    string[] parts = match.Split(' ');

                    if (parts.Length == 2)
                    {
                        name = parts[0];
                        surname = parts[1];
                    }
                    else if (parts.Length == 1)
                    {
                        name = parts[0];
                    }
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    UzytkownikID, 
                    Login, 
                    Imie + ' ' + Nazwisko AS [Imię i Nazwisko], 
                    Email, 
                    PESEL 
                FROM Uzytkownicy
                WHERE
                (@pesel IS NOT NULL AND PESEL = @pesel)
                OR
                (@pesel IS NULL AND
                    (
                        (@name IS NOT NULL AND @surname IS NULL 
                            AND (Imie LIKE @name OR Nazwisko LIKE @name))
                        
                        OR
                        
                        (@name IS NOT NULL AND @surname IS NOT NULL 
                            AND Imie LIKE @name AND Nazwisko LIKE @surname)
                    )
                )
                AND CzyZapomniany = 0
                ORDER BY Nazwisko";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pesel", (object)pesel ?? DBNull.Value);

                        cmd.Parameters.AddWithValue("@name",
                            name != null ? "%" + name + "%" : (object)DBNull.Value);

                        cmd.Parameters.AddWithValue("@surname",
                            surname != null ? "%" + surname + "%" : (object)DBNull.Value);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dvg_user_list.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Podaj informacje do wyszukania!");
            }
        }

        private void btn_show_forgotten_Click(object sender, EventArgs e)
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
                WHERE CzyZapomniany = 1
                ORDER BY Nazwisko";
            databaseConnection.display_table_users(dvg_user_list, query);
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
            msktbx_user_login.Text = "aaaaaaa";
            msktbx_user_name.Text = "aaaaaaa";
            msktbx_user_surname.Text = "aaaaaaa";
            cmbx_gender.Text = "kobieta";
            msktbx_pesel.Text = "00231900100";
            msktbx_email.Text = "aa@aaaa.a";
            msktbx_phone.Text = "222222222";
            dtpckr_birthdate.Value = new DateTime(2000, 3, 19);
            msktbx_city.Text = "aaaaaaa";
            msktbx_street.Text = "aaaaaaa";
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
            var controls = new List<Control> { msktbx_user_name_edit, msktbx_user_surname_edit, cmbx_gender_edit, msktbx_pesel_edit, msktbx_email_edit, msktbx_phone_edit, dtpckr_birthdate_edit, msktbx_city_edit, msktbx_street_edit, msktbx_street_number_edit, msktbx_locale_number_edit };
            foreach (var ctrl in controls) ctrl.Enabled = false;
            msktbx_user_login_edit.Enabled = false;
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

            var controls = new List<Control> { msktbx_user_name_edit, msktbx_user_surname_edit, cmbx_gender_edit, msktbx_pesel_edit, msktbx_email_edit, msktbx_phone_edit, dtpckr_birthdate_edit, msktbx_city_edit, msktbx_street_edit, msktbx_street_number_edit, msktbx_locale_number_edit };
            foreach (var ctrl in controls) ctrl.Enabled = true;

            MessageBox.Show("Pola zostały odblokowane. Możesz wprowadzić zmiany.");
        }

        private void btn_save_edit_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1) return;

            Validation validation = new Validation();
            int invalids = 0;

            var name = msktbx_user_name_edit.Text.Trim();
            var surname = msktbx_user_surname_edit.Text.Trim();
            var gender = cmbx_gender_edit.Text.Trim();
            var pesel = msktbx_pesel_edit.Text.Replace(" ", "").Trim();
            var email = msktbx_email_edit.Text.Trim();
            var phone = msktbx_phone_edit.Text.Replace(" ", "").Trim();
            var birthdate = dtpckr_birthdate_edit.Value.Date;
            var city = msktbx_city_edit.Text.Trim();
            var street = msktbx_street_edit.Text.Trim();
            var street_number = msktbx_street_number_edit.Text.Trim();
            var locale_number = msktbx_locale_number_edit.Text.Trim();

            bool hasChanges =
                name != origName ||
                surname != origSurname ||
                gender != origGender ||
                pesel != origPesel ||
                email != origEmail ||
                phone != origPhone ||
                birthdate != origBirthdate ||
                city != origCity ||
                street != origStreet ||
                street_number != origStreetNumber ||
                locale_number != origLocaleNumber;

            if (!hasChanges)
            {
                MessageBox.Show("Nie wprowadzono żadnych zmian.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ZablokujPolaEdycji();
                return; // Nie będzie wysyłane zapytanie do bazy
            }

            var textboxes = new List<Control> { msktbx_user_name_edit, msktbx_user_surname_edit, cmbx_gender_edit, msktbx_pesel_edit, msktbx_email_edit, msktbx_phone_edit, dtpckr_birthdate_edit, msktbx_city_edit, msktbx_street_number_edit };
            foreach (var textbox in textboxes) textbox.BackColor = Color.White;

            if (!validation.valid_name(name)) { invalids++; msktbx_user_name_edit.BackColor = Color.Red; }
            if (!validation.valid_surname(surname)) { invalids++; msktbx_user_surname_edit.BackColor = Color.Red; }
            if (!validation.valid_gender(gender, pesel)) { invalids++; cmbx_gender_edit.BackColor = Color.Red; }
            if (!validation.valid_birthdate(birthdate.Date, pesel)) { invalids++; dtpckr_birthdate_edit.BackColor = Color.Red; msktbx_pesel_edit.BackColor = Color.Red; }
            if (!validation.valid_pesel(pesel, birthdate.Date, gender)) { invalids++; msktbx_pesel_edit.BackColor = Color.Red; }
            if (!validation.valid_email(email)) { invalids++; msktbx_email_edit.BackColor = Color.Red; }
            if (!validation.valid_phone(phone)) { invalids++; msktbx_phone_edit.BackColor = Color.Red; }
            if (!validation.valid_city(city)) { invalids++; msktbx_city_edit.BackColor = Color.Red; }
            if (!validation.valid_street_number(street_number)) { invalids++; msktbx_street_number_edit.BackColor = Color.Red; }

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

                if (loginExists) { msktbx_user_login_edit.BackColor = Color.Red; msg += "- Login\n"; }
                if (peselExists) { msktbx_pesel_edit.BackColor = Color.Red; msg += "- Numer PESEL\n"; }
                if (emailExists) { msktbx_email_edit.BackColor = Color.Red; msg += "- Adres e-mail\n"; }

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
                        Ulica = @ulica, NumerPosesji = @nrPos, NumerLokalu = @nrLok, 
                        PESEL = @pesel, DataUrodzenia = @dataUr, Plec = @plec, 
                        Email = @email, Telefon = @telefon
                        WHERE UzytkownikID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@imie", name);
                        cmd.Parameters.AddWithValue("@nazwisko", surname);
                        cmd.Parameters.AddWithValue("@miasto", city);
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
            if(dotNetBarTabControl_manage_roles.SelectedTab.Name == "tabPage_roles_overview")
            {
                OdswiezListeUprawnien();
            }
        }
        private void OdswiezListeUprawnien()
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
                    // SqlDataAdapter automatycznie otwiera i zamyka połączenie
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Zakładamy, że Twoja kontrolka nazywa się dataGridView1
                    dgv_roles.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
