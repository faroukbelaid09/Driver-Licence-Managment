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
    public partial class IssueDrivingLicenseFirstTimeForm : Form
    {
        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;

        clsFullLocalApplication _fullApplication;
        clsApplication _application;
        public IssueDrivingLicenseFirstTimeForm(clsApplication _app,clsFullLocalApplication _fullApp)
        {
            InitializeComponent();

            _application = _app;
            _fullApplication = _fullApp;
        }
        private void ctrlDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadData(_application,_fullApplication);
        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            clsDriver driver = null;
            // First Check if the user is already a driver
            if (!clsDriver.CheckIfDriverExist(_application.ApplicantPersonID))
            {
                driver = clsDriver.Create(_application.ApplicantPersonID, ApplicationState.CurrentUser.UserID,
                DateTime.Now.ToString());
            }

            if (driver != null)
            {
                Console.WriteLine("::::DRIVER CREATED:::");
                clsLicenseClass lincensClass = clsLicenseClass.GetLicenseClassByName(_fullApplication.DrivingClass);
                if (lincensClass != null)
                {
                    Console.WriteLine(":::License Class Recived::::");

                    clsLicense license = clsLicense.Create(_application.ApplicationID, driver.DriverID,
                        lincensClass.LicenseClassID, DateTime.Now.ToString(),
                        DateTime.Now.AddYears(lincensClass.DefaultValidityLength).ToString(),
                        "Empty Notes", lincensClass.ClassFees, true, 1, ApplicationState.CurrentUser.UserID);

                    if (license != null)
                    {
                        MessageBox.Show("License was created successfully!", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        EventTrigger?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("An error happend when creating a License.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        this.Close();
                    }
                }

            }
        }
    }
}
