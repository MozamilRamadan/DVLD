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
    public partial class frmAddNewLocalDrivingApplication : Form
    {
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;

        DataTable _dt;
        clsLicenseClass _LClass;
        clsLocalDrivingLicenseApplications _applications = new clsLocalDrivingLicenseApplications();
        enum enStatus {All =0, New =1,Canceled=2 ,Completed = 3 }
        enStatus _status;
        int _PersonID, _cmClassID;
        decimal _applicationFees;
        string _NaNo;
        public frmAddNewLocalDrivingApplication(int Id=-1)
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
            cmClass.SelectedIndex = 2;
            _applicationFees = clsApplicationTypes.Find(1).ApplicationFees;

            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
            _cmClassID = cmClass.SelectedIndex;
            _LClass = clsLicenseClass.Find(_cmClassID);
            if (_LClass != null)
            {
                lblFees.Text = _LClass.ClassFees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte AppStatus = Convert.ToByte(_status = enStatus.New);
            _applications.ApplicationDate = DateTime.Now;
            _applications.PaidFees = _applicationFees;
            _applications.CreatedByUserID = clsCurrentUser._USER.UserID;
            _applications.ApplicationStatus = AppStatus;
            _applications.LicenseClassID = _cmClassID;
            _applications.ApplicationTypeID = 1;
            _applications.ApplicantPersonID = _PersonID;
            clsApplication app = clsApplication.FindByAppPersonIDAndAppTypeID(_PersonID, 1, AppStatus);


            if (app != null )
            {
                MessageBox.Show("This Application Already Exist", "Founded", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (_applications.Save())
                {
                    DataBack?.Invoke(this);

                    MessageBox.Show("Driver Liences Added Successfuly", "Success", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Faild To Add Driver Liences", "Error", MessageBoxButtons.OKCancel);
                }

            }
            ////

        }
    }
}
