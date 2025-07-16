using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ManageTestTypesForm : Form
    {
        
        private List<clsTestType> _testTypes = null;

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
        private void _DisplayTests()
        {
            // Get All people
            _testTypes = clsTestType.GetTestTypes();

            if (_testTypes != null && _testTypes.Count > 0)
            {
                dataGridView.DataSource = _testTypes;
            }

            _DisplayRecord(_testTypes.Count);
        }

        // RETURN THE SELECTED TEST FROM THE MENU
        private clsTestType GetTheSelectedTest()
        {
            // Get the selected row index from the ContextMenuStrip's Tag
            int rowIndex = (int)contextMenuStrip.Tag;

            // Access the data of the selected row
            var selectedRow = dataGridView.Rows[rowIndex];
            clsTestType test = selectedRow.DataBoundItem as clsTestType;

            return test;
        }

        private void GetTestTypes()
        {
            _testTypes = clsTestType.GetTestTypes();
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Get the mouse position relative to the DataGridView
            var hitTest = dataGridView.HitTest(dataGridView.PointToClient(Cursor.Position).X,
                dataGridView.PointToClient(Cursor.Position).Y);

            // Check if the right-click was on a row
            if (hitTest.RowIndex >= 0)
            {
                // Store the selected row index in the ContextMenuStrip's Tag
                contextMenuStrip.Tag = hitTest.RowIndex;
            }
            else
            {
                // Cancel the context menu if the right-click was not on a row
                e.Cancel = true;
            }
        }

        public ManageTestTypesForm()
        {
            InitializeComponent();


            _ResetDataGridViewSettings();
            GetTestTypes();
            _DisplayTests();

        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTestType test = GetTheSelectedTest();

            if (test != null)
            {
                EditTestTypeForm EditFrm = new EditTestTypeForm(test);

                EditFrm.EventTrigger += _DisplayTests;

                EditFrm.ShowDialog();
            }
        }
    }
}
