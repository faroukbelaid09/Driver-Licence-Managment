using System;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.ShowDialog();
        }
    }
}
