using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MVCTask.Models
{
    public class ProductRepo: Product, IProductRepo 
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
                con.Open();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "SELECT * FROM Store.dbo.Product";

                SqlCommand cmd = new SqlCommand(sqlExpression, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ID_product = (int)reader["ID_product"];
                    int ID_product_group = (int)reader["ID_product_group"];
                    int ID_producer = (int)reader["ID_producer"];
                    string Name = (string)reader["Name"];

                    Product product = new Product
                    {
                        ID_product = ID_product,
                        ID_product_group = ID_product_group,
                        ID_producer = ID_producer,
                        Name = Name
                    };
                    yield return product;
                }
            }
        }

        public bool Add(Product product)
        {
            string sqlExpression = "sp_InsertProduct";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                //SqlCommand cmd = con.CreateCommand();
    //cmd.CommandText = "INSERT INTO dbo.Product(ID_product_group, ID_producer, Name) VALUES(@ID_product_group, @ID_producer,  @Name)";

                SqlCommand cmd = new SqlCommand(sqlExpression, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_product_group", product.ID_product_group);
                cmd.Parameters.AddWithValue("@ID_producer", product.ID_producer);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(Product product)
        {
            string sqlExpression = "sp_DeleteProductByName";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "DELETE from Store.dbo.Product WHERE Name=@Name";

                SqlCommand cmd = new SqlCommand(sqlExpression, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", product.Name);
               
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            string sqlExpression = "sp_DeleteProductByID";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "DELETE from Store.dbo.Product WHERE ID_product=@id";

                SqlCommand cmd = new SqlCommand(sqlExpression, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }

}
}
