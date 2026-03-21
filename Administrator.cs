using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjektMagazyn
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();

        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            var login = msktbx_user_login.Text;
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

                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True";

                try
                {
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
                            // TODO: hashing
                            string hasloHash = "test123";

                            cmd.Parameters.AddWithValue("@login", login);
                            cmd.Parameters.AddWithValue("@haslo", hasloHash);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }

                //remove storing to csv when database ready
                //String file = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + Path.DirectorySeparatorChar + "users.csv";
                //String separator = ",";
                //StringBuilder output = new StringBuilder();
                //String[] headings = { 
                //                "login",
                //                "name",
                //                "surname",
                //                "birthdate",
                //                "city",
                //                "street",
                //                "street_number",
                //                "locale_number",
                //                "pesel",
                //                "email",
                //                "phone" };
                //output.AppendLine(string.Join(separator, headings));
                //String[] newLine = {
                //            login,
                //            name,
                //            surname,
                //            birthdate,
                //            city,
                //            street,
                //            street_number,
                //            locale_number,
                //            pesel,
                //            email,
                //            phone };
                //output.AppendLine(string.Join(separator, newLine));
                //File.AppendAllText(file, output.ToString());
                //MessageBox.Show("dodano użytkownika do pliku : " + file);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dotNetBarTabControl_main_view.SelectedTab = tabPage_overview;
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

        private void tabPage_overview_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True";
            try
            {
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
                WHERE CzyZapomniany = 0
                ORDER BY Nazwisko";

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

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True";

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
                            Login = 'usuniety_' + CAST(UzytkownikID AS VARCHAR),
                            Email = 'usuniety_' + CAST(UzytkownikID AS VARCHAR) + '@zanonimizowano.pl',
                            PESEL = '00000000000', 
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
    }
}
