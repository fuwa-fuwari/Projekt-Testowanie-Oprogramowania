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
        public NewPasswordPrompt()
        {
            InitializeComponent();
        }

        private void btn_set_newpass_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
