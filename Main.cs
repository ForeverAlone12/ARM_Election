using election.modules.election;
using election.modules.members;
using election.modules.observes;
using election.modules.partys;
using election.modules.uik;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
    

        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(childForm);
            splitContainer1.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            OpenChildForm(members, e);
        }

        private void buttonUIK_Click(object sender, EventArgs e)
        {
            Uik uik = new Uik();
            OpenChildForm(uik, e);
        }

        private void buttonElection_Click(object sender, EventArgs e)
        {
            Election election = new Election();
            OpenChildForm(election, e);
        }

        private void buttonObservers_Click(object sender, EventArgs e)
        {
            Observers observers = new Observers();
            OpenChildForm(observers, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Partys partys = new Partys();
            OpenChildForm(partys, e);
        }
    } 
}