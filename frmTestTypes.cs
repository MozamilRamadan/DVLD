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
    public partial class frmTestTypes : Form
    {
        DataTable _dt;
        public frmTestTypes()
        {
            InitializeComponent();
            LoadData();

        }
        void LoadData()
        {
            _dt = clsTestTypes.GetAllTestTypeData();

            dataGridView1.DataSource = _dt;

            dataGridView1.Columns["TestTypeDescription"].DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            lblRecords.Text = _dt.Rows.Count.ToString();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TestTypeID"].Value);
            frmEditTestTypes frm = new frmEditTestTypes(ID);
            frm.dataBack += Frm_dataBack;
            frm.ShowDialog();
        }

        private void Frm_dataBack(object sender)
        {
            LoadData();
        }
    }
}
