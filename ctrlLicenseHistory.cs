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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class ctrlLicenseHistory : UserControl
    {
        int _LDLID = -1;
        clsLicense _license;
        clsLocalDrivingLicenseApplications _applications;
        DataTable dt;
        public ctrlLicenseHistory(int ID)
        {
            InitializeComponent();
            _LDLID = ID;
            _applications = clsLocalDrivingLicenseApplications.Find(_LDLID);
            ctrlPersonCard1.LoadPersonInfo(_applications.ApplicantPersonID);
            _LoadData();
        }
        void TabSwitch()
        {

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dt = clsLicense.GetAllLicenseInfo();
                    break;
                case 1:
                    dt = clsInternationalLicense.GetAllLicenseInfo();
                    break;
            }
        }
        void _LoadData()
        {
            TabSwitch();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblRecords.Text = dt.Rows.Count.ToString();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            TabSwitch();
        }
    }
}
