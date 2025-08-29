using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseDataLayer
{
    public class clsDetainLicenseDataAccess
    {
        public static int DetainLicense(int licenseID, string detainDate, int fineFees,int createdByUserID, int isReleased,
            string releasedDate, int releasedUserID, int releasedAppID)
        {
            int DetainID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert into DetainedLicenses (LicenseID, DetainDate, fineFees,CreatedByUserID, IsReleased, ReleaseDate,
                             ReleasedByUserID,ReleaseApplicationID)
                            Values(@licenseID, @detainDate, @fineFees,@createdByUserID, @isReleased, @releasedDate, @releasedUserID, 
                            @releasedAppID); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@licenseID", licenseID);
            command.Parameters.AddWithValue("@detainDate", detainDate);
            command.Parameters.AddWithValue("@fineFees", fineFees);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            command.Parameters.AddWithValue("@isReleased", isReleased);
            
            if (releasedDate != "")
            {
                command.Parameters.AddWithValue("@releasedDate", releasedDate);
            }
            else
            {
                command.Parameters.AddWithValue("@releasedDate", System.DBNull.Value);
            }
            
            if (releasedUserID != -1)
            {
                command.Parameters.AddWithValue("@releasedUserID", releasedUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@releasedUserID", System.DBNull.Value);
            }
            
            if (releasedAppID != -1)
            {
                command.Parameters.AddWithValue("@releasedAppID", releasedAppID);
            }
            else
            {
                command.Parameters.AddWithValue("@releasedAppID", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when detaining a license in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            return DetainID;
        }
    }
}
