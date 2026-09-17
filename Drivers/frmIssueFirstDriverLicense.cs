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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmIssueFirstDriverLicense : Form
    {
        clsLocalDrivingLicenseApplications _applocation;
        clsDriver _driver;
        clsLicense _license;
        int _LDLAppID = -1;
        public frmIssueFirstDriverLicense(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            //ctrlApplicationDetails1.LoadInfo(LDLAppID);
            _applocation = clsLocalDrivingLicenseApplications.Find(_LDLAppID);

        }
        void _AddLicense()
        {
            _applocation = clsLocalDrivingLicenseApplications.Find(_LDLAppID);
            _license = new clsLicense();
                _license.ApplicationID = _applocation.LocalDrivingLicenseApplicationID;
                _license.LicenseClassID = _applocation.LicenseClassID;
                _license.Notes = txtNote.Text;
                _license.PaidFees = 50;
                _license.IsActive = true;
                //_license.IssueReason = 1;
                _license.CreatedByUserID = clsCurrentUser._USER.UserID;
            
        }
        void _AddDriver()
        {
              _driver.PersonID = _applocation.LocalDrivingLicenseApplicationID;
              _driver.CreatedByUserID = clsCurrentUser._USER.UserID;
              _driver.CreatedDate = DateTime.Now;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _applocation = clsLocalDrivingLicenseApplications.Find(_LDLAppID);
            if (_applocation != null)
            {
                 _AddLicense();
                    if (_license.FirstSave())
                    {
                        string Id = _license.LicenseID.ToString();
                        string Message = "Issue Susseccfuly With License ID " + Id;
                        MessageBox.Show(Message,"Issue", MessageBoxButtons.OKCancel);
                    }
                    else
                    { MessageBox.Show("Faild To Issue", "Issue", MessageBoxButtons.OKCancel); }

                }
                else
                {
                    _AddDriver();
                    _AddLicense();
                    if (_license.Save() && _driver.Save())
                    {
                        string Id = _license.LicenseID.ToString();
                        string Message = "Issue Susseccfuly With License ID " + Id;
                        MessageBox.Show("Issue", Message, MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        MessageBox.Show("Issue", "Faild To Issue", MessageBoxButtons.OKCancel);
                    }

                }
            
        }
    }
}
