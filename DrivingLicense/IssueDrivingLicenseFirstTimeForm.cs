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
    }
}
