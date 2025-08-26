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
    public partial class ShowDriversForm : Form
    {
        List<clsDriver> _drivers;

        private void _ResetDataGridViewSettings()
        {
            // Disable auto-generated columns
            driverDataGridView.AutoGenerateColumns = false;
        }

        private List<clsDriver> GetAllDrivers()
        {
            return clsDriver.GetAllDrivers();
        }

        private void _DisplayDrivers()
        {
            _drivers = GetAllDrivers();

            if (_drivers != null && _drivers.Count > 0)
            {
                driverDataGridView.DataSource = _drivers;
            }

            _DisplayRecord(_drivers.Count);
        }

        private void _DisplayRecord(int number)
        {
            recordValue.Text = number.ToString();
        }
        public ShowDriversForm()
        {
            InitializeComponent();

            _ResetDataGridViewSettings();
            _DisplayDrivers();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
