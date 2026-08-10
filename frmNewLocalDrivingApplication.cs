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
    public partial class frmNewLocalDrivingApplication : Form
    {
        DataTable _dt;
        clsLicenseClass _clsLicenseClass;
        int _PersonID;
        public frmNewLocalDrivingApplication(int Id=-1)
        {
            InitializeComponent();
            FillData();
        }

        void FillData()
        {

            _dt = clsLicenseClass.GetAllClasses();
            if (_dt != null)
            {
                cmClass.Items.Clear();
                foreach (DataColumn col in _dt.Columns)
                {
                    cmClass.Items.Add(col.ColumnName);
                }
            }
            cmClass.SelectedIndex = 0;

            lblDate.Text = DateTime.Now.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }
        
    }
}
