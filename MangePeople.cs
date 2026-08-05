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
    public partial class MangePeople : Form
    {
        DataTable _dt = clsPerson.GetAllPerson();
        int index = -1;
        //int personID = -1;
        
        public MangePeople()
        {
            InitializeComponent();
        }
        
        public void LoadAllPeople()
        {
            //cmbFillter.SelectedIndexChanged -= cmbFillter_SelectedIndexChanged;
            _dt = clsPerson.GetAllPerson();

            dataGridView1.DataSource = _dt;

            cmbFillter.Items.Clear(); // clear old items

            lblRecords.Text = _dt.Rows.Count.ToString();

            foreach (DataColumn col in _dt.Columns)
            {
                cmbFillter.Items.Add(col.ColumnName);
            }

            cmbFillter.SelectedIndex = -1; 
            //cmbFillter.SelectedIndexChanged += cmbFillter_SelectedIndexChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAllPeople();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             
            lblRecords.Text = _dt.Rows.Count.ToString();
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = -1;
            if (_dt != null)
            {
                // Assuming your grid has a PersonID column
                personID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value);
            }

            if (clsPerson.DeletePerson(personID))
            {
                MessageBox.Show("Deleted Successfuly","Delete Person");
                LoadAllPeople();
            }
            else
            {
                MessageBox.Show("Delete Person", "Faiel To Delete");
            }
        }
    }
}
