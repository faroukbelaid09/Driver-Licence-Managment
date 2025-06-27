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
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser() { }
        // User Info from DataGridView
        public clsUser(int userID,int personID,string userName,string fullName,string password, bool isActive) 
        { 
            this.UserID = userID;
            this.PersonID = personID;
            this.UserName = userName;
            this.FullName = fullName;
            this.Password = password;
            this.IsActive = isActive;
        }
        
        // User Info from DB
        public clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            this.UserID = userID;
            this.PersonID = personID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
        }

        public int Add() {
            int userID = clsUserDataAccess.AddUser(this.PersonID,this.UserName,this.Password,this.IsActive);
            return userID;
        }
        public bool Update()
        {
            return clsUserDataAccess.UpdateUser(this.UserID,this.UserName,this.Password,this.IsActive);
        }
        public bool Delete()
        {
            return clsUserDataAccess.DeleteUser(this.UserID);
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
                    string password = row["Password"].ToString();
                    bool isActive = Convert.ToBoolean(row["IsActive"]);

                    // Create a new clsPerson object and add it to the list
                    clsUser user = new clsUser(
                        userID,
                        personID,
                        userName,
                        fullName,
                        password,
                        isActive
                    );

                    users.Add(user);
                }

                return users;
            }

            return null;
        }
        public static clsUser FindUserByUserNameAndPassword(string username,string password)
        {
            clsUser user = null;
            DataTable dataTable = clsUserDataAccess.FindUserByUserNameAndPassword(username,password);

            if (dataTable.Rows != null)
            {
                DataRow dataRow = dataTable.Rows[0];
                // Extract data from the DataRow
                int userID = Convert.ToInt32(dataRow["UserID"]);
                int personID = Convert.ToInt32(dataRow["PersonID"]);
                string userName = dataRow["UserName"].ToString();
                //string fullName = dataRow["FullName"].ToString();
                string userPassword = dataRow["Password"].ToString();
                bool isActive = Convert.ToBoolean(dataRow["IsActive"]);

                // Create a new clsPerson object and add it to the list
                user = new clsUser(
                    userID,
                    personID,
                    userName,
                    userPassword,
                    isActive
                );
            }
            return user;
        }
    }
}