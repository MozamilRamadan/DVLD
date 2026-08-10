using System;
using DVLD_BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using DVLD.Properties;

namespace DVLD
{
    public partial class ctrlPersonCard : UserControl
    {
        clsPerson _Person;
        int _PersonID;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();

        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person != null)
            {
                _FillPersonInfo();

            }
            else
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person With ID " + _PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LoadPersonInfo(string Nano)
        {
            _Person = clsPerson.Find(Nano);

            if (_Person != null)
            {
                _FillPersonInfo();

            }
            else
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person With ID " + Nano.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonIDSrc.Text = _PersonID.ToString();
            lblFullName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lblNaionalNo.Text = _Person.NationalNo;
            if (_Person.Gendor == 0)
            {
                pictureBox2.Image = Resources.Mail;
                lblGendor.Text = "Male";
            }
            else
            {
                pictureBox2.Image = Resources.Female;
                lblGendor.Text = "Female";
            }
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblPhone.Text = _Person.Phone;
            //lblCountry.Text = _Person.NationalityCountryID.ToString();
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;

            
            if (File.Exists(_Person.ImagePath))
            {
              pbPersonImage.Load(_Person.ImagePath);
            }
            

        }

        private void _ResetPersonInfo() {
            lblFullName.Text = "" + " ";
            lblNaionalNo.Text = "";
            lblGendor.Text = "Male";
            lblEmail.Text = "";
            lblAddress.Text = "";
            lblDate.Text = "";
            lblPhone.Text = "";
            //lblCountry.Text = _Person.NationalityCountryID.ToString();
            lblCountry.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNew frm = new frmAddNew(_PersonID);
            frm.ShowDialog();
        }
    }
}
