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
    public partial class frmManageApplicationTypes : Form
    {
        DataTable _dt = new DataTable();
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            _dt = clsApplicationTypes.GetAllApplicationTypes();
            if(_dt != null)
            {
                dataGridView1.DataSource = _dt;
                lblRecords.Text = _dt.Rows.Count.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ApplicationTypeID"].Value);
            frmEditFees Fees = new frmEditFees(ID);
            Fees.dataBack += Fees_dataBack;
            Fees.ShowDialog();
        }

        private void Fees_dataBack(object sender)
        {
            _dt = clsApplicationTypes.GetAllApplicationTypes();
            dataGridView1.DataSource = _dt;
            lblRecords.Text = _dt.Rows.Count.ToString();
        }
    }
}
