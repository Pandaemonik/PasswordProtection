using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PasswordProtection.Externals
{
    public static class DbAction
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["PasswordProtection.Properties.Settings.DatabaseConnectionString"].ConnectionString;

        public static bool AddNewUser(string Username, string Password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO [dbo].[LogIn] (username,password) VALUES (@username,@password)";

                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                {
                    sqlDataAdapter.InsertCommand = new SqlCommand(query, connection);
                    sqlDataAdapter.InsertCommand.Parameters.AddWithValue("@username", Username);
                    sqlDataAdapter.InsertCommand.Parameters.AddWithValue("@password", Password);
                    int result;
                    try
                    {
                        connection.Open();
                        sqlDataAdapter.InsertCommand.Transaction = connection.BeginTransaction();
                        result = sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                        sqlDataAdapter.InsertCommand.Transaction.Commit();
                        connection.Close();
                    }
                    catch(SqlException)
                    {
                        result = -1;
                    }
                    
                    //sqlDataAdapter.InsertCommand.Dispose();
                    return (result < 0);
                }
            }
        }

        public static string GetPasswordByUser(string Username)
        {
            string Password = "N/A";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT password FROM [dbo].[LogIn] WHERE username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", Username);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Password = reader["Password"].ToString();
                        }
                    }
                    connection.Close();
                    return Password;
                }
            }
        }
    }
}
