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
    public partial class frmEditTestTypes : Form
    {
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler dataBack;
        clsTestTypes _Type;
        public frmEditTestTypes(int ID)
        {
            InitializeComponent();
            _Type =clsTestTypes.Find(ID);
            FillData();
        }

        void FillData()
        {
            if (_Type != null)
            {
                lblID.Text = _Type.TestTypeID.ToString();
                rtxtDescription.Text = _Type.TestTypeDescription.ToString();
                txtTitle.Text = _Type.TestTypeTitle.ToString();
                txtFees.Text = _Type.TestTypeFees.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Type.TestTypeDescription = rtxtDescription.Text;
            _Type.TestTypeFees = Convert.ToDecimal(txtFees.Text);

            if (_Type.Save())

                MessageBox.Show("Saved Succssfuly", "Success", MessageBoxButtons.OKCancel);
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
