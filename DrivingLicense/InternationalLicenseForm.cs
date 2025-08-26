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
    public partial class InternationalLicenseForm : Form
    {
        const int NEW_INTERNATIONAL_APPLICATION = 6;
        private clsFullLicenseDetails _fullLicenseDetails;
        private clsApplicationType _applicationType;
        private clsApplication _application;
        private clsInternationalLicense _internationalLicense;
        private int _licenseID;
        public InternationalLicenseForm()
        {
            InitializeComponent();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            _licenseID = Convert.ToInt32(searchTextBox.Text);
            _fullLicenseDetails = clsLicense.GetFullLicenseDetails(_licenseID);
            if (_fullLicenseDetails != null) 
            {
                _applicationType = clsApplicationType.GetApplicationTypeInfo(NEW_INTERNATIONAL_APPLICATION);
                ctrlDriverLicenseInfo1.LoadData(_fullLicenseDetails);
                ctrlInternationlApplicationInfo1.LoadDate(_licenseID,_applicationType.ApplicationFees);
            }
            else
            {
                MessageBox.Show("A license with this ID does not exist.","Error",MessageBoxButtons.OK);
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if(!clsInternationalLicense.CheckIfDriverHasInternationalLicens(_fullLicenseDetails.DiverID,
                _fullLicenseDetails.LicenseID))
            {
                _application = clsApplication.Create(_fullLicenseDetails.PersonID, DateTime.Now.ToString(),
                _applicationType.ApplicationTypeID, 1, DateTime.Now.ToString(), _applicationType.ApplicationFees,
                ApplicationState.CurrentUser.UserID);

                if (_application != null)
                {
                    _internationalLicense = clsInternationalLicense.Create(_application.ApplicationID, _fullLicenseDetails.DiverID,
                        _fullLicenseDetails.LicenseID, DateTime.Now.ToString(), DateTime.Now.AddYears(1).ToString(),
                        1, ApplicationState.CurrentUser.UserID);

                    if (_internationalLicense != null)
                    {
                        MessageBox.Show("An international license was created!", "Success", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("This driver already have an international license.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm frm = new LicenseHistoryForm(_fullLicenseDetails.PersonID,
                _fullLicenseDetails.DiverID);
            frm.ShowDialog();
        }
    }
}