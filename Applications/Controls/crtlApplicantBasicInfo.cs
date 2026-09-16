using DVLD.Global_Glasses;
using DVLD.People;
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

namespace DVLD.Applications.Controls
{
    public partial class crtlApplicantBasicInfo : UserControl
    {
        clsApplication _app;
        int _applicationID = -1;
        public int ApplicationID
        {
            get {return _applicationID;}
        }

        public crtlApplicantBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int id) {
            _app = clsApplication.Find(ApplicationID);
            if (_app == null) {

                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _FillApplicationInfo();

            }
        }
        
        private void lblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_app.ApplicantPersonID);
            frm.ShowDialog();
        }

        void ResetApplicationInfo()
        {
            _applicationID = -1;

            lblAppID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblType.Text = "[????]";
            lblFees.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreateBy.Text = "[????]";

        }

        void _FillApplicationInfo()
        {
            _applicationID = _app.ApplicationID;

            lblAppID.Text = _applicationID.ToString();
            lblStatus.Text = _app.StatusText;
            lblType.Text = _app.appTypeInfo.ApplicationTypeTitle;
            lblFees.Text = _app.PaidFees.ToString();
            lblApplicant.Text = _app.FullName;
            lblDate.Text = clsFormat.DateToShort(_app.ApplicationDate);
            lblStatusDate.Text = clsFormat.DateToShort(_app.LastStatusDate);
            lblCreateBy.Text = _app.CreateUserInfo.UserName;
        }
    }
}
