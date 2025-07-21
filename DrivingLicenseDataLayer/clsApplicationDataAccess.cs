using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
