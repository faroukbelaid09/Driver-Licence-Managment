using System;
using System.Collections.Generic;
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
    }
}