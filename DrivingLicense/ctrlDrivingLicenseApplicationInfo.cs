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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        private void LoadLocalDrivingLicenseInfo(clsFullLocalApplication fullLocalApplication)
        {
            DLAppIDValue.Text = fullLocalApplication.LocalDrivingLicenseApplicationID.ToString();
            LicenseClassNameValue.Text = fullLocalApplication.DrivingClass;
            PassedTestsValue.Text = fullLocalApplication.PassedTests.ToString() + "/3";
        }
        
        private void LoadApplicationBasicInfo(clsApplication application)
        {
            AppIDValue.Text = application.ApplicationID.ToString();
            AppStatusValue.Text = application.ApplicationStatus == 1 ? "New" : application.ApplicationStatus == 2 ? "Cancelled" : "Completed";
            AppFeeValue.Text = application.PaidFees.ToString();
            AppTypeValue.Text = application.ApplicationTypeTitle;
            AppApplicantValue.Text = application.ApplicationPersonName;
            DateValue.Text = application.ApplicationDate.ToString();
            StatusDateValue.Text = application.LastStatusDate;
            CreatedByValue.Text = application.ApplicationCreatedByUserName;
        }
        public void LoadData(clsApplication application, clsFullLocalApplication fullLocalApplication)
        {
            LoadLocalDrivingLicenseInfo(fullLocalApplication);
            LoadApplicationBasicInfo(application);
        }
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void ctrlDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
