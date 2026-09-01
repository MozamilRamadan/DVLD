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
    public partial class frmTakeTest : Form
    {
        clsTest _test;
        clsTestAppointment _testApp;
        int _appID = -1, _TestTypeID = -1;
        bool IsUpdateMode = false;
        public frmTakeTest(int id, int testType)
        {
            InitializeComponent();
            _appID = id;
            _TestTypeID = testType;
            FillData();
            _LoadPictureAndTitle();
        }

        void FillData()
        {
            _testApp = clsTestAppointment.Find(_appID);
            clsLocalDrivingLicenseApplications _app = clsLocalDrivingLicenseApplications.Find(_testApp.LocalDrivingLicenseApplicationID);
            if (_testApp == null )
                return;
            lblAppID.Text = _testApp.LocalDrivingLicenseApplicationID.ToString();
            lblClassID.Text = clsLicenseClass.Find(_app.LicenseClassID).ClassName;
            lblName.Text = clsPerson.Find(_app.ApplicantPersonID).FullName;
            lblTrial.Text = "0";
            DTPicker.Value = _testApp.AppointmentDate;
            lblFees.Text = _testApp.PaidFees.ToString();
            lblTestID.Text ="Not Taken Yet";

        }
        void LoadData()
        {
            _test = new clsTest();
            _test.TestAppointmentID = _testApp.TestAppointmentID;
            if (rdPass.Checked) 
                _test.TestResult = true;
            else
                _test.TestResult = false;
            _test.Notes = txtNote.Text;
            _test.CreatedByUserID = clsCurrentUser._USER.UserID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Message = "Added Successfuly", Title = "Add New";
            LoadData();
            if (_test.Save())
            {
                _testApp.IsLocked = true;
                _testApp.Save();
                if (IsUpdateMode)
                {
                    Message = "Update Successfuly";
                    Title = "Update";

                    MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Faild To Add", "Error", MessageBoxButtons.OKCancel);
            }
        }


        private void _LoadPictureAndTitle()
        {
            switch (_TestTypeID)
            {
                case 1:
                    {
                        groupBox1.Text = "Vision Test";
                        pbType.Image = Properties.Resources.Vision_512;
                    }
                    break;
                case 2:
                    {
                        groupBox1.Text = "Written Test";
                        pbType.Image = Properties.Resources.Written_Test_512;
                    }
                    break;
                case 3:
                    {
                        groupBox1.Text = "Street Test";
                        pbType.Image = Properties.Resources.driving_test_512;
                    }
                    break;
            }
        }

    }
}
