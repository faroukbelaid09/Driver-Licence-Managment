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
    public partial class ShowApplicationInfoForm : Form
    {
        private clsFullLocalApplication _fullapp;
        private clsApplication _app;
        public ShowApplicationInfoForm(clsApplication app,clsFullLocalApplication fullLocalApp)
        {
            InitializeComponent();
            _app = app;
            _fullapp = fullLocalApp;
        }

        private void ctrlDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadData(_app,_fullapp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
