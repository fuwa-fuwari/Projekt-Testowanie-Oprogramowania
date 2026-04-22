using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektMagazyn
{
    public class RecoveryMail
    {
        public class SmtpAuthData
        {
            public string SmtpHost { get; set; }
            public int SmtpPort { get; set; } = 2525;

            public string SmtpUser { get; set; }
            public string SmtpPass { get; set; }

            public string FromEmail { get; set; }
        }

        public static SmtpAuthData ReadAuthData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("SMTP config JSON not found.");
            }

            string json = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<SmtpAuthData>(json);

            if (data == null)
                throw new Exception("Failed to deserialize SMTP config.");

            return data;
        }
        public string GeneratePassword()
        {
            Random rnd = new Random();

            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string special = "-_!*#$&";

            var passwordChars = new List<char>();

            passwordChars.AddRange(Enumerable.Range(0, 3).Select(x => upper[rnd.Next(upper.Length)]));
            passwordChars.AddRange(Enumerable.Range(0, 3).Select(x => lower[rnd.Next(lower.Length)]));
            passwordChars.AddRange(Enumerable.Range(0, 2).Select(x => digits[rnd.Next(digits.Length)]));
            passwordChars.AddRange(Enumerable.Range(0, 2).Select(x => special[rnd.Next(special.Length)]));

            return new string(passwordChars.OrderBy(x => rnd.Next()).ToArray());
        }
        public async Task SendResetPassword(string toEmail, string newPassword, string filename)
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
                var auth = ReadAuthData(path);

                using (var client = new SmtpClient(auth.SmtpHost, auth.SmtpPort))
                {
                    client.Credentials = new NetworkCredential(
                        auth.SmtpUser,
                        auth.SmtpPass
                    );

                    client.EnableSsl = true;

                    string body =
                        $"Twoje nowe hasło: {newPassword}\n\n" +
                        $"Jeśli to nie Ty, zignoruj tę wiadomość.";

                    var mail = new MailMessage
                    {
                        From = new MailAddress(auth.FromEmail),
                        Subject = "Reset hasła",
                        Body = body,
                        IsBodyHtml = false
                    };

                    mail.To.Add(toEmail);

                    await client.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd wysyłki maila: " + ex);
                throw;
            }
        }
    }
}
