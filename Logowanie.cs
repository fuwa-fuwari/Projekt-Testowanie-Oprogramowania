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
            if(tbx_login.Text == "admin" && tbx_password.Text == "admin")
            {
                Zalogowany zalogowany = new Zalogowany();
                zalogowany.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                this.Hide();
                zalogowany.Show();
            }
            else if(tbx_login.Text == "admin" && tbx_password.Text != "admin")
            {
                MessageBox.Show("Podano niepoprawne hasło");
                tbx_password.Text = "";
                tbx_password.Focus();
            }
            else if (tbx_login.Text != "admin" && tbx_password.Text == "admin")
            {
                MessageBox.Show("Podano niepoprawny login");
                tbx_login.Text = "";
                tbx_login.Focus();
            }
            else
            {
                MessageBox.Show("Podano niepoprawny login lub hasło");
                tbx_login.Text = "";
                tbx_password.Text = "";
            }
            
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
