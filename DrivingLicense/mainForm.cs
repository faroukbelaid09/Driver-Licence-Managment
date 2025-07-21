using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class mainForm : Form
    {
        public bool SignedOut { get; private set; } = false;
        public mainForm()
        {
            InitializeComponent();

            Console.WriteLine(ApplicationState.CurrentUser.PersonID);
            Console.WriteLine(ApplicationState.CurrentUser.UserName);
            Console.WriteLine(ApplicationState.CurrentUser.IsActive);
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleForm frm = new PeopleForm();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetails frm = new ShowUserDetails(ApplicationState.CurrentUser);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SignedOut = true;
            ApplicationState.CurrentUser = null;
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm(ApplicationState.CurrentUser);
            frm.ShowDialog();
        }

        private void manageApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypesForm frm = new ManageApplicationTypesForm();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypesForm frm = new ManageTestTypesForm();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseForm frm = new NewLocalDrivingLicenseForm();
            frm.ShowDialog();
        }
    }
}