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

        private void manageApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frmType = new frmManageApplicationTypes();
            frmType.Show();
        }

        private void driverLincesServeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int personID = clsCurrentUser.USER.PersonID;

            frmPersonCard card = new frmPersonCard(personID);
            card.Show();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int personID = clsCurrentUser.USER.PersonID;
            frmChangePassword change = new frmChangePassword(personID);
            change.Show();
        }

        private void singOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            clsCurrentUser.LogeOut();
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void manageApplicationTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frmApp = new frmManageApplicationTypes();
            frmApp.Show();

        }

        private void manageTestTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTestTypes frmTestTypes = new frmTestTypes();
            frmTestTypes.Show();
        }

        private void peopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangePeople frm = new MangePeople();

            frm.ShowDialog();
        }
    }
}
