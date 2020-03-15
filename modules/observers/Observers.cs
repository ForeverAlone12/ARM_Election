using election.modules.observers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace election.modules.observes
{
    public partial class Observers : Form
    {
        public Observers()
        {
            InitializeComponent();
        }

        private void btnAddObserver_Click(object sender, EventArgs e)
        {
            Observer observer = new Observer();
            observer.ShowDialog();
        }
    }
}
