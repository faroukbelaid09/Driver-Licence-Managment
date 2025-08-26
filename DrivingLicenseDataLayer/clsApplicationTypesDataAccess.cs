using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace DrivingLicenseDataLayer
{
    public class clsApplicationTypesDataAccess
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from ApplicationTypes";

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
    
        public static bool UpdateApplicationType(int appID, string appTitle,int appFees)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update ApplicationTypes 
                           Set ApplicationTypeTitle = @appTitle, ApplicationFees = @appFees
                           Where ApplicationTypeID = @appID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appID", appID);
            command.Parameters.AddWithValue("@appTitle", appTitle);
            command.Parameters.AddWithValue("@appFees", appFees);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    Console.WriteLine("PASSED!");
                    isUpdated = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when updating application." + ex.ToString());
            }
            finally
            {
                connection?.Close();
            }

            return isUpdated;

        }
    
        public static bool GetApplication(int appTypeID, ref string appTypeTitle, ref int appTypeFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from ApplicationTypes where ApplicationTypeID =@appTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@appTypeID", appTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    appTypeTitle = (string)reader["ApplicationTypeTitle"];
                    Console.WriteLine("passed1");
                    appTypeFees = (int)reader["ApplicationFees"];
                    Console.WriteLine("passed2");
                    
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
    }
}
