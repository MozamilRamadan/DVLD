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
        DataTable _dt;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frmEditFees Fees = new frmEditFees(ID);
            Fees.dataBack += Fees_dataBack;
            Fees.ShowDialog();
            frmManageApplicationTypes_Load(null, null);
        }

        private void Fees_dataBack(object sender)
        {
            _dt = clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dt;
            lblRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _dt= clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dt;
            lblRecords.Text = _dt.Rows.Count.ToString();

            dgvApplicationTypes.Columns[0].HeaderText = "ID";
            dgvApplicationTypes.Columns[0].Width = 110;

            dgvApplicationTypes.Columns[1].HeaderText = "Title";
            dgvApplicationTypes.Columns[1].Width = 400;

            dgvApplicationTypes.Columns[2].HeaderText = "Fees";
            dgvApplicationTypes.Columns[2].Width = 100;
        }
    }
}
