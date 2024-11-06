using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories.Model;

namespace Repositories
{
    public class ProfileRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public List<Profile> getProfile(string projectID)
        {
            List<Profile> profileList = new List<Profile>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Profiles WHERE Profiles.ProjectID = @ProjectID", connection);
                    command.Parameters.AddWithValue("@ProjectID", projectID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Profile profile = new Profile
                            {
                                ProfileId = reader["ProfileID"].ToString(),
                                ProfileName = reader["ProfileName"].ToString(),
                                ProjectId = reader["ProjectID"].ToString(),
                                Description = reader["Description"].ToString(),
                                StartDate = reader["StartDate"] != DBNull.Value ? (DateTime?)reader["StartDate"] : null,
                                EndDate = reader["EndDate"] != DBNull.Value ? (DateTime?)reader["EndDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null,
                            };
                            profileList.Add(profile);
                        }
                    }
                    return profileList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string createProfile(string profileName, string projectID, string description)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addProfile", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProfileName", profileName);
                    command.Parameters.AddWithValue("@ProjectID", projectID);
                    command.Parameters.AddWithValue("@Description", description);

                    SqlParameter messageParam = new SqlParameter("@Message", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    return messageParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }

        public string updateProfile(string projectID, string description, DateTime endDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("updateProfile", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProfileID", projectID);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlParameter messageParam = new SqlParameter("@Message", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    return messageParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
    }
}
