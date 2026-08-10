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
using static System.Windows.Forms.AxHost;

namespace DVLD
{
    public partial class frmAddUser : Form
    {
        DataTable _dt;
        clsPerson _person;
        clsUsers _User = new clsUsers();
        bool _IsUpdateMode = false;
        int _PersonID = -1;
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;
        public frmAddUser(int ID = -1)
        {
            InitializeComponent();
            if (ID != -1)
            {
                _person = clsPerson.Find(ID);
                if (_person != null)
                {
                    _IsUpdateMode = true;
                    ctrlPersonCard1.LoadPersonInfo(ID);
                    cmFiltter.Enabled = false;
                    txtSearch.Enabled = false;
                    _User = clsUsers.FindByPersonID(ID);
                    _PersonID = _User.PersonID;
                    if (_User != null)
                    {
                        lblUserID.Text = _User.UserID.ToString();
                        txtUserName.Text = _User.UserName.ToString();
                        txtPassword.Text = _User.Password.ToString();
                        chIsActive.Checked = _User.IsActive;
                    }
                    this.Text = "Update User";
                    btnSave.Text = "Update";
                }
            }
            else
            {
                _person=new clsPerson();
                this.Text = "Add New User";
                btnSave.Text = "Add";
                _IsUpdateMode=false;
            }
         }

        private void LaodAllPeople()
        {
            _dt = clsPerson.GetAllPerson();
            cmFiltter.Items.Clear();
            cmFiltter.DataSource = null;
            foreach (DataColumn col in _dt.Columns)
            {
                cmFiltter.Items.Add(col.ColumnName);
            }
            cmFiltter.SelectedIndex = -1;
        }
        private void cmFiltter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFiltter.SelectedItem == null)
                return;

            string column = cmFiltter.SelectedItem.ToString();

            switch (column)
            {
                case "PersonID":
                case "NationalityCountryID":
                    // Allow only digits
                    e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
                    _PersonID = Convert.ToInt32(txtSearch.Text);
                    break;

                case "FirstName":
                case "SecondName":
                case "ThirdName":
                case "LastName":
                    // Allow only letters and spaces
                    e.Handled = !char.IsControl(e.KeyChar)
                                && !char.IsLetter(e.KeyChar)
                                && e.KeyChar != ' ';
                    break;
                case "IsActive":
                    break;

                default:
                    // Allow all characters
                    e.Handled = false;
                    break;
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_IsUpdateMode)
            {
                tabControl1.SelectedIndex++;
            }
            else
            {
                clsUsers user = clsUsers.FindByPersonID(Convert.ToInt32(txtSearch.Text));

                if (user != null)
                    MessageBox.Show("This User Exist", "Error");
                else
                    tabControl1.SelectedIndex++;
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            LaodAllPeople();
        }

        private void txtSearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (cmFiltter.SelectedItem == null)
                return;

            string column = cmFiltter.SelectedItem.ToString();

            switch (column)
            {
                case "PersonID":
                case "NationalityCountryID":
                    // Allow only digits
                    e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
                    break;

                case "FirstName":
                case "SecondName":
                case "ThirdName":
                case "LastName":
                    // Allow only letters and spaces
                    e.Handled = !char.IsControl(e.KeyChar)
                                && !char.IsLetter(e.KeyChar)
                                && e.KeyChar != ' ';
                    break;

                default:
                    // Allow all characters
                    e.Handled = false;
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(Convert.ToInt32(txtSearch.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword != null)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    FillUser();

                    string Message = "Added Successfuly", Title = "Add New";

                    if (_IsUpdateMode)
                    {
                        Message = "Update Successfuly";
                        Title = "Update";
                    }

                    MessageBox.Show(Message, Title,MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Passwords Not Match", "Error");
                }

                DataBack?.Invoke(this);

            } 
        }

        private void FillUser()
        {
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            if(chIsActive.Checked)
                _User.IsActive = true;
            else 
                _User.IsActive = false;
            _User.PersonID = _PersonID;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
