using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsFullLocalApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string DrivingClass { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public string ApplicationDate { get; set; }
        public int PassedTests { get; set; }
        public string ApplicationStatus { get; set; }

        public clsFullLocalApplication(int localAppID,string drivingClass,string nationalNo,string fullName,
            string appDate,int passedTests, string appStatus) 
        {
            this.LocalDrivingLicenseApplicationID = localAppID;
            this.DrivingClass = drivingClass;
            this.NationalNo = nationalNo;
            this.FullName = fullName;
            this.ApplicationDate = appDate;
            this.PassedTests = passedTests;
            this.ApplicationStatus = appStatus;
        }
    }
}
