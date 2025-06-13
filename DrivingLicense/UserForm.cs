using DrivingLicenseBusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrivingLicense
{
    public partial class UserForm : Form
    {
        List<clsUser> _users;

        private void _DisplayRecord(int number)
        {
            RecordValue.Text = number.ToString();
        }

        private void _DisplayUsers(clsUser user = null)
        {
            // Get All people
            _users = clsUser.GetAllUsers();
            
            if (_users != null && _users.Count > 0)
            {
                UserGridView.AutoGenerateColumns = true;
                UserGridView.DataSource = _users;

                // Find and replace the boolean column
                foreach (DataGridViewColumn column in UserGridView.Columns)
                {
                    if (column.DataPropertyName == "IsActive" && column is DataGridViewTextBoxColumn)
                    {
                        int columnIndex = column.Index;
                        UserGridView.Columns.Remove(column);

                        DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn()
                        {
                            DataPropertyName = "IsActive",
                            HeaderText = "Active",
                            Name = "colIsActive",
                            ReadOnly = true
                        };

                        UserGridView.Columns.Insert(columnIndex, checkColumn);
                        break;
                    }
                }

            }

            _DisplayRecord(_users.Count);
        }

        public UserForm()
        {
            InitializeComponent();

            
            _DisplayUsers();
            
        }

        private void AddPersonPB_Click(object sender, EventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.ShowDialog();
        }
    }
}