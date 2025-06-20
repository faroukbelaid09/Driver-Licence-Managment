using DrivingLicenseBusinessLayer;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class ShowUserDetails : Form
    {

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
        }

        public ShowUserDetails(clsUser user)
        {
            InitializeComponent();

            _user = user;
            _person = GetAssociatedPerson(user.PersonID);
            UpdateUserLoginInfo(_user);
        }

        private void ctrlPersonInfo1_Load(object sender, System.EventArgs e)
        {
            ctrlPersonInfo1.HandleDataReceived(_person);
        }

        private void ShowUserDetails_Load(object sender, System.EventArgs e)
        {

        }
    }
}