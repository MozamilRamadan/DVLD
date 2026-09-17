using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmSchedualVissionTest : Form
    {
        int _ID = 0, _TestTypeID = -1;
        clsTestAppointment tp;
        public frmSchedualVissionTest(int id,int testTypeID)
        {
            InitializeComponent();
            _ID = id;
            _TestTypeID = testTypeID;
            ctrlApplicationDetails1.LoadInfo(_ID);
            LoadData();
            _LoadPictureAndTitle();
        }
        void LoadData()
        {
            DataTable dt = clsTestAppointment.GetAllTestAppointment();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnLocal_Click(object sender, EventArgs e)
        {

            tp = clsTestAppointment.FindByLDLAID(_ID);
            if (tp != null)
            {
                if (tp.AppointmentDate > DateTime.Today && tp.TestTypeID == _TestTypeID)
                {
                    MessageBox.Show("The CLient Already Have Appoinment Date.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            frmSchedualTest frm = new frmSchedualTest(_ID,_TestTypeID);
            frm.dataBack += Frm_dataBack;
            frm.ShowDialog();
        }

        private void Frm_dataBack(object sender)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int TestAppointmentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TestAppointmentID"].Value);
            frmSchedualTest frmSchedualTest = new frmSchedualTest(id, _TestTypeID, TestAppointmentID);
            frmSchedualTest.dataBack += Frm_dataBack;
            frmSchedualTest.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TestAppointmentID"].Value);
            frmTakeTest test = new frmTakeTest(TestAppointmentID,_TestTypeID);
            test.Show();
        }
        private void _LoadPictureAndTitle()
        {
            string testTypeTitle = string.Empty;

            switch (_TestTypeID)
            {
                case 1:
                    {
                        testTypeTitle = "Vision Test Appointments";
                        pbType.Image = Properties.Resources.Vision_512;
                    }
                    break;
                case 2:
                    {
                        testTypeTitle = "Written Test Appointments";
                        pbType.Image = Properties.Resources.Written_Test_512;
                    }
                    break;
                case 3:
                    {
                        testTypeTitle = "Street Test Appointments";
                        pbType.Image = Properties.Resources.driving_test_512;
                    }
                    break;
            }

            Text = testTypeTitle;
            lblTestTitle.Text = testTypeTitle;
        }
    }
}


