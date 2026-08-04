using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD
{
    public partial class ctrlAddNew : UserControl
    {
        clsPerson _Person = new clsPerson();
        string ImagePath = @"";
        int CountryIndex = -1;
        public ctrlAddNew()
        {
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            DataTable _dt = new DataTable();
            _dt = clsCountry.GetAllCountries();

            //========================
            cbCountry.DataSource = _dt;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";

            cbCountry.SelectedIndex = 165;

            rdMale.Checked = true;
        }

        public void FillPerson()
        {
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txbLastName.Text;
            _Person.Address = txbAddress.Text;
            _Person.Email = txtEmail.Text;
            _Person.DateOfBirth = dtDate.Value;
            if(rdFemail.Checked) 
                _Person.Gendor = 1;
            else
                _Person.Gendor= 0;

            _Person.ImagePath = ImagePath; 
            _Person.NationalityCountryID = Convert.ToInt32(cbCountry.SelectedValue);
            _Person.Phone = txbPhone.Text;
            _Person.NationalNo = txtNaNo.Text;

        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMale.Checked)
                pbPersonImage.Image = Resources.Mail;
        }

        private void rdFemail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFemail.Checked)
            {
                pbPersonImage.Image = Resources.Female;
            }
        }


        private void lblSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImagePath = ofd.FileName;

                // Load into PictureBox
                pbPersonImage.Image = Image.FromFile(ImagePath);

                // Optionally store the path in Tag or your Person object
                pbPersonImage.Tag = ImagePath;
            }

            string saveFolder = Path.Combine(Application.StartupPath, "E:\\DVLD\\DVLD\\DVLD-Images");

            // Create folder if it doesn’t exist
            if (!Directory.Exists(saveFolder))
                Directory.CreateDirectory(saveFolder);
            if (!string.IsNullOrWhiteSpace(ImagePath) && File.Exists(ImagePath))
            {

                // Copy image to SavedImages folder
                string fileName = Path.GetFileName(ImagePath);
                string destPath = Path.Combine(saveFolder, fileName);

                File.Copy(ImagePath, destPath, true); // overwrite if exists
            }
            else
            {
                pbPersonImage.Image = null;
            }

        }

 }
}


