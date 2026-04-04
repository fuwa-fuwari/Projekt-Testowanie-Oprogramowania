using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektMagazyn
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void btn_zaloguj_Click(object sender, EventArgs e)
        {
            //TODO: integrate into database
            string hash = "$MYHASH$V1$10000$II1qT0FbjfgzCRkK4fmstreqgqpwhy+Zv8p2Xv/SVHalAktO";

            if (tbx_login.Text == "admin1" && SecurePasswordHasher.Verify(tbx_password.Text, hash))
            {
                Administrator administrator = new Administrator();
                administrator.Location = this.Location;
                administrator.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                clear_field(tbx_login);
                clear_field(tbx_password);
                tbx_login.Focus();
                this.Hide();
                administrator.Show();
            }
            else if (tbx_login.Text != "admin1" && SecurePasswordHasher.Verify(tbx_password.Text, hash))
            {
                MessageBox.Show("Podano niepoprawny login");
                clear_field(tbx_login);
                tbx_login.Focus();
            }
            else if (tbx_login.Text == "admin1" && !SecurePasswordHasher.Verify(tbx_password.Text, hash))
            {
                MessageBox.Show("Podano niepoprawne hasło");
                clear_field(tbx_password);
                tbx_password.Focus();
            }
            else
            {
                MessageBox.Show("Podano niepoprawny login lub hasło");
                clear_field(tbx_login);
                clear_field(tbx_password);
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
    }
}
