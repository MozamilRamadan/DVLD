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
    public partial class frmLicenseHistory : Form
    {
        int _LDLID = -1;
        clsLicense _license;
        clsLocalDrivingLicenseApplications _applications;
        public frmLicenseHistory(int ID)
        {
            InitializeComponent();
            _LDLID = ID;
            _applications = clsLocalDrivingLicenseApplications.Find(_LDLID);
            ctrlPersonCard1.LoadPersonInfo(_applications.ApplicantPersonID);
            _LoadData();
        }

        void _LoadData()
        {
            DataTable dt = clsLicense.GetAllLicenseInfo();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblRecords.Text = dt.Rows.Count.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
