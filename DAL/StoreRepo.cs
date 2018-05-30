using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MVCTask.Models;
using MVCTask.DAL.Contracts;

namespace MVCTask.DAL
{
    public class StoreRepo: IStoreRepo
    {
        private static string conStr;
        static StoreRepo()
        {
            conStr = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
        }

        public StoreRepo() { }

        public IEnumerable<Store> GetAll()
        {
            string sqlExpression = "sp_ShowStore";
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
                            yield return new Store
                            {
                                ID_store = (int)reader["ID_store"],
                                Adress = (string)reader["Adress"]
                            };
                        }
                    }
                }
            }
        }                                           

        public int? Add(string adress)
        {
            string sqlExpression = "sp_InsertStore";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpression, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;                 
                    cmd.Parameters.AddWithValue("@Adress", adress);

                    SqlParameter outputIdParam = new SqlParameter("@id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    return outputIdParam.Value as int?;
                }                               
            }
        }

        public int? Delete(string adress)
        {
            string sqlExpression = "sp_DeleteStoreByAdress";
            using (SqlConnection con = new SqlConnection(conStr))
            {              
                using (SqlCommand cmd = new SqlCommand(sqlExpression, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Adress",adress);
                    SqlParameter outputIdParam = new SqlParameter("@count", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    return outputIdParam.Value as int?;
                }                   
            }
        }

        public int? Delete(int id)
        {
            string sqlExpression = "sp_DeleteStoreByID";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpression, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlParameter outputIdParam = new SqlParameter("@count", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);
                   
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return outputIdParam.Value as int?;
                }                                                        
            }
        }

    }

}
