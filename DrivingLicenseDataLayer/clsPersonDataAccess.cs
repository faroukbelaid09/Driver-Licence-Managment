using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace DrivingLicenseDataLayer
{
    public class clsPersonDataAccess
    {
        public static bool GetPersonByID(int ID, ref string FirstName, ref string LastName,
            ref string Email, ref string Phone,ref string NationalNo, ref string Address, ref DateTime DateOfBirth,
            ref int Gender, ref int CountryID,ref string CountryName, ref string ImagePath) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select People.*,Countries.CountryName from People 
                            inner join Countries on People.NationalityCountryID = Countries.CountryID 
                            where People.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Console.WriteLine("FOUND!!!");
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    Console.WriteLine("passed");
                    LastName = (string)reader["LastName"];
                    Console.WriteLine("passed2");
                    Phone = (string)reader["Phone"];
                    Console.WriteLine("passed3");
                    NationalNo = (string)reader["NationalNo"];
                    Console.WriteLine("passed4");
                    Address = (string)reader["Address"];
                    Console.WriteLine("passed5");
                    Gender = (int)reader["Gendor"];
                    Console.WriteLine("passed6");
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Console.WriteLine("passed6");
                    CountryID = (int)reader["NationalityCountryID"];
                    Console.WriteLine("passed7");
                    CountryName = (string)reader["CountryName"];
                    Console.WriteLine("passed8");

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "No Email was provided.";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "Image Path Is Not Available";
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

        public static bool GetPersonByNationalNo(ref int PersonID, ref string FirstName, ref string LastName,
            ref string Email, ref string Phone, string NationalNo, ref string Address, ref DateTime DateOfBirth,
            ref int Gender, ref int CountryID, ref string CountryName, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select People.*,Countries.CountryName from People 
                            inner join Countries on People.NationalityCountryID = Countries.CountryID 
                            where People.NationalNo = @nationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Console.WriteLine("FOUND!!!");
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    //NationalNo = (string)reader["NationalNo"];
                    Address = (string)reader["Address"];
                    Gender = (int)reader["Gendor"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["NationalityCountryID"];
                    CountryName = (string)reader["CountryName"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "No Email was provided.";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "Image Path Is Not Available";
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
        public static DataTable GetPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "select People.*,CountryName from People\r\ninner join Countries on People.NationalityCountryID = Countries.CountryID";
            
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

        public static int AddPerson(string NationalNo, string FirstName, string LastName,
            DateTime DateOfBirth, int Gender, string Address, string Email, string Phone,
            int CountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Insert into People (NationalNo, FirstName, LastName, DateOfBirth, Gendor, Address, Email, Phone, NationalityCountryID, ImagePath)
                            Values(@NationalNo, @FirstName, @LastName, @DateOfBirth, @Gendor, @Address, @Email, @Phone, @NationalityCountryID, @ImagePath);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch (Exception ex) {
                Console.WriteLine("DB: Error when adding a person in DB.\n" + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            return PersonID;
        }


        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string LastName,
            DateTime DateOfBirth, int Gendor, string Address, string Email, string Phone,
            int CountryID, string ImagePath)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update People 
                           Set NationalNo = @NationalNo, FirstName = @FirstName, LastName = @LastName,
                           Gendor = @Gendor, NationalityCountryID = @NationalityCountryID, Email = @Email,
                           Phone=@Phone, Address=@Address,DateOfBirth=@DateOfBirth, ImagePath=@ImagePath
                           Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();

                if (rowAffected > 0)
                {
                    isUpdated = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when updatin person." + ex.ToString());
            }
            finally
            {
                connection?.Close();
            }

            return isUpdated;
        }

        public static bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                
                if (rowAffected > 0)
                {
                    isDeleted = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("DB: Error when deleting this person.");
            }
            finally
            {
                connection?.Close();
            }
            return isDeleted;
        }
       
        public static string GetPersonCountryName(int CountryID)
        {
            string CountryName = string.Empty;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from Countries where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID+1);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    CountryName = reader["CountryName"].ToString();
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }

            return CountryName;
        }
    }
}
