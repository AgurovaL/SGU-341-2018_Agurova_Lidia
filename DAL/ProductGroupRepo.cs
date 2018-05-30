using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MVCTask.DAL.Contracts;
using MVCTask.Models;

namespace MVCTask.DAL
{
    public class ProductGroupRepo: IProductGroupRepo
    {
        private static string conStr;
        static ProductGroupRepo()
        {
            conStr = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
        }

        public ProductGroupRepo() { }

        public IEnumerable<ProductGroup> GetAll()
        {
            string sqlExpression = "sp_ShowProductGroup";
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
                            yield return new ProductGroup
                            {
                                ID_product_group = (int)reader["ID_product_group"],
                                Name = (string)reader["Name"]
                            };
                        }
                    }
                }
            }
        }
    }
}
