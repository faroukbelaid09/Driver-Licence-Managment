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
        List<clsFullLicenseDetails> _fullLicenseDetails;

        private void _ResetDataGridViewSettings()
        {
            // Add ContextMenuStrip to PeopleDataGridView (Right click menu)
            //LocalDataGridView.ContextMenuStrip = ContextMenuStrip;

            // Disable auto-generated columns
            LocalDataGridView.AutoGenerateColumns = false;
        }
        private void _DisplayRecord(int number)
        {
            RecordValue.Text = number.ToString();
        }
        private void _DisplayLicenses()
        {
            // Get All licenses
            _fullLicenseDetails = clsLicense.GetAllLocalLicenses(_person.PersonID);

            if (_fullLicenseDetails != null && _fullLicenseDetails.Count > 0)
            {
                LocalDataGridView.DataSource = _fullLicenseDetails;
            }

            _DisplayRecord(_fullLicenseDetails.Count);
        }

        public LicenseHistoryForm(int personID)
        {
            InitializeComponent();

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
    }
}
