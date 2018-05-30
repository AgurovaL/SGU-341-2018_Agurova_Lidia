using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using MVCTask.Models;
using MVCTask.DAL.Contracts;

namespace MVCTask.DAL
{
    public class ProductRepo: IProductRepo 
    {
        private static string conStr;
        static ProductRepo()
        {
            conStr = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
        }

        public IEnumerable<Product> GetAll()
        {
            string sqlExpression = "sp_ShowProduct";
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
                            yield return new Product
                            {
                                ID_product = (int)reader["ID_product"],
                                Product_group = new ProductGroup(reader["GroupName"] as string),
                                Producer = new Producer(reader["ProducerName"] as string, reader["Adress"] as string),
                                Name = reader["Name"] as string
                            };
                        }
                    }
                }
            }
        }

        public int? Add(int id_product_group, int id_producer, string name)
        {
            string sqlExpression = "sp_InsertProduct";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpression, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_product_group", id_product_group);
                    cmd.Parameters.AddWithValue("@ID_producer", id_producer);
                    cmd.Parameters.AddWithValue("@Name", name);                   

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

        public int? Delete(string name)
        {
            string sqlExpression = "sp_DeleteProductByName";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlExpression, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
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
            string sqlExpression = "sp_DeleteProductByID";
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
