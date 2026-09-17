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
    public partial class frmMangeUsers : Form
    {
        DataTable _dt;
        public frmMangeUsers()
        {
            InitializeComponent();
        }

        void LoadAllUsers()
        {
            _dt = clsUsers.GetAllUser();
            dataGridView1.DataSource = _dt;
            cmFiltter.Items.Clear();
            foreach (DataColumn col in _dt.Columns)
            {
                cmFiltter.Items.Add(col.ColumnName);
            }
            cmFiltter.SelectedIndex = -1;
            lblRecords.Text = _dt.Rows.Count.ToString();

        }

        private void frmMangeUsers_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int personID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value);
            frmAddUser Update = new frmAddUser(personID);
            Update.DataBack += Update_DataBack;
            Update.ShowDialog();
        }

        private void Update_DataBack(object sendor)
        {
            LoadAllUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = -1;
            if (_dt != null)
                 Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserID"].Value);
            if (clsUsers.DeleteUser(Id))
            {
                MessageBox.Show("Deleted Successfuly", "Delete Person");
                LoadAllUsers();
            }
            else
            {
                MessageBox.Show("Faild To Delete","Delete Person");
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value);
            frmChangePassword changePassword = new frmChangePassword(PersonID);
            changePassword.ShowDialog();
        }

    }
}
