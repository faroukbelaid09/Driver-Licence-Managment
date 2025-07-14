using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ManageApplicationTypesForm : Form
    {

        private List<clsApplicationType> _applicationTypes = null;

        private void _ResetDataGridViewSettings()
        {
            // Add ContextMenuStrip to PeopleDataGridView (Right click menu)
            dataGridView.ContextMenuStrip = contextMenuStrip;

            // Disable auto-generated columns
            dataGridView.AutoGenerateColumns = false;
        }

        private void _DisplayRecord(int record)
        {
            RecordValue.Text = record.ToString();
        }

        // GET ALL PEOPLE
        private void _DisplayApplications()
        {
            // Get All people
            _applicationTypes = clsApplicationType.GetApplicationTypes();

            if (_applicationTypes != null && _applicationTypes.Count > 0)
            {
                dataGridView.DataSource = _applicationTypes;
            }

            _DisplayRecord(_applicationTypes.Count);
        }

        // RETURN THE SELECTED APPLICATION FROM THE MENU
        private clsApplicationType GetTheSelectedApplication()
        {
            // Get the selected row index from the ContextMenuStrip's Tag
            int rowIndex = (int)ContextMenuStrip.Tag;

            // Access the data of the selected row
            var selectedRow = dataGridView.Rows[rowIndex];
            clsApplicationType app = selectedRow.DataBoundItem as clsApplicationType;

            return app;
        }

        private void GetApplicationTypes()
        {
            _applicationTypes =  clsApplicationType.GetApplicationTypes();
        }

        public ManageApplicationTypesForm()
        {
            InitializeComponent();

            _ResetDataGridViewSettings();
            GetApplicationTypes();
            _DisplayApplications();
        }

        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {

        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsApplicationType app = GetTheSelectedApplication();
        }
    }
}