using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLD
{
    public partial class frmSchedualTest : Form
    {
        int _LDAppID = -1, _AppintmentID = -1;
        bool _IsUpdateMode = false;
        decimal _Fees = 10;
        int _TestTypeID = -1;
        clsTestAppointment _tp;
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler dataBack;
        public frmSchedualTest(int id, int testTypeID, int appID = -1)
        {
            InitializeComponent();
            _LDAppID = id;
            _AppintmentID = appID;
            _TestTypeID = testTypeID;

            if (appID != -1)
            {
                _tp = clsTestAppointment.Find(appID);
                if (_tp != null)
                {
                    FillData();
                }

                btnSave.Text = "Update";
                _IsUpdateMode = true;
            }
            else
            {

                _tp = new clsTestAppointment();
                LoadData();
                btnSave.Text = "Save";
                _IsUpdateMode = false;
            }
            _LoadPictureAndTitle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string Message = "Added Apointments Successfuly", Title = "Add New";

            LoadData();
            if (_tp.Save())
            {
                if (_IsUpdateMode)
                {
                    Message = "Update Apointments Successfuly";
                    Title = "Update";

                    MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel);
                }

                MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel);
            }
            else

                MessageBox.Show("Faild To Add Appointment", "Faild", MessageBoxButtons.OKCancel);

            dataBack?.Invoke(this);
        }
        void LoadData()
        {
            _tp.LocalDrivingLicenseApplicationID = _LDAppID;
            _tp.CreatedByUserID = clsCurrentUser._USER.UserID;
            _tp.PaidFees = _Fees;
            _tp.AppointmentDate = DTPicker.Value;
            _tp.TestTypeID = Convert.ToByte(_TestTypeID);
            _tp.IsLocked = false;
        }

        void FillData()
        {
            clsLocalDrivingLicenseApplications _app = clsLocalDrivingLicenseApplications.Find(_LDAppID);
            lblAppID.Text = _LDAppID.ToString();
            lblClassID.Text = clsLocalDrivingLicenseApplications.Find(_LDAppID).LicenseClassID.ToString();
            lblName.Text = clsPerson.Find(_app.ApplicantPersonID).FullName;
            lblFees.Text = _tp.PaidFees.ToString();
            DTPicker.Value = _tp.AppointmentDate;
        }
        private void _LoadPictureAndTitle()
        {
            string testTypeTitle = string.Empty;
            switch (_TestTypeID)
            {
                case 1:
                    {
                        testTypeTitle = "Vision Test Appointments";
                        groupBox1.Text = "Vision Test";
                        pbType.Image = Properties.Resources.Vision_512;
                    }
                    break;
                case 2:
                    {
                        testTypeTitle = "Written Test Appointments";
                        groupBox1.Text = "Written Test";
                        pbType.Image = Properties.Resources.Written_Test_512;
                    }
                    break;
                case 3:
                    {
                        testTypeTitle = "Street Test Appointments";
                        groupBox1.Text = "Street Test";
                        pbType.Image = Properties.Resources.driving_test_512;
                    }
                    break;
            }

            Text = testTypeTitle;
            lblTitle.Text = testTypeTitle;
        }
    }
}
