using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void tslPeople_Click(object sender, EventArgs e)
        {
            MangePeople frm = new MangePeople();

            frm.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmMangeUsers users = new frmMangeUsers();
            users.Show();
        }


        private void singOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
