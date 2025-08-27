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
    public partial class ctrlRenewLicenseApplication : UserControl
    {
        public ctrlRenewLicenseApplication()
        {
            InitializeComponent();
        }

        public void LoadData(string appFee,string licenseFees,string oldLicenseID,string expDate,
            string renewAppID = "???",string renewLicenseID = "???")
        {
            RenewAppIDValue.Text = renewAppID;
            AppDateValue.Text = DateTime.Now.ToString();
            IssueDateValue.Text = DateTime.Now.ToString();
            AppFeeValue.Text = appFee;
            LicenseFeeValue.Text = licenseFees;
            RenewLicenseValue.Text = renewLicenseID;
            OldLicenseValue.Text = oldLicenseID;
            ExpDateValue.Text = expDate;
            CreatedbyValue.Text = ApplicationState.CurrentUser.UserName;
            TotalFeesValue.Text = (Convert.ToInt32(appFee)+Convert.ToInt32(licenseFees)).ToString();
        }
    }
}