using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ChangePasswordForm : Form
    {

        public delegate void TriggerEventHandler();
        public event TriggerEventHandler EventTrigger;

        private clsUser _user;
        private clsPerson _person;

        clsPerson GetAssociatedPerson(int personID)
        {
            return clsPerson.FindPersonByID(personID);
        }

        private void UpdateUserLoginInfo(clsUser user)
        {
            UserIDValue.Text = user.UserID.ToString();
            UserNameValue.Text = user.UserName.ToString();
            IsActiveValue.Text = user.IsActive ? "Yes" : "No";

            CurrentPasswordTB.Text = user.Password;
        }

        private void _EmptyValidator(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Focus();
                errorProvider1.SetError(textBox, "Cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }
        public ChangePasswordForm(clsUser user)
        {
            InitializeComponent();

            _user = user;
            _person = GetAssociatedPerson(user.PersonID);
            UpdateUserLoginInfo(_user);
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.HandleDataReceived(_person);
        }

        private void SaveFormBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string Password = NewPasswordTB.Text.Trim();
                string ConfirmPassword = ConfirmNewPasswordTB.Text.Trim();

                if(!string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(ConfirmPassword) && (Password == ConfirmPassword))
                {
                    _user.Password = ConfirmPassword;

                    if(_user.Update())
                    {
                        DialogResult res = MessageBox.Show("User updated successfully!", "Update User!", MessageBoxButtons.OK);
                        if (res == DialogResult.OK)
                        {
                            EventTrigger?.Invoke();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error occured when updating user.", "Update User!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your password correctly!", "Incorrect Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void CloseFormBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrentPasswordTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(CurrentPasswordTB);
        }

        private void NewPasswordTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(NewPasswordTB);
        }

        private void ConfirmNewPasswordTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(ConfirmNewPasswordTB);
        }
    }
}
