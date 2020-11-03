using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FunCajero: ConnectionToSql
    {
        public DataTable getProduct(string data)
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Products WHERE Nombre LIKE '%@name%'";
                    //command.CommandText = "SELECT * FROM Products WHERE Nombre LIKE '%co%'";
                    command.Parameters.AddWithValue("@name", data);
                    command.CommandType = CommandType.Text;
                    leer = command.ExecuteReader();
                    tabla.Load(leer);

                    return tabla;                    
                }
            }
        }
    }
}
