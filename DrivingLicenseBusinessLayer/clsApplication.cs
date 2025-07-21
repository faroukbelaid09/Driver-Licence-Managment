using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsApplication
    {

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public string ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplicationStatus {  get; set; }
        public string LastStatusDate { get; set; }
        public int PaidFees { get; set; }
        public int CreatedByUserID  { get; set; }


        public clsApplication(int appID, int appPersonID, string appDate, int appTypeID, int appStatus,
            string appLastStatusDate, int appFees, int createdUserID) 
        {
            this.ApplicationID = appID;
            this.ApplicantPersonID = appPersonID;
            this.ApplicationDate = appDate;
            this.ApplicationTypeID = appTypeID;
            this.ApplicationStatus = appStatus;
            this.LastStatusDate = appLastStatusDate;
            this.PaidFees = appFees;
            this.CreatedByUserID = createdUserID;
        }

        public static clsApplication Create(int personID,string appDate, int appTypeID,int appStatus,
            string appLastStatusDate, int appFees, int userID)
        {
            int applicationID = -1;

            applicationID = clsApplicationDataAccess.CreateApplication(personID, appDate, appTypeID, appStatus,
                appLastStatusDate, appFees, userID);

            if (applicationID != -1) 
            {
                return new clsApplication(applicationID,personID,appDate,appTypeID,appStatus,appLastStatusDate,appFees,userID);
            }
            return null;
        }


    }
}
