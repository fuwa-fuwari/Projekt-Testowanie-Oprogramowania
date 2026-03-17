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
    public partial class Zalogowany : Form
    {
        public Zalogowany()
        {
            InitializeComponent();
        }

        private void btn_return_login_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
