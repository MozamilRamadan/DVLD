using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD
{
    public partial class Form2 : Form
    {
        DataTable _dt = clsPerson.GetAllPerson();
        int index = -1;
        //int personID = -1;
        
        public Form2()
        {
            InitializeComponent();
        }
        
        public void LoadAllPeople()
        {
            _dt = clsPerson.GetAllPerson();

            dataGridView1.DataSource = _dt;

            cmbFillter.Items.Clear(); // clear old items

            foreach (DataColumn col in _dt.Columns)
            {
                cmbFillter.Items.Add(col.ColumnName);
            }

            cmbFillter.SelectedIndex = -1; // no selection initially

            //for (int i = 0; i < _dt.Rows.Count-1; i++)
            //{

            //    cmbFillter.Items.Add(_dt.Columns[i].ColumnName);
            //    cmbFillter.SelectedIndex = i;
            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAllPeople();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int Records = _dt.Rows.Count;
            lblRecords.Text = Records.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNew frmAdd = new frmAddNew();
            frmAdd.DataBack += FrmAdd_DataBack;
            frmAdd.ShowDialog();
        }

        private void FrmAdd_DataBack(object sender)
        {
            LoadAllPeople();
        }

        private void cmbFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbFillter.DataSource = _dt;
            //index = cmbFillter.SelectedIndex;
            bool sortAscending= true;
            if (cmbFillter.SelectedIndex != -1)
            {
                string columnName = cmbFillter.SelectedItem.ToString();

                DataView dv = new DataView(_dt);

                dv.Sort = columnName + (sortAscending ? " ASC" : " DESC");
                sortAscending = !sortAscending; // flip for next time

                dataGridView1.DataSource = dv;
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNew addNew = new frmAddNew();
            addNew.DataBack += FrmAdd_DataBack;
            addNew.ShowDialog();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            if (_dt != null)
            {
                // Assuming your grid has a PersonID column
                int personID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value);
                frmPersonCard frmPersonCard = new frmPersonCard(personID);
                frmPersonCard.ShowDialog();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int personID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value);
            frmAddNew Update = new frmAddNew(personID);
            Update.DataBack += FrmAdd_DataBack;
            Update.ShowDialog();
        }
    }
}
