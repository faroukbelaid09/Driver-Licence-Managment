using DrivingLicenseBusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ScheduleTestForm : Form
    {
        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;
        enum enMode {enAdd,enEdit}
        
        int TestTypeID;
        int LocalDrivingAppID;
        string AppointmentDate;
        int PaidFees;
        int CreatedByUserID;
        int isLocked;
        int RetakeAppID = -1;
        bool isARetake = false;
        int OldTestAppointmentID = -1;
        enMode currentMode = enMode.enAdd;
        clsTestAppointment _appointment;

        private void SetScreenImage(string imageFullName)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(@"D:\Courses\Programing-Advice\Projects\Course 19\images\" + imageFullName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Optional: Controls how image fits
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        private void CustomizeScreen(string TestName)
        {
            if(TestName == "vision")
            {
                // Set Test Type Id To 1
                TestTypeID = 1;
                groupBox1.Text = "Vision Test";
                SetScreenImage("vision.png");
            }
            else if(TestName == "writing")
            {
                // Set Test Type Id To 2
                TestTypeID = 2;
                groupBox1.Text = "Writing Test";
                SetScreenImage("writting.png");
            }
            else if(TestName == "driving")
            {
                // Set Test Type Id To 3
                TestTypeID = 3;
                groupBox1.Text = "Driving Test";
                SetScreenImage("driving.png");
            }
        }
        private int GetTestFees()
        {
            return clsTestType.GetTestFees(TestTypeID);
        }
        private void LoadData(clsFullLocalApplication fullApp)
        {
            DLAppValue.Text = fullApp.LocalDrivingLicenseApplicationID.ToString();
            DClassValue.Text = fullApp.DrivingClass;
            NameValue.Text = fullApp.FullName;
            TrialValue.Text = "0";
            FeesValue.Text = PaidFees.ToString();
        }
        private void ResetRetakeTestForm(bool isRetake)
        {
            if (isRetake)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }
        private void AddNewAppointment()
        {
            clsTestAppointment appointment = clsTestAppointment.Create(TestTypeID, LocalDrivingAppID, 
                AppointmentDate, PaidFees, CreatedByUserID, isLocked, RetakeAppID);

            if (appointment != null)
            {
                if (isARetake)
                {
                    if (clsTestAppointment.UpdateRetakeAppID(OldTestAppointmentID, appointment.TestAppointmentID))
                    {
                        DialogResult res = MessageBox.Show("A Retake appointment was created!", "Success", MessageBoxButtons.OK);
                        if (res == DialogResult.OK)
                        {
                            EventTrigger?.Invoke();
                            this.Close();
                        }
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("An appointment was created!", "Success", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        EventTrigger?.Invoke();
                        this.Close();
                    }
                }

            }
            else
            {
                // Show failed message
                MessageBox.Show("An error happen when creating an appointment.", "Field", MessageBoxButtons.OK);
            }
        }
        private void UpdateAppointment(int TestAppointmentID)
        {
            if(clsTestAppointment.Update(TestAppointmentID,TestTypeID, LocalDrivingAppID,
                dateTimePicker1.Value.ToString(), PaidFees, ApplicationState.CurrentUser.UserID, isLocked, RetakeAppID))
            {
                DialogResult res = MessageBox.Show("An appointment was updated!", "Success", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    EventTrigger?.Invoke();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("An error happen when updating an appointment.", "Field", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public ScheduleTestForm(string TestName, clsApplication app,clsFullLocalApplication fullApp, 
            bool isRetake, clsTestAppointment appointment = null)
        {
            InitializeComponent();

            if (appointment != null) { currentMode = enMode.enEdit; _appointment = appointment; }
            CustomizeScreen(TestName);

            LocalDrivingAppID = fullApp.LocalDrivingLicenseApplicationID;
            AppointmentDate = dateTimePicker1.Value.ToString();
            PaidFees = GetTestFees();
            CreatedByUserID = ApplicationState.CurrentUser.UserID;
            isLocked = 0;

            // If its a retake test we should update the previews test and add add to it the current test id 
            // as a retake test id in it
            isARetake = isRetake;

            ResetRetakeTestForm(isRetake);
            LoadData(fullApp);


        }
        public ScheduleTestForm(string TestName, clsApplication app, clsFullLocalApplication fullApp, bool isRetake,
            int oldTestAppointmentID)
        {
            InitializeComponent();

            CustomizeScreen(TestName);

            LocalDrivingAppID = fullApp.LocalDrivingLicenseApplicationID;
            AppointmentDate = dateTimePicker1.Value.ToString();
            PaidFees = GetTestFees();
            CreatedByUserID = ApplicationState.CurrentUser.UserID;
            isLocked = 0;
            OldTestAppointmentID = oldTestAppointmentID;

            // If its a retake test we should update the previews test and add add to it the current test id 
            // as a retake test id in it
            isARetake = isRetake;

            ResetRetakeTestForm(isRetake);
            LoadData(fullApp);
        }
        private void saveBTN_Click(object sender, EventArgs e)
        {
            if(currentMode == enMode.enAdd)
            {
                AddNewAppointment();
            }
            else
            {
                UpdateAppointment(_appointment.TestAppointmentID);
            }
        }
    }
}