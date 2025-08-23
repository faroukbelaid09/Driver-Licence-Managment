using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ShowLicenseForm : Form
    {

        private clsFullLicenseDetails _fullLicenseDetails;
        private int GetLicenseID(int appID)
        {
            return clsLicense.GetLicenseID(appID);
        }
        private clsFullLicenseDetails GetFullLicenseInfo(int licenseID)
        {
            return clsLicense.GetFullLicenseDetails(licenseID);
        }

        private void LoadDate(clsFullLicenseDetails fullLicernse)
        {
            ClassValue.Text = fullLicernse.ClassName;
            NameValue.Text = fullLicernse.FullName;
            LicenseIDValue.Text = fullLicernse.LicenseID.ToString();
            IsActiveValue.Text = fullLicernse.IsActive.ToString();
            NationalNoValue.Text = fullLicernse.NationalNo;
            DateOfBirthValue.Text = fullLicernse.DateOfBirth;
            GenderValue.Text = fullLicernse.Gender;
            DriverIDValue.Text = fullLicernse.DiverID.ToString();
            IssueDateValue.Text = fullLicernse.IssueDate;
            ExpirationDateValue.Text = fullLicernse.ExpirationDate;
            IssueReasonValue.Text = fullLicernse.IssueReason == 1 ? "First Time" : "Others";
            IsDetainedValue.Text = fullLicernse.IsDetained.ToString();
            NotesValue.Text = fullLicernse.Notes;
        }

        public ShowLicenseForm(int appID)
        {
            InitializeComponent();

            _fullLicenseDetails = GetFullLicenseInfo(GetLicenseID(appID));
            
            if(_fullLicenseDetails != null) 
            {
                LoadDate(_fullLicenseDetails);
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
