using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MVCTask.Models
{
    public class StoreRepo: Store, IStoreRepo
    {
        private static string conStr;
        static StoreRepo()
        {
            conStr = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
        }

        public IEnumerable<Store> GetAll()
        {
            string sqlExpression = "sp_ShowStore";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                //SqlCommand cmd = connection.CreateCommand();
                //cmd.CommandText = "SELECT * FROM Store.dbo.Store";

                SqlCommand cmd = new SqlCommand(sqlExpression, con);               
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
              
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int ID_store = (int)reader["ID_store"];
                    string Adress = (string)reader["Adress"];

                    Store store = new Store
                    {
                        ID_store = ID_store,
                        Adress = Adress
                    };
                    yield return store;
                }

            }
        }

        public bool Add(Store store)
        {
            // название процедуры
            string sqlExpression = "sp_InsertStore";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "INSERT INTO dbo.Store(Adress) VALUES(@Adress)";              

                //через хранимую процедуру
                SqlCommand cmd = new SqlCommand(sqlExpression, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Adress", store.Adress);                           
              
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(Store store)
        {
            string sqlExpression = "sp_DeleteStoreByAdress";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
               // SqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = "DELETE from Store.dbo.Store WHERE Adress=@Adress";                

                SqlCommand cmd = new SqlCommand(sqlExpression, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Adress", store.Adress);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            string sqlExpression = "sp_DeleteStoreByID";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

               // SqlCommand cmd = con.CreateCommand();
               // cmd.CommandText = "DELETE from Store.dbo.Store WHERE ID_store=@id";
               //cmd.Parameters.AddWithValue("@id", id);
               
                SqlCommand cmd = new SqlCommand(sqlExpression, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }

}
