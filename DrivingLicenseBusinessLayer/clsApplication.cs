using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
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


        public static List<clsFullLocalApplication> GetAllLocalApplications()
        {
            DataTable dataTable = new DataTable();
            List<clsFullLocalApplication> clsFullLocalApplications = new List<clsFullLocalApplication>();

            dataTable = clsApplicationDataAccess.GetAllLocalApplications();

            if (dataTable.Rows != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    // Extract data from the DataRow
                    int localappid = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);
                    string drivingclass = row["DrivingClass"].ToString();
                    string nationalno = row["NationalNo"].ToString();
                    string fullname = row["FullName"].ToString();
                    string appdate = row["ApplicationDate"].ToString();
                    int passedtests = Convert.ToInt32(row["PassedTests"]);

                    string appstatus = Convert.ToInt32(row["ApplicationStatus"]) == 1 ? "New" : Convert.ToInt32(row["ApplicationStatus"]) == 2 ? "Cancelled" : "Completed";

                    // Create a new clsFullLocalApplication object and add it to the list
                    clsFullLocalApplication localapp = new clsFullLocalApplication(
                        localappid,drivingclass,nationalno, fullname,appdate,passedtests,appstatus
                    );

                    clsFullLocalApplications.Add(localapp);
                }

                return clsFullLocalApplications;
            }

            return null;
        }
    }
}
