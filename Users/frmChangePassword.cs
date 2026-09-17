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
    public partial class frmChangePassword : Form
    {
        clsUsers _User;
        public frmChangePassword(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            _User = clsUsers.FindByPersonID(PersonID);
            LoadUserData();
        }
        private void LoadUserData()
        {
            if(_User != null)
            {
                
                lblUserID.Text = _User.UserID.ToString();
                lblUserName.Text = _User.UserName.ToString();
                if (_User.IsActive)
                    lblIsActive.Text = "Yes";
                else 
                    lblIsActive.Text = "No";

            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_User != null)
            {
                if (txtCurrentPassword.Text == _User.Password)
                {
                    if (txtNewPassword.Text != null && txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        _User.Password = txtNewPassword.Text;
                        _User.Save();
                        MessageBox.Show("Password Changed Successfuly. ", "Success",MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        MessageBox.Show("Faild To Change Password, Somthinge Wrong", "Faild", MessageBoxButtons.OKCancel);

                    }
                }
            }
        }
    }
}
