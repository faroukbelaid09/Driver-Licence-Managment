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
    public partial class ScheduleAppointmentForm : Form
    {
        private clsApplication _application;
        private clsFullLocalApplication _fullLocalApplication;
        private List<clsTestAppointment> _testAppointment;

        private void SetScreenImage(string imageFullName)
        {
            try
            {
                pictureBox.Image = Image.FromFile(@"D:\Courses\Programing-Advice\Projects\Course 19\images\" + imageFullName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Optional: Controls how image fits
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        private void _CustomizeScreen(string testName)
        {
            if(testName == "vision")
            {
                Title.Text = "Vision Test Appointment";
                SetScreenImage("vision.png");
            }
            else if (testName == "writing")
            {
                Title.Text = "Writing Test Appointment";
                SetScreenImage("writting.png");
            }
            else if (testName == "driving")
            {
                Title.Text = "Driving Test Appointment";
                SetScreenImage("driving.png");
            }
        }
        private void _GetAllTestAppointments(string testName,int localDrivingAppID)
        {
            if (testName == "vision")
            {
                _testAppointment = clsTestAppointment.GetVisionTests(localDrivingAppID);
            }
            else if (testName == "writing")
            {
                _testAppointment = clsTestAppointment.GetWrittingTests(localDrivingAppID);
            }
            else if (testName == "driving")
            {
                _testAppointment = clsTestAppointment.GetStreetTests(localDrivingAppID);
            }
        }
        public ScheduleAppointmentForm(string testName,clsApplication application,
            clsFullLocalApplication fullLocalApplication)
        {
            InitializeComponent();
            _CustomizeScreen(testName);

            _application = application;
            _fullLocalApplication = fullLocalApplication;

            _GetAllTestAppointments(testName,_fullLocalApplication.LocalDrivingLicenseApplicationID);

            TestAppointmentsGridView.DataSource = _testAppointment;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadData(_application,_fullLocalApplication);
        }
    }
}
