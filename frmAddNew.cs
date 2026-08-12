using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddNew : Form
    {
        clsPerson _Person;
        DataTable _dt = new DataTable();
        string ImagePath = @"";
        int CountryIndex = -1, _PersonID = -1;
        bool isUdateMode = false;

        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler DataBack;
        public frmAddNew(int personID = -1)
        {


            InitializeComponent();
            if (personID != -1)
            {
                // Editing mode
                _Person = clsPerson.Find(personID);
                if (_Person != null)
                {
                    isUdateMode =true;
                    lblPersonID.Text = _Person.PersonID.ToString();
                    txtFirstName.Text = _Person.FirstName;
                    txtSecondName.Text = _Person.SecondName;
                    txtThirdName.Text = _Person.ThirdName;
                    txtLastName.Text = _Person.LastName;
                    txtNaNo.Text= _Person.NationalNo;
                    dtDate.Value = _Person.DateOfBirth;
                    txtEmail.Text = _Person.Email;
                    txtPhone.Text = _Person.Phone;
                    txtAddress.Text = _Person.Address;
                    cbCountry.SelectedValue = _Person.NationalityCountryID;
                    pbPersonImage.Image = File.Exists(_Person.ImagePath) ? Image.FromFile(_Person.ImagePath) : null;

                    this.Text = "Update Person";
                    btnSave.Text = "Update";

                }
            }
            else
            {
                _Person = new clsPerson();
                isUdateMode = false;
                this.Text = "Add New Person";
                btnSave.Text = "Save";
            }
        }

        private void frmAddNew_Load(object sender, EventArgs e)
        {

            _dt = clsCountry.GetAllCountries();

            //========================
            cbCountry.DataSource = _dt;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";

            cbCountry.SelectedIndex = 164;

        }
        public void FillPerson()
        {
            cbCountry.DataSource = _dt;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";

            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.Address = txtAddress.Text;
            _Person.Email = txtEmail.Text;
            _Person.DateOfBirth = dtDate.Value;
            if (rdFemail.Checked)
                _Person.Gendor = 1;
            else
                _Person.Gendor = 0;
            _Person.ImagePath = ImagePath; 
            _Person.NationalityCountryID = Convert.ToInt32(cbCountry.SelectedValue);
            _Person.Phone = txtPhone.Text;
            _Person.NationalNo = txtNaNo.Text;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                $"PersonID = {_Person.PersonID}\n" +
                    $"Mode = {_Person.Mode}");

            FillPerson();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email Is Requierd!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");

            }

            if (string.IsNullOrWhiteSpace(txtNaNo.Text))
            {
                errorProvider1.SetError(txtNaNo, "Email is required!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtNaNo, "");
            }

            if (isValid)
            {
                // proceed with saving
                if (_Person.Save())
                {
                   
                    string Message = "", Title = "ADD NEW";
                    if (isUdateMode)
                    {
                        Message = "Updated Successfuly";
                        Title = "Update";
                    }
                    else { Message = "Added Successfuly"; }
                    MessageBox.Show(Message, Title, MessageBoxButtons.OKCancel);
                   
                    this.DialogResult = DialogResult.OK;

                    DataBack?.Invoke(this);

                    this.Close();
                }
            }


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

            string saveFolder = Path.Combine(Application.StartupPath, "DVLD-Images");

            if (!Directory.Exists(saveFolder))
                Directory.CreateDirectory(saveFolder);

            // إذا اختار المستخدم صورة جديدة
            if (!string.IsNullOrWhiteSpace(ImagePath) && File.Exists(ImagePath))
            {
                // حذف الصورة القديمة (إن وجدت)
                if (isUdateMode &&
                    !string.IsNullOrWhiteSpace(_Person.ImagePath) &&
                    File.Exists(_Person.ImagePath))
                {
                    File.Delete(_Person.ImagePath);
                }

                // إنشاء اسم جديد للصورة حتى لا يحدث تكرار
                string extension = Path.GetExtension(ImagePath);
                string newFileName = Guid.NewGuid().ToString() + extension;

                // المسار النهائي
                string destPath = Path.Combine(saveFolder, newFileName);

                // نسخ الصورة الجديدة
                File.Copy(ImagePath, destPath, true);

                // حفظ المسار الجديد في الكائن
                _Person.ImagePath = destPath;
            }

        }

        private void txbNaNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNaNo.Text))
            {
                e.Cancel = true;
                txtNaNo.Focus();
                errorProvider1.SetError(txtNaNo, "The National Number Is Requierd");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNaNo, "");
            }
        }

        private void txEmail_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email Is Requierd");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbPhone_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtNaNo.Focus();
                errorProvider1.SetError(txtPhone, "Phone Is Requierd");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

      


    }
}
