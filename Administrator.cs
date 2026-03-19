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
                MessageBox.Show("Dodano uzytkownika");

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
    }
}
