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
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        DataTable _dt;
        clsLocalDrivingLicenseApplications _applications;
        int _ID;
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

        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
             _ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            frmLocalDrinvingApplicationInfo frm = new frmLocalDrinvingApplicationInfo(_ID);
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sechduleVissionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int TestTypeID = 1;
            frmSchedualVissionTest frm = new frmSchedualVissionTest(_ID, TestTypeID);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void scheduleTestTSMI_DropDownOpening(object sender, EventArgs e)
        {
            int localAppID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            bool visionPassed = clsTest.IsTestPassed(localAppID, 1);

            bool writtenPassed = clsTest.IsTestPassed(localAppID, 2);
            bool streetPassed = clsTest.IsTestPassed(localAppID, 3);

            sechduleVissionTestToolStripMenuItem.Enabled = false;
            sechduleWriteTestToolStripMenuItem.Enabled = false;
            sechduleStrretTestToolStripMenuItem.Enabled = false;

            if(!visionPassed)
                sechduleVissionTestToolStripMenuItem.Enabled = true;
            else if(!writtenPassed) sechduleWriteTestToolStripMenuItem.Enabled   = true;
            else if(!streetPassed) sechduleStrretTestToolStripMenuItem.Enabled = true;

        }

        private void sechduleWriteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int TestTypeID = 2;
            frmSchedualVissionTest frm = new frmSchedualVissionTest(_ID, TestTypeID);
            frm.Show();
        }

        private void sechduleStrretTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value);
            int TestTypeID = 3;
            frmSchedualVissionTest frm = new frmSchedualVissionTest(_ID, TestTypeID);
            frm.Show();

        }
    }
}
