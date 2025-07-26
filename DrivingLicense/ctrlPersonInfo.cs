using DrivingLicenseBusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ctrlPersonInfo : UserControl
    {
        private clsPerson _Person;

        private void SetPersonID(string personID)
        {
            PersonIDValue.Text = personID;
        }
        private void SetFullName(string firstName, string lastName)
        {
            FullNameValue.Text = firstName + " " + lastName;
        }
        private void SetNationalNo(string nationalNo)
        {
            NationalNoValue.Text = nationalNo;
        }
        private void SetDateOfBirth(DateTime dateofbirth)
        {
            DateOFBirthValue.Text = dateofbirth.Day + "/" + dateofbirth.Month + "/" + dateofbirth.Year;
        }
        private void SetGender(string gender)
        {
            GenderValue.Text = gender;
        }
        private void SetPhone(string phone)
        {
            PhoneValue.Text = phone;
        }
        private void SetEmail(string email)
        {
            EmailValue.Text = email;
        }
        private void SetCountry(int countryID)
        {
            CountryValue.Text = clsPerson.GetPersonCountryName(countryID);
        }
        private void SetAddress(string address)
        {
            AddressValue.Text = address;
        }
        private void SetProfilePicture(Bitmap image)
        {
            ProfilePB.Image = image;
        }
        
        
        public ctrlPersonInfo()
        { 
            InitializeComponent();

            // Enable/Disable profile editing
            if(_Person == null)
            {
                EditInfoLinkLabel.Enabled = false;
            }
            else
            {
                EditInfoLinkLabel.Enabled = true;
            }
        }

        // Event handler to receive data
        public void HandleDataReceived(clsPerson person)
        {
            _Person = person;

            SetPersonID(_Person.PersonID.ToString());
            SetFullName(_Person.FirstName, _Person.LastName);
            SetNationalNo(_Person.NationalNo);
            SetDateOfBirth(_Person.DateOfBirth);
            SetGender(_Person.GenderTitle);
            SetPhone(_Person.Phone);
            SetEmail(_Person.Email);
            SetCountry(_Person.CountryID-1);
            SetAddress(_Person.Address);
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                Console.WriteLine(_Person.ImagePath);
                SetProfilePicture((Bitmap)ProfilePictureHelper.LoadProfilePicture(_Person.ImagePath));
            }

            // enable editing
            EditInfoLinkLabel.Enabled = true;
        }

        private void EditInfoLinkLabel_Click(object sender, EventArgs e)
        {
            AddEditForm EditForm = new AddEditForm(_Person);
            EditForm.EventTrigger += HandleDataReceived;
            EditForm.ShowDialog();
        }
    }
}
