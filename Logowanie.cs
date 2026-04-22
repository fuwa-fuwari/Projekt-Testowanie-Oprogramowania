using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektMagazyn
{
    public partial class Logowanie : Form
    {
        string secretsauceFilename = "secretsauce.json";
        public Logowanie()
        {
            InitializeComponent();
        }

        private void btn_zaloguj_Click(object sender, EventArgs e)
        {
            string login = tbx_login.Text.Trim();
            string password = tbx_password.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Podaj login i hasło");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT HasloHash FROM Uzytkownicy WHERE Login = @login AND CzyZapomniany = 0";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);

                        var result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Niepoprawny login");
                            return;
                        }

                        string hash = result.ToString();

                        if (SecurePasswordHasher.Verify(password, hash))
                        {
                            ControlPanel controlPanel = new ControlPanel();
                            controlPanel.Location = this.Location;
                            controlPanel.FormClosed += otherForm_FormClosed;

                            clear_field(tbx_login);
                            clear_field(tbx_password);

                            this.Hide();
                            controlPanel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawne hasło");
                            clear_field(tbx_password);
                            tbx_password.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd logowania: " + ex.Message);
            }
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void clear_field(TextBox textBox)
        {
            textBox.Text = null;
        }

        private async void btn_reset_password_Click(object sender, EventArgs e)
        {
            string login = tbx_login.Text.Trim();

            if (string.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Podaj login do odzyskania hasła");
                tbx_login.Focus();
                return;
            }

            try
            {
                RecoveryMail recoveryMail = new RecoveryMail();
                string newPassword = recoveryMail.GeneratePassword();
                string hash = SecurePasswordHasher.Hash(newPassword);

                using (SqlConnection conn = new SqlConnection(
                    @"Data Source=.\SQLEXPRESS;Initial Catalog=MagazynDB;Integrated Security=True"))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Uzytkownicy WHERE Login = @login AND CzyZapomniany = 0";

                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);

                        int exists = (int)cmd.ExecuteScalar();

                        if (exists == 0)
                        {
                            MessageBox.Show("Nie znaleziono użytkownika");
                            return;
                        }
                    }

                    string updateQuery = "UPDATE Uzytkownicy SET HasloHash = @hash WHERE Login = @login";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.ExecuteNonQuery();
                    }
                }

                await recoveryMail.SendResetPassword("sandbox.smtp@mailtrap.io", newPassword, secretsauceFilename);

                MessageBox.Show("Nowe hasło zostało wygenerowane i wysłane (Mailtrap).");
                //MessageBox.Show($"Nowe hasło zostało wygenerowane: {newPassword}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd resetu hasła: " + ex.Message);
            }
        }
    }
}
