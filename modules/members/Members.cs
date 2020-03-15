using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace election.modules.members
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.ShowDialog();
        }
    }
}
