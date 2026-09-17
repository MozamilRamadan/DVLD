using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        DataTable _dt;
        clsLocalDrivingLicenseApplications _applications;
        int _localAppID = -1;
        bool _visionPassed;

        bool _writtenPassed;
        bool _streetPassed;
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            FillInfo();
        }

        public void LoadDTInfo(DataTable dt)
        {

            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["LocalDrivingLicenseApplicationID"],
                    row["ClassName"],
                    row["NationalNo"],
                    row["FirstName"],
                    (DateTime)row["ApplicationDate"],
                    row["PassedTestCount"],
                    row["Status"]

                    );
            }
        }
        public void FillInfo()
        {
            _dt = clsLocalDrivingLicenseApplications.GetAllLDLApllicationsData();
            dataGridView1.DataSource = _dt;
            //LoadDTInfo(_dt );
            lblRecords.Text = _dt.Rows.Count.ToString();

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            frmLocalDrinvingApplicationInfo frm = new frmLocalDrinvingApplicationInfo(localAppID);
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingApplication Add = new frmAddNewLocalDrivingApplication();

            Add.DataBack += Add_DataBack;
            Add.ShowDialog();
        }

        private void Add_DataBack(object sender)
        {
            FillInfo();
        }

        private void sechduleVissionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int TestTypeID = 1;
            frmSchedualVissionTest frm = new frmSchedualVissionTest(_localAppID, TestTypeID);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scheduleTestTSMI_DropDownOpening(object sender, EventArgs e)
        {
            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);

            string status = Convert.ToString(dataGridView1.CurrentRow.Cells["Status"].Value);


            _visionPassed = clsTest.IsTestPassed(localAppID, 1);
            _writtenPassed = clsTest.IsTestPassed(localAppID, 2);
            _streetPassed = clsTest.IsTestPassed(localAppID, 3);

            sechduleVissionTestToolStripMenuItem.Enabled = false;
            sechduleWriteTestToolStripMenuItem.Enabled = false;
            sechduleStrretTestToolStripMenuItem.Enabled = false;


            if (!_visionPassed)
            {
                sechduleVissionTestToolStripMenuItem.Enabled = true;
            }

            else if (!_writtenPassed) { sechduleWriteTestToolStripMenuItem.Enabled = true; }
            else if (!_streetPassed) { sechduleStrretTestToolStripMenuItem.Enabled = true; }

            if(status == "Completed")
            {
                issuesDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;

                scheduleTestTSMI.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                cancelAppToolStripMenuItem.Enabled = !false;
            }
        }

        private void cmFormat_Opening(object sender, CancelEventArgs e)
        {
             _localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);

            string status = Convert.ToString(dataGridView1.CurrentRow.Cells["Status"].Value);

            issuesDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
            scheduleTestTSMI.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            deleteToolStripMenuItem.Enabled = true;
            cancelAppToolStripMenuItem.Enabled = !true;

            //if (status == "Completed")
            //{
            //    issuesDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
            //    scheduleTestTSMI.Enabled = false;
            //    editToolStripMenuItem.Enabled = false;
            //    deleteToolStripMenuItem.Enabled= false;
            //    cancelAppToolStripMenuItem.Enabled = false;

            //}
        }
        private void sechduleWriteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int TestTypeID = 2;
            frmSchedualVissionTest frm = new frmSchedualVissionTest(localAppID, TestTypeID);
            frm.Show();
        }

        private void sechduleStrretTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int TestTypeID = 3;
            frmSchedualVissionTest frm = new frmSchedualVissionTest(localAppID, TestTypeID);
            frm.Show();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            if (clsLocalDrivingLicenseApplications.DeleteLDLApplication(localAppID))
            {
                MessageBox.Show("Deleted Successfuly","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show("Faild To Delete", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            frmAddNewLocalDrivingApplication frm = new frmAddNewLocalDrivingApplication(localAppID);
            frm.Show();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            frmShowLicenseInfo licenseInfo = new frmShowLicenseInfo(localAppID);
            licenseInfo.Show();
        }

        private void issuesDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            frmIssueFirstDriverLicense issues = new frmIssueFirstDriverLicense(id);
            issues.Show();
        }

        private void showPersonLicensessHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            frmLicenseHistory history = new frmLicenseHistory(id);
            history.Show();
        }
    }
}
