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

        private void wyszukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetEntryAssembly().Location)
                + System.IO.Path.DirectorySeparatorChar + "users.csv";

            if (!System.IO.File.Exists(file))
            {
                MessageBox.Show("Brak pliku z użytkownikami.");
                return;
            }

            string fraza = Microsoft.VisualBasic.Interaction.InputBox(
                "Wpisz login, imię lub nazwisko:", "Wyszukaj użytkownika", "");

            if (string.IsNullOrWhiteSpace(fraza))
                return;

            var wyniki = new System.Text.StringBuilder();
            foreach (string linia in System.IO.File.ReadAllLines(file))
            {
                if (linia.ToLower().Contains(fraza.ToLower()))
                {
                    string[] pola = linia.Split(',');
                    if (pola.Length >= 9)
                        wyniki.AppendLine($"Login: {pola[0]} | Imię: {pola[1]} | Nazwisko: {pola[2]} | PESEL: {pola[8]}");
                }
            }

            if (wyniki.Length == 0)
                MessageBox.Show("Nie znaleziono użytkowników.");
            else
                MessageBox.Show(wyniki.ToString(), "Wyniki wyszukiwania");
        }

        private void edytujUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetEntryAssembly().Location)
                + System.IO.Path.DirectorySeparatorChar + "users.csv";

            if (!System.IO.File.Exists(file))
            {
                MessageBox.Show("Brak pliku z użytkownikami.");
                return;
            }

            string login = Microsoft.VisualBasic.Interaction.InputBox(
                "Wpisz login użytkownika do edycji:", "Edytuj użytkownika", "");

            if (string.IsNullOrWhiteSpace(login))
                return;

            string[] linie = System.IO.File.ReadAllLines(file);
            int indeks = -1;

            for (int i = 0; i < linie.Length; i++)
            {
                if (linie[i].Split(',')[0].ToLower() == login.ToLower())
                {
                    indeks = i;
                    break;
                }
            }

            if (indeks == -1)
            {
                MessageBox.Show("Nie znaleziono użytkownika o podanym loginie.");
                return;
            }

            string[] pola = linie[indeks].Split(',');
            string noweImie = Microsoft.VisualBasic.Interaction.InputBox(
                "Imię:", "Edytuj użytkownika", pola[1]);
            string noweNazwisko = Microsoft.VisualBasic.Interaction.InputBox(
                "Nazwisko:", "Edytuj użytkownika", pola[2]);
            string nowyEmail = Microsoft.VisualBasic.Interaction.InputBox(
                "E-mail:", "Edytuj użytkownika", pola[9]);

            pola[1] = noweImie;
            pola[2] = noweNazwisko;
            pola[9] = nowyEmail;

            linie[indeks] = string.Join(",", pola);
            System.IO.File.WriteAllLines(file, linie);
            MessageBox.Show("Dane użytkownika zostały zaktualizowane.");
        }
    }
}
