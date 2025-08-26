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
    public partial class LicenseHistoryForm : Form
    {
        clsPerson _person;
        int DriverID;
        List<clsFullLicenseDetails> _fullLicenseDetails;
        List<clsInternationalLicense> _internationalLicense;

        private void _ResetDataGridViewSettings()
        {
            // Add ContextMenuStrip to PeopleDataGridView (Right click menu)
            //LocalDataGridView.ContextMenuStrip = ContextMenuStrip;

            // Disable auto-generated columns
            LocalDataGridView.AutoGenerateColumns = false;
            internationalDataGridView1.AutoGenerateColumns = false;
        }
        private void _DisplayRecord(int localNumber,int internationalNumber)
        {
            RecordValue.Text = localNumber.ToString();
            internationalRecordValue.Text = internationalNumber.ToString();
        }
        private void _DisplayLicenses()
        {
            // Get All licenses
            _fullLicenseDetails = clsLicense.GetAllLocalLicenses(_person.PersonID);
            _internationalLicense = clsLicense.GetAllInternationalLicenses(DriverID);

            if (_fullLicenseDetails != null && _fullLicenseDetails.Count > 0)
            {
                LocalDataGridView.DataSource = _fullLicenseDetails;
            }
            if (_internationalLicense != null && _internationalLicense.Count > 0)
            {
                internationalDataGridView1.DataSource = _internationalLicense;
            }

            _DisplayRecord(_fullLicenseDetails.Count, _internationalLicense.Count);
        }

        public LicenseHistoryForm(int personID,int driverID)
        {
            InitializeComponent();
            DriverID = driverID;
           _person = clsPerson.FindPersonByID(personID);

            _ResetDataGridViewSettings();
            _DisplayLicenses();
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.HandleDataReceived(_person);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
