using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseDataLayer
{
    public class clsLocalApplicationDataAccess
    {

        public static int CreateLocalDrivingLicenseApplication(int applicationID, int licenseClassID)
        {
            int localAppID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert into LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                            Values(@ApplicationID, @LicenseClassID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    localAppID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when creating a L.D.L application in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return localAppID;
        }
        
        public static bool FindLocalApplication(int localAppID, ref int appID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LocalDrivingLicenseApplications
                            where LocalDrivingLicenseApplicationID = @localAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localAppID", localAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    appID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
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
