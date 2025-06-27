using DrivingLicenseBusinessLayer;
using System;
using System.Windows.Forms;
using System.IO;


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

        private bool Authenticate(string username,string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)) {
                clsUser currentUser = clsUser.FindUserByUserNameAndPassword(username, password);
                if (currentUser != null)
                {
                    ApplicationState.CurrentUser = currentUser;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error","User was not found.",MessageBoxButtons.OK);
                }
            }
            return false;
        }
        
        private bool SaveUserLoginInfo(string username,string password)
        {
            bool saved = false;

            // Path
            string basePath = @"D:\Courses\Programing-Advice\Projects\Course 19";
            string filePath = Path.Combine(basePath, "LoginInfo.txt");

            // Write an array of lines
            string[] lines = { username, password};
            File.WriteAllLines(filePath, lines);

            return saved;
        }
        
        private void GetSavedUserInfo()
        {
            string filePath = @"D:\Courses\Programing-Advice\Projects\Course 19\LoginInfo.txt";

            // Read all lines into an array
            string[] allLines = File.ReadAllLines(filePath);

            // Store each line in separate variables
            userInput.username = allLines[0].Trim();
            userInput.password = allLines[1].Trim();
        }
        
        private void LoadSavedInfoToForm()
        {
            UsernameTB.Text = userInput.username;
            PasswordTB.Text = userInput.password;
        }
        public LoginForm()
        {
            InitializeComponent();

            GetSavedUserInfo();
            if (!string.IsNullOrEmpty(userInput.username) || !string.IsNullOrEmpty(userInput.password))
            {
                LoadSavedInfoToForm();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                GetUserInput();

                if (userInput.isRemembered)
                {
                    SaveUserLoginInfo(userInput.username,userInput.password);
                }
                else
                {
                    SaveUserLoginInfo("", "");
                }

                if (Authenticate(userInput.username, userInput.password))
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
