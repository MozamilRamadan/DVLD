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
        public frmEditFees(int ID)
        {
            InitializeComponent();
            _AppType = clsApplicationTypes.Find(ID);
            FillData();
        }

        private void FillData()
        {
            if (_AppType != null) {
                lblID.Text = _AppType.ApplicationTypeID.ToString();
                txtTitle.Text = _AppType.ApplicationTypeTitle.ToString();
        }

    }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFees.Text))
            {
                _AppType.ApplicationFees = Convert.ToDecimal(txtFees.Text);
                
            }

            if (_AppType.Save())
                MessageBox.Show("Change Succssfuly","Success",MessageBoxButtons.OKCancel);
            else

                MessageBox.Show("Faild To Save", "Faild", MessageBoxButtons.OKCancel);
            dataBack?.Invoke(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
