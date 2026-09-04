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
    public partial class ctrlLicenseInfo : UserControl
    {
        int _LDAID = -1;
        enum enIssueReason
        {
            FirstTime = 1,
            Renewal = 2,
            ReplacementForDamaged = 3
        }
        enIssueReason reason;
        clsLocalDrivingLicenseApplications _application;
        clsLicense _license;

        public ctrlLicenseInfo(int ID)
        {
            InitializeComponent();
            _LDAID = ID;
            LoadInfo();
        }
        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }
        public void LoadInfo()
        {
            _application = clsLocalDrivingLicenseApplications.Find(_LDAID);
            _license = clsLicense.FindByLDLAppID(_LDAID);
            if (_application != null && _license != null)
            {
                clsPerson person = clsPerson.Find(_application.ApplicantPersonID);
                lblClass.Text = clsLicenseClass.Find(_application.LicenseClassID).ClassName;
                lblName.Text = person.FullName;
                lblLicenseID.Text = _license.LicenseID.ToString();
                lblNationalNo.Text  = person.NationalNo.ToString();
                if (person.Gendor==0)
                    lblGendor.Text = "Male";
                else lblGendor.Text = "Female";
                lblIssueDate.Text = _license.IssueDate.ToString();
                lblIssueReason.Text = lblIssueReason.Text = ((enIssueReason)reason).ToString();
                lblNote.Text = _license.Notes.ToString();
                if (_license.IsActive)
                    lblIsActive.Text = "Yes";
                else lblIsActive.Text = "No";
                lblDateOfBirth.Text = person.DateOfBirth.ToString();
                lblDriverID.Text = _license.DriverID.ToString();
                lblExpirationDate.Text = _license.ExpirationDate.ToString();
                if(person.ImagePath!=null)
                    pictureBox1.Load(person.ImagePath);
            }

        }

    }
}
