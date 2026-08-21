using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlApplicationDetails : UserControl
    {
        int _LDAID = -1;
        enum enAppStauts { New = 1, Cancled = 2, Complete = 3 };
        enAppStauts stauts;
        clsLocalDrivingLicenseApplications _application;
        public ctrlApplicationDetails()
        {
            InitializeComponent();
        }
        public ctrlApplicationDetails(int id)
        {
            InitializeComponent();

            _LDAID = id;
            LoadInfo();
        }

        public void LoadInfo()
        {
            _application = clsLocalDrivingLicenseApplications.Find(_LDAID);
            if (_application != null)
            {
                lblID.Text = _application.LDLApplicationID.ToString();
                lblClasses.Text = clsLicenseClass.Find(_application.LicenseClassID).ClassName;
                lblTest.Text = _application.PassedTest(_LDAID).ToString();
                lblAppID.Text = _application.ApplicationID.ToString();

                lblStatus.Text = clsLocalDrivingLicenseApplications.GetStaus(_application.ApplicationStatus);
                lblFees.Text = _application.PaidFees.ToString();
                lblType.Text = clsApplicationTypes.Find(Convert.ToInt32(_application.ApplicationTypeID)).ApplicationTypeTitle.ToString();
                lblApplicant.Text = clsPerson.Find(_application.ApplicantPersonID).FullName;
                lblDate.Text = _application.ApplicationDate.ToString();
                lblStatusDate.Text = _application.LastStatusDate.ToString();
                lblCreateBy.Text = clsUsers.Find(_application.CreatedByUserID).UserName;
            }

        }

        private void lblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_application != null)
            {
                ctrlPersonCard1.Visible = true;
                ctrlPersonCard1.LoadPersonInfo(_application.ApplicantPersonID);
            }
        }
    }
}
