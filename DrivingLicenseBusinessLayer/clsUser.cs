


using DrivingLicenseDataLayer;

namespace DrivingLicenseBusinessLayer
{
    public class clsUser
    {
        private int _personID;
        private string _userName;
        private string _password;
        private bool _isActive;

        public clsUser() { }
        public clsUser(int personID,string userName, string password,bool isActive) 
        { 
            this._personID = personID;
            this._userName = userName;
            this._password = password;
            this._isActive = isActive;
        }


        public int Add(int personID,string userName, string password, bool isActive) {
            int userID = clsUserDataAccess.AddUser(personID,userName,password,isActive);
            return userID;
        }


        public static bool CheckIfUserExist(int personID)
        {
           return clsUserDataAccess.CheckIfUserExist(personID);
        }
    }
}
