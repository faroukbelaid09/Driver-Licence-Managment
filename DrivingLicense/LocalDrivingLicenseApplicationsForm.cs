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

        private void _ResetFilterCombo()
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
        
        private void _SetRecord(int record)
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
            _SetRecord(_allLocalApplications.Count);
        }

        public LocalDrivingLicenseApplicationsForm()
        {
            InitializeComponent();
            _ResetFilterCombo();
            _ResetDataGridViewSettings();

            _DisplayLocalApplications();
        }

        private void PagePB_Click(object sender, EventArgs e)
        {

        }

        private void FillterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ResetTextField();
        }

        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseForm frm = new NewLocalDrivingLicenseForm();
            frm.ShowDialog();
        }

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
