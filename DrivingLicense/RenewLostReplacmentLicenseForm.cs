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
    public partial class RenewLostReplacmentLicenseForm : Form
    {
        private const int REPLACEMENT_FOR_LOST = 3;
        private const int REPLACEMENT_FOR_DAMAGED = 4;

        private int _licenseID;
        private int _replacementType = -1;
        private clsFullLicenseDetails _fullLicenseDetails;
        private clsApplicationType _applicationType;
        private clsApplication _replacementApplication;
        private clsLicenseClass _licenseClass;
        private clsLicense _renewedLicense;
        public RenewLostReplacmentLicenseForm()
        {
            InitializeComponent();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            _licenseID = Convert.ToInt32(searchTextBox.Text);
            _replacementType = DamagedRB.Checked ? REPLACEMENT_FOR_DAMAGED : REPLACEMENT_FOR_LOST;
            _fullLicenseDetails = clsLicense.GetFullLicenseDetails(_licenseID);
            _licenseClass = clsLicenseClass.GetLicenseClassByName(_fullLicenseDetails.ClassName);


            if (_fullLicenseDetails != null) 
            {
                if (_fullLicenseDetails.IsActive) 
                {
                    RenewBTN.Enabled = true;

                    ctrlDriverLicenseInfo1.LoadData(_fullLicenseDetails);

                    _applicationType = clsApplicationType.GetApplicationTypeInfo(_replacementType);

                    ctrlLicenseReplacmentAppInfo1.LoadData(_fullLicenseDetails.LicenseID.ToString(),
                        _applicationType.ApplicationFees.ToString());
                }
                else
                {
                    MessageBox.Show("A license with this ID is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RenewBTN.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("A license with this ID does not exists.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                RenewBTN.Enabled = false;
            }
        }

        private void DamagedRB_CheckedChanged(object sender, EventArgs e)
        {
            _replacementType = REPLACEMENT_FOR_DAMAGED;
        }

        private void LostRB_CheckedChanged(object sender, EventArgs e)
        {
            _replacementType = REPLACEMENT_FOR_LOST;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenewBTN_Click(object sender, EventArgs e)
        {
            _replacementApplication = clsApplication.Create(_fullLicenseDetails.PersonID,DateTime.Now.ToString(),
                _replacementType,2,DateTime.Now.ToString(),_applicationType.ApplicationFees,ApplicationState.CurrentUser.UserID);

            if (_replacementApplication != null) 
            {
                if (clsLicense.DeactivateLicense(_licenseID)) 
                {
                    _renewedLicense = clsLicense.Create(_replacementApplication.ApplicationID, _fullLicenseDetails.DiverID,
                    _licenseClass.LicenseClassID, DateTime.Now.ToString(), DateTime.Now.AddYears(_licenseClass.DefaultValidityLength).ToString(),
                    "", _replacementApplication.PaidFees, true, _replacementType, ApplicationState.CurrentUser.UserID);

                    if (_renewedLicense != null)
                    {
                        MessageBox.Show("A replacement license has been issued!", "Done", MessageBoxButtons.OK);
                        RenewBTN.Enabled = false;
                        ShowLicenseHistory.Enabled = true;
                        ShowLicense.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("An error happaned when issueing a replacement license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RenewBTN.Enabled = false;
                    }
                }
            }
        }

        private void ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm frm = new LicenseHistoryForm(_fullLicenseDetails.PersonID,_fullLicenseDetails.DiverID);
            frm.ShowDialog();
        }

        private void ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseForm frm = new ShowLicenseForm(_replacementApplication.ApplicationID);
            frm.ShowDialog();
        }
    }
}