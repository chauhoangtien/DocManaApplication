using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Repositories.Model;

namespace Repositories
{
    public class ProjectDepartmentRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public List<ProjectDepartment> getProjectDepartment(string departmentID)
        {
            List<ProjectDepartment> projectDepartmentList = new List<ProjectDepartment>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Project_Departments WHERE Project_Departments.DepartmentID = @DepartmentID", connection);
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProjectDepartment projectDepartment = new ProjectDepartment
                            {
                                ProjectId = reader["ProjectID"].ToString(),
                                DepartmentId = reader["DepartmentID"].ToString(),
                            };
                            projectDepartmentList.Add(projectDepartment);
                        }
                    }
                    return projectDepartmentList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string createProjectDepartment(string projectID, string departmentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addProject_Department", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProjectID", projectID);
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);

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
