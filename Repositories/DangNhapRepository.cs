using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Model;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Repositories
{
    public class DangNhapRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public bool checkLogin(string userID, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserID = @userID AND Password = @password and Status = N'Hoạt động'", connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string getEmail(string userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Email FROM Users WHERE UserID = @userID", connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        return $"{reader["Email"]}";
                    }
                    return "Email could not be found";
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
    }
}
