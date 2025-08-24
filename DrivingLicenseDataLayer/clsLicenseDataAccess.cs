using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DrivingLicenseDataLayer
{
    public class clsLicenseDataAccess
    {

        public static int CreateLicense(int ApplicationID, int DriverID, int LicenseClass, string IssueDate,
            string ExpirationDate, string Notes, int PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert into Licenses (ApplicationID, DriverID, LicenseClass,IssueDate,ExpirationDate,
                            Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
                            Values(@ApplicationID, @DriverID, @LicenseClass,@IssueDate,@ExpirationDate,@Notes,
                            @PaidFees,@IsActive,@IssueReason,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when creating a license in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return LicenseID;
        }
    
        public static bool GetFullLicenseInfo(int licenseid,ref int appid,ref int personid, ref bool isactive, ref string issuedate, 
            ref string expirationdate,ref string notes, ref string classname, ref string fullname, 
            ref int issuereason, ref int driverid, ref string isdetained,ref string nationalno,ref string dateofbirth,
            ref string gender)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from LicenseDetailsView where LicenseID =@licenseid";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseid", licenseid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    appid = (int)reader["ApplicationID"];
                    Console.WriteLine("passed");
                    
                    personid = (int)reader["PersonID"];

                    isactive = (bool)reader["IsActive"];
                    Console.WriteLine("passed1");

                    issuedate = ((DateTime)reader["IssueDate"]).ToString();
                    Console.WriteLine("passed2");

                    expirationdate = ((DateTime)reader["ExpirationDate"]).ToString();
                    Console.WriteLine("passed3");

                    notes = (string)reader["notes"];
                    Console.WriteLine("passed4");

                    classname = (string)reader["ClassName"];
                    Console.WriteLine("passed5");

                    fullname = (string)reader["FullName"];
                    Console.WriteLine("passed6");

                    issuereason = (int)reader["IssueReason"];
                    Console.WriteLine("passed6");

                    driverid = (int)reader["DriverID"];
                    Console.WriteLine("passed7");

                    isdetained = ((int)reader["isDetained"]) == 0 ? "No" : "Yes";
                    Console.WriteLine("passed8");
                    
                    nationalno = (string)reader["NationalNo"];
                    dateofbirth = ((DateTime)reader["DateOfBirth"]).ToString();
                    gender = ((int)reader["Gendor"]) == 1 ? "Male" : "Female";
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            return isFound;

        }
    
        public static int GetLicenseID(int appID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "select LicenseID from Licenses where ApplicationID =@appID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when getting a license id in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            return LicenseID;
        }
    
        public static DataTable GetAllLocalLicenses(int personID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "select * from LicenseDetailsView where PersonID =@personID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return dt;
        }


    }
}