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
        public ScheduleAppointmentForm(string testName)
        {
            InitializeComponent();
            _CustomizeScreen(testName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
