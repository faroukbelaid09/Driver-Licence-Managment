using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class LoginForm : Form
    {
        public struct UserInput
        {
            public string username;
            public string password;
            public bool isRemembered;
        }
        public UserInput userInput;
        private void GetUserInput()
        {
            userInput.username = UsernameTB.Text.Trim();
            userInput.password = PasswordTB.Text.Trim();
            userInput.isRemembered = RemeberMeCB.Checked;
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

        private bool Authenticate(string username,string password,bool isRemembered)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)) {
                clsUser currentUser = clsUser.FindUserByUserNameAndPassword(username, password);
                if (currentUser != null)
                {
                    ApplicationState.CurrentUser = currentUser;
                    return true;
                }
            }
            return false;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                GetUserInput();
                if (Authenticate(userInput.username, userInput.password, userInput.isRemembered))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void UsernameTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(UsernameTB);
        }

        private void PasswordTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _EmptyValidator(PasswordTB);
        }
    }
}
