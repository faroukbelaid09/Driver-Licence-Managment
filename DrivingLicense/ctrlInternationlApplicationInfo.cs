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
    public partial class ctrlInternationlApplicationInfo : UserControl
    {
        public ctrlInternationlApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadDate(int localLicenseID,int fees, string InternationalAppID = "???", 
            string InternationalLicenseID = "???")
        {
            InternationalAppIDValue.Text = InternationalAppID;
            AppDateValue.Text = DateTime.Now.ToString();
            IssueDateValue.Text = DateTime.Now.ToString();
            FeesValue.Text = fees.ToString();
            InternationalLicenseIDValue.Text = InternationalLicenseID;
            LocalLicenseIDValue.Text = localLicenseID.ToString();
            ExpDateValue.Text = DateTime.Now.AddYears(1).ToString();
            CreatedByValue.Text = ApplicationState.CurrentUser.UserName;
        }
    }
}