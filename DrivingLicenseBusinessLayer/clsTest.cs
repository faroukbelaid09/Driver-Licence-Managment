using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsTest
    {
        int TestID { get; set; }
        int TestAppointmentID { get; set; }
        int TestResult {  get; set; }
        string TestNote { get; set; }
        int CreatedByUser { get; set; }


        public clsTest(int TestID, int TestAppointmentID,int TestResult, string TestNote,int CreatedByUser) 
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.TestNote = TestNote;
            this.CreatedByUser = CreatedByUser;
        }

        public static clsTest Create(int testappointmentid, int testResult, string testNote, int createdbyuser)
        {
            int testid = -1;

            testid = clsTestsDataAccess.Create(testappointmentid, testResult, testNote,createdbyuser);

            if (testid != -1) 
            {
                return new clsTest(testid,testappointmentid, testResult, testNote,createdbyuser);
            }

            return null;
        }
    }
}
