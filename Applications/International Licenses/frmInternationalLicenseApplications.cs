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
    public partial class frmInternationalLicenseApplications : Form
    {
        DataTable dt = clsInternationalLicense.GetAllLicenseInfo();
        public frmInternationalLicenseApplications()
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
            lblRecords.Text = dt.Rows.Count.ToString();
        }
        public void LoadDTInfo()
        {

            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["InternationalLicenseID"],
                    row["ApplicationID"],
                    row["DriverID"],
                    row["IssuedUsingLocalLicenseID"],
                    (DateTime)row["IssueDate"],
                    (DateTime)row["ExpirationDate"],
                    row["IsActive"]

                    );
            }
        }
    }
}
