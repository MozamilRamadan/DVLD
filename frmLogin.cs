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
        clsUsers _User, _User2;
        string _Password = "";
        string _UserName = "";
        string _Path = Application.StartupPath + @"\Login.txt";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(_Path))
            {
                string[] Parts = File.ReadAllLines(_Path).Single().Split('|');
                if (Parts.Length == 2)
                {
                    txtUserName.Text = Parts[0];
                    txtPassword.Text = Parts[1];
                    chRemmberMe.Checked = true;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Password = txtPassword.Text;
            _UserName = txtUserName.Text.Trim();
            _User = clsUsers.FindByUserNameAndPassword(_UserName,_Password);
            if (_User != null && _User.IsActive)
            {
                clsCurrentUser.USER = _User;

                if (chRemmberMe.Checked)  
                    SaveCredentials();
                else
                    clearCredentials();

                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Invaild User Name Or Password.","Loggin Faild",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void SaveCredentials()
        {
            File.WriteAllText(_Path, _UserName + '|' + _Password);
        }
        private void clearCredentials()
        {
            if(File.Exists(_Path)) 
                File.Delete(_Path);
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(_UserName))
            //{
            //    e.Cancel = true;
            //    //txtUserName.Focus();
            //    errorProvider1.SetError(txtUserName, "User Name Is Requierd?");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtUserName, "");
            //}
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(_Password))
            //{
            //    e.Cancel = true;
            //    //txtPassword.Focus();
            //    errorProvider1.SetError(txtPassword, "Password Is Requierd?");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtPassword, "");
            //}
        }

    }
}
