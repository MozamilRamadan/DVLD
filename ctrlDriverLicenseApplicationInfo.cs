using DVLD.People;
using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlApplicationDetails : UserControl
    {
        int _LDAID = -1, _LicenseID = -1;
        enum enAppStauts { New = 1, Cancled = 2, Complete = 3 };
        enAppStauts stauts;
        clsLocalDrivingLicenseApplications _application;
        public int LDAID
        {
            get { return _LDAID; }
        }
        public ctrlApplicationDetails()
        {
            InitializeComponent();
        }

        public void LoadInfoByApplicationID(int applicationID)
        {
            
            _application = clsLocalDrivingLicenseApplications.FindByApplicationID(applicationID);
            if (_application == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + LDAID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                _FillLDAByApplicationIDInfo();
            }

        }

        public void LoadApplicationInfoByLocalDrivingAppID(int LDLAID)
        {
            _application = clsLocalDrivingLicenseApplications.Find(LDLAID);
            if (_application == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + LDLAID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            lblID.Text = "[????]";
            lblClasses.Text = "[????]";
            lblTest.Text = "[????]";
            lblAppID.Text = "[????]";

            lblStatus.Text = "[????]";
            lblFees.Text = "[????]";
            lblType.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreateBy.Text = "[????]";
        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            _LicenseID = _application.GetActiveLicenseID();

            //incase there is license enable the show link.
            lblPersonInfo.Enabled = (_LicenseID != -1);


            //lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            //lblAppliedFor.Text = clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            //lblPassedTests.Text = _LocalDrivingLicenseApplication.GetPassedTestCount().ToString() + "/3";
            //ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);

        }

        private void _FillLDAByApplicationIDInfo()
        {
            lblID.Text = _application.LocalDrivingLicenseApplicationID.ToString();
            lblClasses.Text = clsLicenseClass.Find(_application.LicenseClassID).ClassName;
            lblTest.Text = _application.appTypeInfo.ToString();
            lblAppID.Text = _application.ApplicationID.ToString();

            lblStatus.Text = _application.StatusText;
            lblFees.Text = _application.PaidFees.ToString();
            lblType.Text = clsApplicationTypes.Find(Convert.ToInt32(_application.ApplicationTypeID)).ApplicationTypeTitle.ToString();
            lblApplicant.Text = clsPerson.Find(_application.ApplicantPersonID).FullName;
            lblDate.Text = _application.ApplicationDate.ToString();
            lblStatusDate.Text = _application.LastStatusDate.ToString();
            lblCreateBy.Text = clsUsers.Find(_application.CreatedByUserID).UserName;

        }
        private void lblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo person = new frmShowPersonInfo(LDAID);
            person.ShowDialog();
        }

    }
}
