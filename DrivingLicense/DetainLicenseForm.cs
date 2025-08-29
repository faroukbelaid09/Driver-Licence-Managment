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
    public partial class DetainLicenseForm : Form
    {
        private int _licenseID;
        private clsFullLicenseDetails _fullLicenseDetails;
        private clsDetainLicense _detainedLicense;
        public DetainLicenseForm()
        {
            InitializeComponent();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            _licenseID = Convert.ToInt32(searchTextBox.Text);
            _fullLicenseDetails = clsLicense.GetFullLicenseDetails(_licenseID);

            if (_fullLicenseDetails != null) 
            {
                if (_fullLicenseDetails.IsActive && _fullLicenseDetails.IsDetained == "No")
                {
                    DeatinBTN.Enabled = true;
                    ctrlDriverLicenseInfo1.LoadData(_fullLicenseDetails);
                    ctrlDetainInfo1.LoadData(_licenseID.ToString());
                }
                else
                {
                    MessageBox.Show("License should be active and not detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DeatinBTN.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("A license with this ID does not exist.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DeatinBTN.Enabled = false;
                DeatinBTN.Enabled = false;
            }
        }

        private void DeatinBTN_Click(object sender, EventArgs e)
        {
            int fineAmount = -1;
            fineAmount = ctrlDetainInfo1.GetFineAmount();

            if(fineAmount != -1)
            {
                _detainedLicense = clsDetainLicense.DetainLicense(_licenseID,DateTime.Now.ToString(),fineAmount,
                    ApplicationState.CurrentUser.UserID,0,"",-1,-1);

                if (_detainedLicense != null)
                {
                    MessageBox.Show("License was detained.", "Done", MessageBoxButtons.OK);
                    DeatinBTN.Enabled = false;
                    ShowLicense.Enabled = true;
                    ShowLicenseHistory.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid fine amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseForm frm = new ShowLicenseForm(_fullLicenseDetails.ApplicationID);
            frm.ShowDialog();
        }

        private void ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryForm frm = new LicenseHistoryForm(_fullLicenseDetails.PersonID,_fullLicenseDetails.DiverID);
            frm.ShowDialog();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
