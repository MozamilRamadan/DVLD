using DVLD.Global_Glasses;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.MaximumSize = new Size(1100, 600);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chRemmberMe.Checked = true;
            }
            else
                chRemmberMe.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _Password = txtPassword.Text.Trim();
            string _UserName = txtUserName.Text.Trim();
            clsUsers _User = clsUsers.FindByUserNameAndPassword(_UserName,_Password);
            if (_User != null)
            {
                if (chRemmberMe.Checked)
                    clsGlobal.RemmberUsernameAndPassword(_UserName, _Password);
                else
                    clsGlobal.RemmberUsernameAndPassword("", "");

                if (!_User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsGlobal.CurrentUser = _User;
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();
            }
            else
            {

                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
