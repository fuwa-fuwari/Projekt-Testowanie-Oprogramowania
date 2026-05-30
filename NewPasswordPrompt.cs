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
            databaseConnection.AfterRecoveredPasswordChanged(userId);

            this.Close();
        }
    }
}
