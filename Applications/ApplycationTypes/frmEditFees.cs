using DVLD.Global_Glasses;
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
    public partial class frmEditFees : Form
    {
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler dataBack;
        clsApplicationTypes _AppType;
        int _AppTypeID = -1;
        public frmEditFees(int ID)
        {
            InitializeComponent();
            _AppTypeID = ID;
        }

        private void FillData()
        {
            _AppType = clsApplicationTypes.Find(_AppTypeID);

            lblID.Text = _AppTypeID.ToString();
            if (_AppType != null)
            {
                txtTitle.Text = _AppType.ApplicationTypeTitle.ToString();
                txtFees.Text = _AppType.ApplicationFees.ToString();
            }
        }

    

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _AppType.ApplicationFees = Convert.ToDecimal(txtFees.Text.Trim());
            _AppType.ApplicationTypeTitle = txtTitle.Text.Trim();

            if (_AppType.Save())
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataBack?.Invoke(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditFees_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {



            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFees, null);

            }
            ;


            if (!clsValidation.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
            ;

        }
    }
}
