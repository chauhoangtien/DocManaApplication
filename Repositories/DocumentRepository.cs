using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories.Model;

namespace Repositories
{
    public class DocumentRepository
    {
        static DocManaContext docManaContext = new DocManaContext();

        private static string connectionString = docManaContext.getConnectionString();

        public Document getDocument(string documentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Documents where DocumentID = @documentID", connection);
                    command.Parameters.AddWithValue("@documentID", documentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            Document document = new Document
                            {
                                DocumentId = reader["DocumentID"].ToString(),
                                DocumentName = reader["DocumentName"].ToString(),
                                ProjectId = reader["ProjectID"].ToString(),
                                Version = reader["Version"].ToString(),
                                Status = reader["Status"].ToString(),
                                SubmittedBy = reader["SubmittedBy"].ToString(),
                                CreatedDate = reader["CreatedDate"] != DBNull.Value ? (DateTime?)reader["CreatedDate"] : null,
                                ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? (DateTime?)reader["ModifiedDate"] : null,
                                FilePath = reader["FilePath"].ToString(),
                            };

                            return document;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string createDocument(DateOnly date, string projectID, string documentName, string version, string status, string submittedBy, string filePath)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("addDocument", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@ProjectID", projectID);
                    command.Parameters.AddWithValue("@DocumentName", documentName);
                    command.Parameters.AddWithValue("@Version", version);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@SubmittedBy", submittedBy);
                    command.Parameters.AddWithValue("@FilePath", filePath);

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
        public string updateDocument(string documentID, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("updateDocument", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DocumentID", documentID);
                    command.Parameters.AddWithValue("@Status", status);

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
