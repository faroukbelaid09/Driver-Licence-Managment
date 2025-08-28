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
    public partial class ctrlDetainInfo : UserControl
    {
        public ctrlDetainInfo()
        {
            InitializeComponent();
        }

        public void LoadData(string licenseIDValue, string detainIDValue = "???")
        {
            DetainIDValue.Text = detainIDValue;
            DetainDateValue.Text = DateTime.Now.ToString();
            LicenseIDValue.Text = licenseIDValue;
            CreatedByValue.Text = ApplicationState.CurrentUser.UserName;
        }
    }
}
