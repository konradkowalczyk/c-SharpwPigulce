using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRestService
{
    public class ProductRepository
    {
        public string GetById(int id)
        {
            var connectionString = @"Data Source=DESKTOP-80FAI3R\SQLEXPRESS;Initial Catalog=RestfulServiceDatabase;Integrated Security=SSPI";
            string result = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM PRODUCTS WHERE PRODUCT_ID=" + id, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result = reader[1].ToString();
                }
            }
            return result;
        }

    }
}
