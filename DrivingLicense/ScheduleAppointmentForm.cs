using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DrivingLicense
{
    public partial class ScheduleAppointmentForm : Form
    {
        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;

        private clsApplication _application;
        private clsFullLocalApplication _fullLocalApplication;
        private List<clsTestAppointment> _testAppointment;
        private string _testName = "";

        private void _ResetDataGridViewSettings()
        {
            // Add ContextMenuStrip to PeopleDataGridView (Right click menu)
            TestAppointmentsGridView.ContextMenuStrip = ContextMenuStrip;

            // Disable auto-generated columns
            TestAppointmentsGridView.AutoGenerateColumns = false;
        }
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
            _testName = testName;
            if (testName == "vision")
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
                _testAppointment = clsTestAppointment.GetWritingTests(localDrivingAppID);
            }
            else if (testName == "driving")
            {
                _testAppointment = clsTestAppointment.GetStreetTests(localDrivingAppID);
            }
        }
        private void _DisplayTestApp()
        {
            _GetAllTestAppointments(_testName, _fullLocalApplication.LocalDrivingLicenseApplicationID);
            TestAppointmentsGridView.DataSource = _testAppointment;
            _DisplayRecord(_testAppointment.Count());
        }
        private void _DisplayRecord(int record)
        {
            RecordValue.Text = record.ToString();
        }

        // RETURN THE SELECTED APPOINTMENT FROM THE MENU
        private clsTestAppointment GetTheSelectedAppointment()
        {
            // Get the selected row index from the ContextMenuStrip's Tag
            int rowIndex = (int)ContextMenuStrip.Tag;

            // Access the data of the selected row
            var selectedRow = TestAppointmentsGridView.Rows[rowIndex];
            clsTestAppointment appointment = selectedRow.DataBoundItem as clsTestAppointment;

            return appointment;
        }

        private void contextMenuStrip1_Opening_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Get the mouse position relative to the DataGridView
            var hitTest = TestAppointmentsGridView.HitTest(TestAppointmentsGridView.PointToClient(Cursor.Position).X,
                TestAppointmentsGridView.PointToClient(Cursor.Position).Y);

            // Check if the right-click was on a row
            if (hitTest.RowIndex >= 0)
            {
                // Store the selected row index in the ContextMenuStrip's Tag
                ContextMenuStrip.Tag = hitTest.RowIndex;
                clsTestAppointment _appointment = GetTheSelectedAppointment();
                if (_appointment.IsLocked != 0) 
                {
                    ContextMenuStrip.Enabled = false;
                }
                else
                {
                    ContextMenuStrip.Enabled = true;
                }
            }
            else
            {
                // Cancel the context menu if the right-click was not on a row
                e.Cancel = true;
            }
        }
        public ScheduleAppointmentForm(string testName,clsApplication application,
            clsFullLocalApplication fullLocalApplication)
        {
            InitializeComponent();

            _CustomizeScreen(testName);

            _application = application;
            _fullLocalApplication = fullLocalApplication;

            _ResetDataGridViewSettings();
            _DisplayTestApp();

        }

        private void ctrlDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadData(_application,_fullLocalApplication);
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            EventTrigger?.Invoke();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Check if an appointment is already set
            //      - appointments exist + is not locked => we don't allow new appointments
            //      -       //       //  + is locked
            //          - result is True                 => we don't allow new appointments
            //          - result is false                => we allow new appointments
            //      - appointment doesn't exist          => we allow new appointments

            if (_testAppointment.Count() == 0) 
            {
                // Create new appointment
                ScheduleTestForm frm = new ScheduleTestForm(_testName,_application,_fullLocalApplication,false);
                frm.EventTrigger += _DisplayTestApp;
                frm.ShowDialog();
            }
            else
            {
                if (_testAppointment[_testAppointment.Count() - 1].IsLocked == 0)
                {
                    MessageBox.Show("Appointments already exist!", "Appointments", 
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                 
                // Appointment exist but locked
                // We check the appointment test result
                if (!clsTestAppointment.CheckTestAppointmentResult(_testAppointment[_testAppointment.Count() - 1].TestAppointmentID))
                {
                    // Create a Retake Test Appointment
                    // MessageBox.Show("You can create an Appointments!", "Appointments", MessageBoxButtons.OK);

                    ScheduleTestForm frm = new ScheduleTestForm(_testName,_application, _fullLocalApplication, true, 
                        _testAppointment[_testAppointment.Count() - 1].TestAppointmentID);
                    frm.ShowDialog();
                }
                else
                {
                    // User already passed the test
                    MessageBox.Show("Appointments already exist!","Appointments",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTestAppointment selectedAppointment = GetTheSelectedAppointment();
            
            ScheduleTestForm frm = new ScheduleTestForm(_testName, _application, _fullLocalApplication, 
                false, selectedAppointment);
            
            frm.EventTrigger += _DisplayTestApp;
            frm.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTestAppointment selectedAppointment = GetTheSelectedAppointment();



            TakeTestForm frm = new TakeTestForm(_testName, selectedAppointment,
                _fullLocalApplication);

            frm.EventTrigger += _DisplayTestApp;
            frm.ShowDialog();
        }
    }
}