using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace election
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnAuthLogIn_Click(object sender, EventArgs e)
        {
            String dbName = "electiondb";

            String login = txtBoxAuthLogin.Text.Trim();
            String password = txtBoxAuthPassword.Text.Trim();

          
        }
    }
}
