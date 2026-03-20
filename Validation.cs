using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjektMagazyn
{
    public class Validation
    {
        public void incorrect_input()
        {
            MessageBox.Show("Wprowadzono nieprawidłowe dane!");
        }
        public bool valid_login(string login)
        {
            //must be unique in database
            if (login == null || login == string.Empty) 
            { 
                return false;
            }
            return true;
        }
        public bool valid_name(string name)
        {
            if (!Regex.IsMatch(name, @"^[A-Za-z]+$"))
            {
                return false;
            }
            return true;
        }
        public bool valid_surname(string surname)
        {
            if (!Regex.IsMatch(surname, @"^[A-Za-z]+$"))
            {
                return false;
            }
            return true;
        }
        public bool valid_birthdate(DateTime birthdate, string pesel)
        {
            if (birthdate.Date > DateTime.Now.Date)
                return false;

            if (!string.IsNullOrEmpty(pesel) && pesel.Length == 11)
            {
                int year = int.Parse(pesel.Substring(0, 2));
                int month = int.Parse(pesel.Substring(2, 2));
                int day = int.Parse(pesel.Substring(4, 2));

                int century;
                if (month >= 1 && month <= 12) century = 1900;
                else if (month >= 21 && month <= 32) { century = 2000; month -= 20; }
                else if (month >= 41 && month <= 52) { century = 2100; month -= 40; }
                else if (month >= 61 && month <= 72) { century = 2200; month -= 60; }
                else if (month >= 81 && month <= 92) { century = 1800; month -= 80; }
                else return false;

                int fullYear = century + year;

                if (birthdate.Year != fullYear || birthdate.Month != month || birthdate.Day != day)
                    return false;
            }

            return true;
        }
        public bool valid_city(string city)
        {
            if (!Regex.IsMatch(city, @"^[A-Za-z]+$"))
            {
                return false;
            }
            return true;
        }
        public bool valid_street(string street)
        {
            if (!Regex.IsMatch(street, @"^[A-Za-z]+$"))
            {
                return false;
            }
            return true;
        }
        public bool valid_street_number(string street_number)
        {
            if (!Regex.IsMatch(street_number, @"^[0-9]+$"))
            {
                return false;
            }
            return true;
        }
        public bool valid_locale_number(string locale_number)
        {
            if (!Regex.IsMatch(locale_number, @"^[0-9]+$"))
            {
                return false;
            }
            return true;
        }
        public bool valid_gender(string gender, string pesel)
        {
            if (!(gender == "kobieta" || gender == "mężczyzna"))
                return false;
            
            if(pesel != string.Empty)
            {
                int genderDigit = int.Parse(pesel[9].ToString());
            bool isMale = genderDigit % 2 == 1;

            if ((gender == "mężczyzna" && !isMale) || (gender == "kobieta" && isMale))
                return false;
            }

            return true;
        }
        public bool valid_pesel(string pesel, DateTime birthdate, string gender)
        {
            // 1. Sprawdzenie długości i cyfr
            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
                return false;

            // 2. Odczyt daty z PESEL
            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));

            // Korekta miesiąca (PESEL koduje wiek)
            int century = 1900;

            if (month >= 1 && month <= 12)
                century = 1900;
            else if (month >= 21 && month <= 32)
            {
                century = 2000;
                month -= 20;
            }
            else if (month >= 41 && month <= 52)
            {
                century = 2100;
                month -= 40;
            }
            else if (month >= 61 && month <= 72)
            {
                century = 2200;
                month -= 60;
            }
            else if (month >= 81 && month <= 92)
            {
                century = 1800;
                month -= 80;
            }
            else
                return false;

            int fullYear = century + year;

            // 3. Sprawdzenie daty
            DateTime peselDate;
            if (!DateTime.TryParse($"{fullYear}-{month}-{day}", out peselDate))
                return false;

            if (peselDate.Date != birthdate.Date)
                return false;

            // 4. Sprawdzenie płci
            int genderDigit = int.Parse(pesel[9].ToString());
            bool isMale = genderDigit % 2 == 1;

            if ((gender == "mężczyzna" && !isMale) || (gender == "kobieta" && isMale))
                return false;

            // 5. Suma kontrolna
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * int.Parse(pesel[i].ToString());
            }

            int controlDigit = (10 - (sum % 10)) % 10;

            if (controlDigit != int.Parse(pesel[10].ToString()))
                return false;

            return true;
        }
        public bool valid_email(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return false;

            return true;
        }
        public bool valid_phone(string phone)
        {
            if (!Regex.IsMatch(phone, @"^[0-9]{9}$"))
            {
                return false;
            }
            return true;
        }
    }
}
