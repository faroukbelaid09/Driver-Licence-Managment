﻿using DrivingLicenseBusinessLayer;
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
            int rowIndex = (int)contextMenuStrip.Tag;

            // Access the data of the selected row
            var selectedRow = dataGridView.Rows[rowIndex];
            clsApplicationType app = selectedRow.DataBoundItem as clsApplicationType;

            return app;
        }

        private void GetApplicationTypes()
        {
            _applicationTypes =  clsApplicationType.GetApplicationTypes();
        }


        private void contextMenuStrip_Opening_1(object sender, System.ComponentModel.CancelEventArgs e)
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

        public ManageApplicationTypesForm()
        {
            InitializeComponent();

            _ResetDataGridViewSettings();
            GetApplicationTypes();
            _DisplayApplications();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsApplicationType app = GetTheSelectedApplication();

            if (app != null)
            {
                EditApplitionTypeForm EditFrm = new EditApplitionTypeForm(app);

                EditFrm.EventTrigger += _DisplayApplications;

                EditFrm.ShowDialog();
            }
        }

        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {

        }
    }
}