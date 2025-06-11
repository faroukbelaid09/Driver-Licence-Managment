using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class mainForm : Form
    {
        clsPerson person1;
        public mainForm()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleForm frm = new PeopleForm();
            frm.ShowDialog();
        }
    }
}
