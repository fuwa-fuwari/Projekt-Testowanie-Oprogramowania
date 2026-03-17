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

namespace ProjektMagazyn
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formularzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            var login = tbx_user_login.Text;
            var name = tbx_user_name.Text;
            var surname = tbx_user_surname.Text;
            var birthdate = dtpckr_birthdate.Text.Replace(",", "");
            var city = tbx_city.Text;
            var street = tbx_street.Text;
            var street_number = tbx_street_number.Text;
            var locale_number = tbx_locale_number.Text;
            var pesel = tbx_pesel.Text;
            var email = tbx_email.Text;
            var phone = tbx_phone.Text;

            String file = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + Path.DirectorySeparatorChar + "users.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
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
            String[] newLine = {
                            login,
                            name,
                            surname,
                            birthdate,
                            city,
                            street,
                            street_number,
                            locale_number,
                            pesel,
                            email,
                            phone };
            output.AppendLine(string.Join(separator, newLine));
            File.AppendAllText(file, output.ToString());
            MessageBox.Show("dodano użytkownika do pliku : " + file);
        }
    }
}
