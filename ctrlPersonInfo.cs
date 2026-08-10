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
    public partial class ctrlPersonInfo : UserControl
    {
        int _PersonID = -1;
        public ctrlPersonInfo()
        {
            InitializeComponent();
           cmFiltter.SelectedIndex = 0;
        }



        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFiltter.SelectedItem == null)
                return;

            string column = cmFiltter.SelectedItem.ToString();

            switch (column)
            {
                case "PersonID":
                    // Allow only digits
                    e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
                    break;

                case "NationalNo":
                    // Allow only letters and spaces
                    e.Handled = !char.IsControl(e.KeyChar)
                                && !char.IsLetter(e.KeyChar)
                                && !char.IsDigit(e.KeyChar);
                    break;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string column = cmFiltter.SelectedItem.ToString();


            switch (column)
            {
                case "PersonID":
                    if (int.TryParse(txtSearch.Text, out int personID))
                        ctrlPersonCard1.LoadPersonInfo(personID);
                    break;
                case "NationalNo":
                    ctrlPersonCard1.LoadPersonInfo(txtSearch.Text);
                    break;


            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            frmAddNew frmAddNew = new frmAddNew();  
            frmAddNew.ShowDialog();
        }
    }
}
