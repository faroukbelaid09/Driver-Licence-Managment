using DrivingLicenseDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseBusinessLayer
{
    public class clsTestAppointment
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public string AppointmentDate { get; set; }
        public int PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        public clsTestAppointment(int testAppointmentID, int testTypeID, int localDrivingAppID,string appointmentDate
            , int paidFees, int createdByUserID, int isLocked, int retakeTestAppID = -1) 
        {
            this.TestAppointmentID = testAppointmentID;
            this.TestTypeID = testTypeID;
            this.LocalDrivingLicenseApplicationID = localDrivingAppID;
            this.AppointmentDate = appointmentDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.IsLocked = isLocked;
            this.RetakeTestApplicationID = retakeTestAppID;
        }

        public static clsTestAppointment Create(int testtypeid, int localdrivingappid, string appointmentdate,
            int paidfees,int createdbyuserid, int islocked, int retaketestappid)
        {
            int TestAppointmentsID = clsTestAppointmentDataAccess.Create(testtypeid,localdrivingappid,appointmentdate,
                paidfees,createdbyuserid,islocked,retaketestappid);

            if (TestAppointmentsID != -1)
            {
                return new clsTestAppointment(TestAppointmentsID,testtypeid,localdrivingappid,appointmentdate,
                    paidfees,createdbyuserid,islocked,retaketestappid);
            }
            return null;
        }

        public static bool Update(int testappointmentid,int testtypeid, int localdrivingappid, string appointmentdate,
            int paidfees, int createdbyuserid, int islocked, int retaketestappid)
        {
            return clsTestAppointmentDataAccess.Update(testappointmentid, testtypeid, localdrivingappid, appointmentdate,
            paidfees, createdbyuserid, islocked, retaketestappid);
        }
        public static clsTestAppointment Find(int testAppointmentID)
        {
            int TestTypeID = -1, LocalDrivingAppID = -1, PaidFees = -1, Islocked = -1, CreatedbyUserID = -1,
                RetakeTestAppID = -1;
            string AppointmentsDate = "";

            if(clsTestAppointmentDataAccess.FindTestAppointment(testAppointmentID,ref TestTypeID,ref LocalDrivingAppID,
                ref AppointmentsDate,ref PaidFees,ref CreatedbyUserID, ref Islocked, ref RetakeTestAppID))
            {
                return new clsTestAppointment(testAppointmentID,TestTypeID,LocalDrivingAppID,AppointmentsDate,
                    PaidFees,CreatedbyUserID,Islocked,RetakeTestAppID);
            }

            return null;
        }
    
        public static List<clsTestAppointment> GetVisionTests(int localDrivingAppID)
        {
            List<clsTestAppointment> tests = new List<clsTestAppointment>();
            DataTable dt = clsTestAppointmentDataAccess.GetAllVisionAppointmentsTest(localDrivingAppID);

            if (dt.Rows != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // Extract data from the DataRow
                    int testappointmentid = Convert.ToInt32(row["TestAppointmentID"]);
                    int testtypeid = Convert.ToInt32(row["TestTypeID"]);
                    int localdrivingappid = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);
                    string appoinymentdate = row["AppointmentDate"].ToString();
                    int paidfees = Convert.ToInt32(row["PaidFees"]);
                    int creatdebyuserid = Convert.ToInt32(row["CreatedByUserID"]);
                    int islocked = Convert.ToInt32(row["IsLocked"]);
                    int retaketestappid = -1;
                    if (row["RetakeTestApplicationID"] != System.DBNull.Value)
                    {
                        retaketestappid = Convert.ToInt32(row["RetakeTestApplicationID"]);
                    }


                    // Create a new clsFullLocalApplication object and add it to the list
                    clsTestAppointment test = new clsTestAppointment(
                        testappointmentid, testtypeid, localdrivingappid, appoinymentdate, paidfees,
                        creatdebyuserid, islocked, retaketestappid
                    );

                    tests.Add(test);
                }

                return tests;
            }
            return null;
        }

        public static List<clsTestAppointment> GetWritingTests(int localDrivingAppID)
        {
            List<clsTestAppointment> tests = new List<clsTestAppointment>();
            DataTable dt = clsTestAppointmentDataAccess.GetAllWritingAppointmentsTest(localDrivingAppID);

            if (dt.Rows != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // Extract data from the DataRow
                    int testappointmentid = Convert.ToInt32(row["TestAppointmentID"]);
                    int testtypeid = Convert.ToInt32(row["TestTypeID"]);
                    int localdrivingappid = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);
                    string appoinymentdate = row["AppointmentDate"].ToString();
                    int paidfees = Convert.ToInt32(row["PaidFees"]);
                    int creatdebyuserid = Convert.ToInt32(row["CreatedByUserID"]);
                    int islocked = Convert.ToInt32(row["IsLocked"]);
                    int retaketestappid = -1;
                    if (row["RetakeTestApplicationID"] != System.DBNull.Value)
                    {
                        retaketestappid = Convert.ToInt32(row["RetakeTestApplicationID"]);
                    }

                    // Create a new clsFullLocalApplication object and add it to the list
                    clsTestAppointment test = new clsTestAppointment(
                        testappointmentid, testtypeid, localdrivingappid, appoinymentdate, paidfees,
                        creatdebyuserid, islocked, retaketestappid
                    );

                    tests.Add(test);
                }

                return tests;
            }
            return null;
        }

        public static List<clsTestAppointment> GetStreetTests(int localDrivingAppID)
        {
            List<clsTestAppointment> tests = new List<clsTestAppointment>();
            DataTable dt = clsTestAppointmentDataAccess.GetAllStreetAppointmentsTest(localDrivingAppID);

            if (dt.Rows != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // Extract data from the DataRow
                    int testappointmentid = Convert.ToInt32(row["TestAppointmentID"]);
                    int testtypeid = Convert.ToInt32(row["TestTypeID"]);
                    int localdrivingappid = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);
                    string appoinymentdate = row["AppointmentDate"].ToString();
                    int paidfees = Convert.ToInt32(row["PaidFees"]);
                    int creatdebyuserid = Convert.ToInt32(row["CreatedByUserID"]);
                    int islocked = Convert.ToInt32(row["IsLocked"]);
                    int retaketestappid = -1;
                    if (row["RetakeTestApplicationID"] != System.DBNull.Value)
                    {
                        retaketestappid = Convert.ToInt32(row["RetakeTestApplicationID"]);
                    }

                    // Create a new clsFullLocalApplication object and add it to the list
                    clsTestAppointment test = new clsTestAppointment(
                        testappointmentid, testtypeid, localdrivingappid, appoinymentdate, paidfees,
                        creatdebyuserid, islocked, retaketestappid
                    );

                    tests.Add(test);
                }

                return tests;
            }
            return null;
        }
    
        public static bool CheckTestAppointmentResult(int testappointmentid)
        {
            int TestResult = -1;
            clsTestsDataAccess.CheckTestResult(testappointmentid,ref TestResult);

            return TestResult > 0 ? true : false;
        }
    
        public static bool UpdateRetakeAppID(int testAppointmentID, int retakeID)
        {
            return clsTestAppointmentDataAccess.UpdateRetakeAppID(testAppointmentID,retakeID);
        }
    }
}
