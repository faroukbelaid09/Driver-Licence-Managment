using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DrivingLicenseDataLayer
{
    public class clsLicenseClassDataAccess
    {

        public static DataTable GetLicenseClasses()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    table.Load(reader);
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
            return table;
        }

        public static DataTable GetLicenseClassNames()
        {
            DataTable classNames = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select ClassName from LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    classNames.Load(reader);
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
            return classNames;

        }

        public static bool GetByName(ref int classID, string className, ref string classDescription, 
            ref int minimumAllowedAge, ref int defaultValidity, ref int classFees)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * from LicenseClasses where ClassName = @className";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@className", className);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    isFound = true;

                    classID = (int)reader["LicenseClassID"];
                    Console.WriteLine("ID");
                    classDescription = (string)reader["ClassDescription"];
                    Console.WriteLine("DESC");
                    minimumAllowedAge = (int)reader["MinimumAllowedAge"];
                    Console.WriteLine("MIN AGE");
                    defaultValidity = (int)reader["DefaultValidityLength"];
                    Console.WriteLine("LENGTH");
                    classFees = (int)reader["ClassFees"];
                    Console.WriteLine("Class Fees");
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