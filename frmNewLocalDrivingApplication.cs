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
        clsLicenseClass _LClass;
        clsLocalDrivingLicenseApplications _applications;
        clsApplication _app;
        enum enStatus {All =0, New =1, Update=2, Canceled=3}
        enStatus _status;
        int _PersonID;
        decimal _applicationFees;
        string _NaNo;
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
                foreach (DataRow row in _dt.Rows)
                {
                    cmClass.Items.Add(row["ClassName"].ToString());
                }
            }
            cmClass.SelectedIndex = 3;
            _applicationFees = clsApplicationTypes.Find(1).ApplicationFees;
            lblDate.Text = DateTime.Now.ToString();
            lblFees.Text = _applicationFees.ToString();
            lblCreatedUserID.Text = clsCurrentUser._USER.UserID.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            _PersonID = ctrlPersonInfo1._PersonID;
            _NaNo = ctrlPersonInfo1._NaNo;
            if(_NaNo !="" || _PersonID > 0)
            {
                tabControl1.SelectedIndex++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cmClass.SelectedIndex;
            _LClass = clsLicenseClass.Find(id);
            if (_LClass != null)
            {
                lblFees.Text = _LClass.ClassFees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _app.ApplicationDate = DateTime.Now;
            _app.PaidFees = _applicationFees;
            _app.CreatedByUserID = clsCurrentUser._USER.UserID;
            _app.ApplicationStatus = Convert.ToByte(_status = enStatus.New);
            ////

        }
    }
}
