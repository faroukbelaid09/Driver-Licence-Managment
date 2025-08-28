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
    public partial class ctrlLicenseReplacmentAppInfo : UserControl
    {
        public ctrlLicenseReplacmentAppInfo()
        {
            InitializeComponent();
        }

        public void LoadData(string oldLicenseIDValue,string appFeesValue,
            string licenseReplacmentAppIDValue = "???", string replacedLicenseIDValue = "???")
        {
            LicenseReplacmentAppIDValue.Text = licenseReplacmentAppIDValue;
            AppDateValue.Text = DateTime.Now.ToString();
            AppFeesValue.Text = appFeesValue;
            ReplacedLicenseIDValue.Text = replacedLicenseIDValue;
            OldLicenseIDValue.Text = oldLicenseIDValue;
            CreatedByValue.Text = ApplicationState.CurrentUser.UserName;
        }
    }
}
