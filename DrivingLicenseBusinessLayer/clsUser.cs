


using DrivingLicenseDataLayer;
using System.Collections.Generic;
using System.Data;
using System;

namespace DrivingLicenseBusinessLayer
{
    public class clsUser
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        private string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser() { }
        public clsUser(int userID,int personID,string userName,string fullName, bool isActive) 
        { 
            this.UserID = userID;
            this.PersonID = personID;
            this.UserName = userName;
            this.FullName = fullName;
            this.IsActive = isActive;
        }


        public int Add(int personID,string userName, string password, bool isActive) {
            int userID = clsUserDataAccess.AddUser(personID,userName,password,isActive);
            return userID;
        }


        public static bool CheckIfUserExist(int personID)
        {
           return clsUserDataAccess.CheckIfUserExist(personID);
        }

        public static List<clsUser> GetAllUsers()
        {

            List<clsUser> users = new List<clsUser>();

            DataTable dataTable = clsUserDataAccess.GetUsers();

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int userID = Convert.ToInt32(row["UserID"]);
                    int personID = Convert.ToInt32(row["PersonID"]);
                    string userName = row["UserName"].ToString();
                    string fullName = row["FullName"].ToString();
                    bool isActive = Convert.ToBoolean(row["IsActive"]);

                    // Create a new clsPerson object and add it to the list
                    clsUser user = new clsUser(
                        userID,
                        personID,
                        userName,
                        fullName,
                        isActive
                    );

                    users.Add(user);
                }

                return users;
            }

            return null;
        }
    }
}
