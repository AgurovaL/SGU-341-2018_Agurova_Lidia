using MVCTask.DAL.Contracts;
using MVCTask.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MVCTask.DAL
{
    public class ProducerRepo: IProducerRepo
    {
        private static string conStr;
        static ProducerRepo()
        {
            conStr = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
        }

        public ProducerRepo() { }

        public IEnumerable<Producer> GetAll()
        {
            string sqlExpression = "sp_ShowProducer";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpression, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Producer
                            {
                                ID_producer = (int)reader["ID_producer"],
                                Name = (string)reader["Name"],
                                Adress = (string)reader["Adress"]
                            };
                        }
                    }
                }
            }
        }
    }
}
