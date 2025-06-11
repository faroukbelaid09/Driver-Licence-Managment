using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class AddEditForm : Form
    {
        public delegate void TriggerEventHandler(clsPerson person = null);
        public event TriggerEventHandler EventTrigger;

        clsPerson _Person;
        private clsPerson GetDataFromForm()
        {
            int PersonID = _Person != null ? Convert.ToBoolean(_Person.PersonID) ? _Person.PersonID : -1 : -1;
            string NationalNo = ctrlAddEdit1.GetNationalNo();
            string FirstName = ctrlAddEdit1.GetFirstName();
            string LastName = ctrlAddEdit1.GetLastName();
            DateTime DateOfBirth = Convert.ToDateTime(ctrlAddEdit1.GetDateOFBirth());
            int Gender = ctrlAddEdit1.GetGender();
            string Address = ctrlAddEdit1.GetAddress();
            string Email = ctrlAddEdit1.GetEmail();
            string Phone = ctrlAddEdit1.GetPhone();
            int CountryID = ctrlAddEdit1.GetCountryID();
            string ImagePath = ctrlAddEdit1.GetImagePath();

            return new clsPerson(PersonID,NationalNo,FirstName,LastName,Gender,Phone,
                Address,DateOfBirth,CountryID,ImagePath,Email);
        }
        private void AddNewPerson()
        {
            clsPerson NewPerson = GetDataFromForm();
            bool WasAdded = false;

            if (!string.IsNullOrEmpty(NewPerson.NationalNo) && !string.IsNullOrEmpty(NewPerson.FirstName)
                && !string.IsNullOrEmpty(NewPerson.LastName) && !string.IsNullOrEmpty(NewPerson.Address)
                && !string.IsNullOrEmpty(NewPerson.Phone))
            {
                WasAdded = NewPerson.Add();
            }

            if (WasAdded)
            {
                DialogResult res =  MessageBox.Show("Person Added Successfully", "Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(res == DialogResult.OK)
                {
                    EventTrigger?.Invoke(_Person);
                    this.Close();
                }
            }
        }
        private void UpdatePerson() {
            _Person = GetDataFromForm();

            if (!string.IsNullOrEmpty(_Person.NationalNo) && !string.IsNullOrEmpty(_Person.FirstName)
                && !string.IsNullOrEmpty(_Person.LastName) && !string.IsNullOrEmpty(_Person.Address)
                && !string.IsNullOrEmpty(_Person.Phone)) 
            {
                if (_Person.Update())
                {
                    _Person.GenderTitle = _Person.GenderID == 1 ? "Male" : "Female";
                    DialogResult res =  MessageBox.Show("Person Updated Successfully", "Updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        EventTrigger?.Invoke(_Person);
                        this.Close();
                    }
                }
            } 
        }
        public AddEditForm()
        {
            InitializeComponent();
        }
        public AddEditForm(clsPerson person)
        {
            InitializeComponent();
            _Person = person;
        }
        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (_Person != null)
            {
                ctrlAddEdit1.HandleDataReceived(_Person);
            }
        }

        // Close current Form
        private void CloseBTN_Click(object sender, EventArgs e)
        {
            EventTrigger?.Invoke(_Person);
            this.Close();
        }

        // Save record to Database
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                if (_Person != null)
                {
                    // Check if the image was changed
                    if (_Person.ImagePath != ctrlAddEdit1.GetImageLocation())
                    {
                        string OldImagePath = _Person.ImagePath;
                        ctrlAddEdit1.SetImagePath(ProfilePictureHelper.SaveProfilePicture(ctrlAddEdit1.GetImage()));
                        UpdatePerson();
                        ProfilePictureHelper.DeleteOldImage(OldImagePath);
                        return;
                    }
                    ctrlAddEdit1.SetImagePath(_Person.ImagePath);
                    UpdatePerson();
                }
                else
                {
                    if (!string.IsNullOrEmpty(ctrlAddEdit1.GetImageLocation()) && ProfilePictureHelper.DefaultProfilePicturePath != ctrlAddEdit1.GetImageLocation()) {
                        ctrlAddEdit1.SetImagePath(ProfilePictureHelper.SaveProfilePicture(ctrlAddEdit1.GetImage()));
                    }
                    AddNewPerson();
                }
            }
        }
    }
}
