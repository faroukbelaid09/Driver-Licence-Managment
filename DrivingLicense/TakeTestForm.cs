using DrivingLicenseBusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class TakeTestForm : Form
    {
        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;

        clsTest _test;
        clsTestAppointment _testAppointment;
        int TestTypeID;
        int testAppointmentID = -1;
        int testResult = 1;
        string testNote = "";

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
            if (TestName == "vision")
            {
                // Set Test Type Id To 1
                TestTypeID = 1;
                groupBox1.Text = "Vision Test";
                SetScreenImage("vision.png");
            }
            else if (TestName == "writing")
            {
                // Set Test Type Id To 2
                TestTypeID = 2;
                groupBox1.Text = "Writing Test";
                SetScreenImage("writting.png");
            }
            else if (TestName == "driving")
            {
                // Set Test Type Id To 3
                TestTypeID = 3;
                groupBox1.Text = "Driving Test";
                SetScreenImage("driving.png");
            }
        }
        private void LoadData(clsFullLocalApplication fullApp,int PaidFees)
        {
            DLAppValue.Text = fullApp.LocalDrivingLicenseApplicationID.ToString();
            DClassValue.Text = fullApp.DrivingClass;
            NameValue.Text = fullApp.FullName;
            TrialValue.Text = "0";
            FeesValue.Text = PaidFees.ToString();
        }
        private void SaveTestResult()
        {
            if(testResult != -1)
            {
                _test = clsTest.Create(testAppointmentID, testResult, testNote, ApplicationState.CurrentUser.UserID);

                if (_test != null)
                {
                    if (clsTestAppointment.Update(_testAppointment.TestAppointmentID,
                        _testAppointment.TestTypeID, _testAppointment.LocalDrivingLicenseApplicationID,
                        _testAppointment.AppointmentDate, _testAppointment.PaidFees,
                        _testAppointment.CreatedByUserID, 1, _testAppointment.RetakeTestApplicationID))
                    
                    {
                        DialogResult res = MessageBox.Show("A Test was created!", "Success", MessageBoxButtons.OK);
                        if (res == DialogResult.OK)
                        {
                            EventTrigger?.Invoke();
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("An error occured during creating a test.", "Field", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please choose test result", "Error", MessageBoxButtons.OK);
            }
            
        }

        public TakeTestForm(string TestName,clsTestAppointment testAppointment, clsFullLocalApplication fullApp)
        {
            InitializeComponent();

            _testAppointment = testAppointment;
            testAppointmentID = testAppointment.TestAppointmentID;
            CustomizeScreen(TestName);
            LoadData(fullApp, testAppointment.PaidFees);
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            SaveTestResult();
        }

        private void FailRB_CheckedChanged(object sender, EventArgs e)
        {
            if (FailRB.Checked) 
            {
                testResult = 0;
            }
            else
            {
                testResult = 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            testNote = textBox1.Text;
        }

        private void PassRB_CheckedChanged(object sender, EventArgs e)
        {
            if (FailRB.Checked)
            {
                testResult = 0;
            }
            else
            {
                testResult = 1;
            }
        }
    }
}
