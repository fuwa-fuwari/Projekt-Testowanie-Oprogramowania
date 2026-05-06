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
        Dictionary<string, LoginAttemptInfo> loginAttempts = new Dictionary<string, LoginAttemptInfo>();
        Timer lockoutTimer = new Timer();
        public Logowanie()
        {
            InitializeComponent();

            lockoutTimer.Interval = 1000;
            lockoutTimer.Tick += LockoutTimer_Tick;
        }
        class LoginAttemptInfo
        {
            public int FailedAttempts { get; set; }
            public DateTime? LockoutEnd { get; set; }
        }
        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            string login = tbx_login.Text;

            if (!loginAttempts.ContainsKey(login))
                return;

            var info = loginAttempts[login];

            if (info.LockoutEnd == null)
                return;

            var remaining = info.LockoutEnd.Value - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                info.LockoutEnd = null;
                info.FailedAttempts = 0;
                lbl_timeout_status.Text = "Możesz spróbować ponownie.";
            }
            else
            {
                lbl_timeout_status.Text = $"Blokada dla '{login}' ({(int)remaining.TotalSeconds}s)";
            }
        }

        private void btn_zaloguj_Click(object sender, EventArgs e)
        {
            string login = tbx_login.Text;
            string password = tbx_password.Text;

            if (!loginAttempts.ContainsKey(login))
                loginAttempts[login] = new LoginAttemptInfo();

            var info = loginAttempts[login];

            DatabaseConnection database = new DatabaseConnection();

            if (info.LockoutEnd != null && info.LockoutEnd > DateTime.Now)
            {
                MessageBox.Show($"Login '{login}' jest chwilowo zablokowany.");
                return;
            }

            database.VerifyLogin(login, password, out int? userId, out string hash);

            if (userId == null || hash == null || !SecurePasswordHasher.Verify(password, hash))
            {
                info.FailedAttempts++;

                if (info.FailedAttempts >= 3)
                {
                    info.LockoutEnd = DateTime.Now.AddSeconds(60);
                    info.FailedAttempts = 0;

                    lockoutTimer.Start();
                    lbl_timeout_status.Text = $"Login '{login}' zablokowany na 60s";
                }
                else
                {
                    lbl_timeout_status.Text = $"Błędne dane ({info.FailedAttempts}/3)";
                }

                return;
            }

            info.FailedAttempts = 0;
            info.LockoutEnd = null;
            lbl_timeout_status.Text = null;

            ControlPanel controlPanel = new ControlPanel(userId.Value);
            controlPanel.Location = this.Location;
            controlPanel.FormClosed += otherForm_FormClosed;

            clear_field(tbx_login);
            clear_field(tbx_password);

            this.Hide();
            controlPanel.Show();
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

                DatabaseConnection database = new DatabaseConnection();
                bool success = database.ResetUserPassword(login, hash);

                if (!success)
                {
                    MessageBox.Show("Nie znaleziono użytkownika");
                    return;
                }

                await recoveryMail.SendResetPassword(
                    "sandbox.smtp@mailtrap.io",
                    newPassword,
                    secretsauceFilename
                );

                MessageBox.Show("Nowe hasło zostało wygenerowane i wysłane (Mailtrap).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd resetu hasła: " + ex.Message);
            }
        }
    }
}
