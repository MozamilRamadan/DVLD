using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLocalDrinvingApplicationInfo : Form
    {
        int _LDAID = -1;
        enum enAppStauts {New =1,Cancled=2,Complete =3};
        enAppStauts stauts;
        clsLocalDrivingLicenseApplications _applocation;
        public frmLocalDrinvingApplicationInfo(int ID)
        {
            InitializeComponent();
            _LDAID = ID;
            FillInfo();
        }

        void FillInfo()
        {
            _applocation = clsLocalDrivingLicenseApplications.Find(_LDAID);
            if (_applocation != null)
            {
                lblID.Text = _applocation.LDLApplicationID.ToString();
                lblClasses.Text = clsLicenseClass.Find(_applocation.LicenseClassID).ClassName;
                lblTest.Text = _applocation.PassedTest(_LDAID).ToString();
                lblAppID.Text = _applocation.ApplicationID.ToString();

                lblStatus.Text = clsLocalDrivingLicenseApplications.GetStaus(_applocation.ApplicationStatus);
                lblFees.Text = _applocation.PaidFees.ToString();
                lblType.Text = clsApplicationTypes.Find(Convert.ToInt32(_applocation.ApplicationTypeID)).ApplicationTypeTitle.ToString();
                lblApplicant.Text = clsPerson.Find(_applocation.ApplicantPersonID).FullName;
                lblDate.Text = _applocation.ApplicationDate.ToString();
                lblStatusDate.Text = _applocation.LastStatusDate.ToString();
                lblCreateBy.Text = clsUsers.Find(_applocation.CreatedByUserID).UserName;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
