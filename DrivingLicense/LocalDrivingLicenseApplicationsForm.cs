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
    public partial class LocalDrivingLicenseApplicationsForm : Form
    {
        private List<clsFullLocalApplication> _allLocalApplications;
        private List<clsFullLocalApplication> _filteredLocalApplications;
        private enum FilterOptions{ LocalAppID = 1, NationalNo = 2, FullName = 3, Status = 4}
        
        
        void _ResetFilterCombo()
        {
            FillterCB.SelectedIndex = 0;
        }

        private void _ResetTextField()
        {
            if (FillterCB.SelectedIndex == 0)
            {
                FillterTB.Visible = false;
            }
            else
            {
                FillterTB.Visible = true;
            }
        }
        
        private void _DisplayRecord(int record)
        {
            RecordValue.Text = record.ToString();
        }

        private void _ResetDataGridViewSettings()
        {
            // Add ContextMenuStrip to LocalAppDataGridView (Right click menu)
            LocalAppDataGridView.ContextMenuStrip = contextMenuStrip;

            // Disable auto-generated columns
            LocalAppDataGridView.AutoGenerateColumns = false;
        }

        private void _DisplayLocalApplications()
        {
            _allLocalApplications = clsApplication.GetAllLocalApplications();

            if(_allLocalApplications != null && _allLocalApplications.Count > 0)
            {
                LocalAppDataGridView.DataSource = clsApplication.GetAllLocalApplications();

            }
            _DisplayRecord(_allLocalApplications.Count);
        }

        // DISPLAY FILLTRED PEOPLE
        private void _DisplayFilteredApplications()
        {
            if (_filteredLocalApplications != null && _filteredLocalApplications.Count > 0)
            {
                LocalAppDataGridView.DataSource = null;
                LocalAppDataGridView.DataSource = _filteredLocalApplications;
            }
            else
            {
                LocalAppDataGridView.DataSource = null;
            }
        }

        public LocalDrivingLicenseApplicationsForm()
        {
            InitializeComponent();
            _ResetFilterCombo();
            _ResetDataGridViewSettings();

            _DisplayLocalApplications();
        }

        private void _Filter(string FilterText, FilterOptions filterOption)
        {
            switch (filterOption)
            {
                case FilterOptions.LocalAppID:
                    _filteredLocalApplications = _allLocalApplications.Where(app => app.LocalDrivingLicenseApplicationID.ToString().ToLower().Equals(FilterText)).ToList();
                    break;
                case FilterOptions.NationalNo:
                    _filteredLocalApplications = _allLocalApplications.Where(app => app.NationalNo.ToString().ToLower().Contains(FilterText)).ToList();
                    break;
                case FilterOptions.FullName:
                    _filteredLocalApplications = _allLocalApplications.Where(app => app.FullName.ToString().ToLower().Contains(FilterText)).ToList();
                    break;
                case FilterOptions.Status:
                    _filteredLocalApplications = _allLocalApplications.Where(app => app.ApplicationStatus.ToString().ToLower().Contains(FilterText)).ToList();
                    break;
                default:
                    break;
            }
        }
        private void ApplyFilter(string filterText, FilterOptions FilterOption)
        {
            // Apply the filter
            if (string.IsNullOrEmpty(filterText))
            {
                // If the filter text is empty, show all data
                LocalAppDataGridView.DataSource = _allLocalApplications;
                _DisplayRecord(_allLocalApplications.Count);
            }
            else
            {
                _Filter(filterText, FilterOption);
                _DisplayFilteredApplications();
                _DisplayRecord(_filteredLocalApplications.Count);
            }
        }
        private void FillterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ResetTextField();
        }

        private void PagePB_Click(object sender, EventArgs e)
        {

        }

        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseForm frm = new NewLocalDrivingLicenseForm();
            frm.EventTrigger += _DisplayLocalApplications;
            frm.ShowDialog();
        }

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillterTB_TextChanged(object sender, EventArgs e)
        {
            string filterText = FillterTB.Text.Trim().ToLower();

            switch (FillterCB.SelectedIndex)
            {
                case 1:
                    // Apply the filter
                    ApplyFilter(filterText, FilterOptions.LocalAppID);
                    break;
                case 2:
                    // Apply the filter
                    ApplyFilter(filterText, FilterOptions.NationalNo);
                    break;
                case 3:
                    // Apply the filter
                    ApplyFilter(filterText, FilterOptions.FullName);
                    break;
                case 4:
                    // Apply the filter
                    ApplyFilter(filterText, FilterOptions.Status);
                    break;
                default:
                    break;
            }
        }
    }
}
