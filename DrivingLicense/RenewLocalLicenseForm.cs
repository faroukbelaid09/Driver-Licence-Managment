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
    public partial class RenewLocalLicenseForm : Form
    {
        const int RENEW_DRIVING_LICENSE = 2;
        private clsFullLicenseDetails _fullLicenseDetails;
        private clsApplicationType _applicationType;
        private clsLicenseClass _licenseClass;
        private clsApplication _renewApplication;
        private clsLicense _renewedLicense;
        private int _licenseID;

        private bool IsExpired(string dateTimeString)
        {
            if (DateTime.TryParse(dateTimeString, out DateTime targetDateTime))
            {
                return targetDateTime < DateTime.Now;
            }

            Console.WriteLine("Invalid datetime format");
            return false;
        }
 
        public RenewLocalLicenseForm()
        {
            InitializeComponent();
        }

        private void RenewLocalLicenseForm_Load(object sender, EventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            _licenseID = Convert.ToInt32(searchTextBox.Text);
            _fullLicenseDetails = clsLicense.GetFullLicenseDetails(_licenseID);

            if (_fullLicenseDetails != null) 
            {
                if (!IsExpired(_fullLicenseDetails.ExpirationDate) || !_fullLicenseDetails.IsActive)
                {
                    MessageBox.Show("You can't renew this license because it's not expired yet or it's not active.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    RenewBTN.Enabled = false;
                }
                else
                {
                    RenewBTN.Enabled = true;
                }

                if (_fullLicenseDetails != null)
                {
                    _applicationType = clsApplicationType.GetApplicationTypeInfo(RENEW_DRIVING_LICENSE);
                    _licenseClass = clsLicenseClass.GetLicenseClassByName(_fullLicenseDetails.ClassName);
                    ctrlDriverLicenseInfo1.LoadData(_fullLicenseDetails);

                    ctrlRenewLicenseApplication1.LoadData(_applicationType.ApplicationFees.ToString(),
                        _licenseClass.ClassFees.ToString(), _fullLicenseDetails.LicenseID.ToString(),
                        DateTime.Now.AddYears(_licenseClass.DefaultValidityLength).ToString());
                }
            }
            else
            {
                MessageBox.Show("A license with this ID does not exist.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RenewBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to renew this license?","Conformation!",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) 
            {
                _renewApplication = clsApplication.Create(_fullLicenseDetails.PersonID, DateTime.Now.ToString(), RENEW_DRIVING_LICENSE,
                2, DateTime.Now.ToString(), (_applicationType.ApplicationFees + _licenseClass.ClassFees),
                ApplicationState.CurrentUser.UserID);

                if (_renewApplication != null)
                {
                    if (clsLicense.DeactivateLicense(_fullLicenseDetails.LicenseID))
                    {
                        _renewedLicense = clsLicense.Create(_renewApplication.ApplicationID, _fullLicenseDetails.DiverID, _licenseClass.LicenseClassID,
                            DateTime.Now.ToString(), DateTime.Now.AddYears(_licenseClass.DefaultValidityLength).ToString(), "",
                            _renewApplication.PaidFees, true, 2, ApplicationState.CurrentUser.UserID);

                        if (_renewedLicense != null)
                        {
                            MessageBox.Show("A license was renewed successfully!", "Success", MessageBoxButtons.OK);
                            RenewBTN.Enabled = false;
                            ShowLicense.Enabled = true;
                            ShowLicenseHistory.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error happened when deactivating the old license.", "Error.", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("An error happened when creating a renew application.", "Error.",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm frm = new LicenseHistoryForm(_fullLicenseDetails.PersonID,_renewedLicense.DriverID);
            frm.ShowDialog();
        }
        private void ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseForm frm = new ShowLicenseForm(_renewApplication.ApplicationID);
            frm.ShowDialog();
        }
    }
}