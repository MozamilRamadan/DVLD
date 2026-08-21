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
    public partial class frmSchedualTest : Form
    {
        int _LDAppID = -1;
        clsTestAppointment _tp;
        public frmSchedualTest(int id)
        {
            InitializeComponent();
            _LDAppID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {

        }

        void FillData()
        {
            clsLocalDrivingLicenseApplications _app = clsLocalDrivingLicenseApplications.Find(_LDAppID);
            lblAppID.Text = _LDAppID.ToString();
            lblClassID.Text = clsLicenseClass.Find(_LDAppID).licenseClassID.ToString();
            lblName.Text = clsPerson.Find(_app.ApplicantPersonID).FullName;
            lblFees.Text = _tp.PaidFees.ToString();
        }
    }
}
