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
    public partial class frmAddUser : Form
    {
        DataTable _dt;
        clsPerson _person;
        public frmAddUser()
        {
            InitializeComponent();
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
        private void btnNext_Click(object sender, EventArgs e)
        {
            tpLoginInfo.Show();
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
            _person = clsPerson.Find(1023);
            ctrlPersonCard PersonCard = new ctrlPersonCard();
            int Id = 0;
            Id = _person.PersonID;
            PersonCard.LoadPersonInfo(Id);
        }
    }
}
