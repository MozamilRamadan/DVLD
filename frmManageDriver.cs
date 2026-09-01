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
    public partial class frmManageDriver : Form
    {
        DataTable _dt;
        public frmManageDriver()
        {
            InitializeComponent();
            _dt = clsDriver.GetAllDriverInfo();
            dataGridView1.DataSource = _dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbFillter.Items.Clear();
            
            if (_dt != null)
            {
                foreach (DataColumn col in _dt.Columns)
                {
                    cmbFillter.Items.Add(col.ColumnName);
                }

            }
            lblRecords.Text = _dt.Rows.Count.ToString();
            cmbFillter.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
