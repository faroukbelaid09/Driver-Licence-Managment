using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DrivingLicenseDataLayer
{
    public class clsApplicationDataAccess
    {
        public static int CreateApplication(int appPersonID, string appDate, int appTypeID,
             int appStatus, string appLastStatusDate, int appPaidFees,  int appCreatedByUserID)
        {
            int appID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert into Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, 
                            ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                            Values(@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, 
                            @LastStatusDate, @PaidFees, @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", appPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", appDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", appTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", appStatus);
            command.Parameters.AddWithValue("@LastStatusDate", appLastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", appPaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", appCreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    appID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when creating an application in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return appID;
        }
    

        public static DataTable GetAllLocalApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "select * from LocalDrivingLicenseFullApplications";

            SqlCommand command = new SqlCommand(query, connection);

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
    
    
        public static bool CheckIfApplicationExist(string nationalNo, string drivingClass)
        {

            // Input validation
            if (string.IsNullOrWhiteSpace(nationalNo) || string.IsNullOrWhiteSpace(drivingClass))
            {
                Console.WriteLine("Invalid input parameters");
                return false;
            }

            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            Console.WriteLine(nationalNo);
            Console.WriteLine(drivingClass);

            string query = @"select 1 from LocalDrivingLicenseFullApplications
                  where NationalNo = @nationalNo and DrivingClass LIKE '%' + @drivingClass + '%'
                  and(ApplicationStatus = 1 or ApplicationStatus = 3)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationalNo", nationalNo);
            command.Parameters.AddWithValue("@drivingClass", drivingClass);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.HasRows)
                {
                    isFound = true;
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
            return isFound;

        }
    }
}