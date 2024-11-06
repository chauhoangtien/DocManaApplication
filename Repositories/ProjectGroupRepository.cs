using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Model;

namespace Repositories
{
    public class ProjectGroupRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public List<ProjectGroup> getProjectGroup(string groupID)
        {
            List<ProjectGroup> projectGroupList = new List<ProjectGroup>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Project_Groups WHERE Project_Groups.GroupID = @GroupID", connection);
                    command.Parameters.AddWithValue("@GroupID", groupID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProjectGroup projectGroup = new ProjectGroup
                            {
                                ProjectId = reader["ProjectID"].ToString(),
                                GroupId = reader["GroupID"].ToString(),
                            };
                            projectGroupList.Add(projectGroup);
                        }
                    }
                    return projectGroupList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string createProjectGroup(string projectID, string groupID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addProject_Group", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProjectID", projectID);
                    command.Parameters.AddWithValue("@GroupID", groupID);

                    SqlParameter messageParam = new SqlParameter("@Message", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(messageParam);

                    command.ExecuteNonQuery();

                    return messageParam.ToString();
                }
            }
            catch (Exception ex)
            {
                return "Connection Failed";
            }
        }
    }
}
