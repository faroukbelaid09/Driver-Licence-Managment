using DrivingLicenseBusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ctrlAddEdit : UserControl
    {
        private enum Mode { Add = 1, Edit = 2 };
        private Mode _mode = Mode.Add;

        private string _ImagePath = string.Empty;

        private void _LoadDataIntoForm(clsPerson person)
        {
            if (person != null)
            {
                _mode = Mode.Edit;
            }

            if (_mode == Mode.Edit)
            {
                PersonIDValue.Text = person.PersonID.ToString();
                FirstNameTB.Text = person.FirstName.ToString();
                LastNameTB.Text = person.LastName.ToString();
                NationalNoTB.Text = person.NationalNo.ToString();
                DateOfBirthTB.Text = person.DateOfBirth.ToString();
                if (person.GenderTitle == "Male")
                {
                    GenderMaleRB.Checked = true;
                }
                else
                {
                    GenderFemaleRB.Checked = true;
                }

                PhoneTB.Text = person.Phone.ToString();
                EmailTB.Text = person.Email.ToString();
                AddressTB.Text = person.Address.ToString();
                CountryCB.SelectedIndex = person.CountryID-1;

                if (!string.IsNullOrEmpty(person.ImagePath)) { 
                    ProfilePB.Image = (Bitmap)ProfilePictureHelper.LoadProfilePicture(person.ImagePath);
                } 
                ProfilePB.ImageLocation = person.ImagePath;
            }
        }
        private void _EmptyValidator(TextBox textBox) {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Focus();
                errorProvider1.SetError(textBox, "Cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }

        // GETTERS
        public string GetFirstName() {  return FirstNameTB.Text; }
        public string GetLastName() {  return LastNameTB.Text; }
        public string GetNationalNo() {  return NationalNoTB.Text; }
        public string GetDateOFBirth() {  return DateOfBirthTB.Text; }
        public int GetGender() { return GenderMaleRB.Checked ? 1 : 0; }
        public string GetAddress() {  return AddressTB.Text; }
        public string GetEmail() {  return EmailTB.Text; }
        public string GetPhone() {  return PhoneTB.Text; }
        public int GetCountryID() {  return CountryCB.SelectedIndex+1; }
        public string GetImagePath() { return _ImagePath; }
        public void SetImagePath(string imagePath) { _ImagePath = imagePath; }
        public Bitmap GetImage() { return (Bitmap)ProfilePB.Image; }
        public string GetImageLocation()
        {
            return ProfilePB.ImageLocation;
        }
        
        public ctrlAddEdit()
        {
            InitializeComponent();

            CountryCB.SelectedIndex = 2;
            CountryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderMaleRB.Checked = true;

            // Set maximum date to today
            DateOfBirthTB.MaxDate = DateTime.Today.AddYears(-18);
            DateOfBirthTB.Value = DateTime.Today.AddYears(-18);

            ProfilePB.Image = (Bitmap)ProfilePictureHelper.LoadProfilePicture(ProfilePictureHelper.DefaultProfilePicturePath);
        }

        public void HandleDataReceived(clsPerson person)
        {
            if (person != null)
            {
                _LoadDataIntoForm(person);
            }
        }
        private void SetImageLinkLable_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the image
                        string fullPath = openFileDialog.FileName;
                        ProfilePB.Image = new Bitmap(fullPath);
                        ProfilePB.ImageLocation = fullPath;
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void FirstNameTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(FirstNameTB);
        }
        private void LastNameTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(LastNameTB);
        }
        private void NationalNoTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(NationalNoTB);
        }
        private void PhoneTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(PhoneTB);
        }
        private void AddressTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(AddressTB);
        }
        private void EmailTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(EmailTB);
        }
        private ErrorProvider errorProvider = new ErrorProvider();
        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                errorProvider.SetError(PhoneTB, "Please enter numbers only");
                e.Handled = true;
            }
            else
            {
                errorProvider.SetError(PhoneTB, ""); // Clear error
            }
        }
    }
}