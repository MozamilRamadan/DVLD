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
            int ID = 30;
            _applications = clsLocalDrivingLicenseApplications.Find(ID);
            if (_applications != null)
            {
                MessageBox.Show(_applications.ClassName, "Name", MessageBoxButtons.OKCancel);
            }
        }
    }
}
