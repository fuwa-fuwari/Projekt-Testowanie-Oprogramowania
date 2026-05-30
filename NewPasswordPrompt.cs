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
    public partial class NewPasswordPrompt : Form
    {
        private int userId;
        public NewPasswordPrompt(int loggedUserId)
        {
            InitializeComponent();
            userId = loggedUserId;
        }
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void btn_set_newpass_Click(object sender, EventArgs e)
        {
            string newPass = tbx_newpass.Text;
            string repeat = tbx_repeat_newpass.Text;

            Validation validation = new Validation();

            if (string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(repeat))
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

            using (SqlConnection conn = new SqlConnection(databaseConnection.GetConnectionString))
            {
                conn.Open();

                string newHash = SecurePasswordHasher.Hash(newPass);
                string updateQuery = "UPDATE Uzytkownicy SET HasloHash = @pass WHERE UzytkownikID = @id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@pass", newHash);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Hasło zostało zmienione.");

            tbx_newpass.Clear();
            tbx_repeat_newpass.Clear();
            databaseConnection.AfterRecoveredPasswordChanged(userId);

            this.Close();
        }
    }
}
