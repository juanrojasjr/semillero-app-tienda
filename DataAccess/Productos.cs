using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;
using Microsoft.SqlServer.Server;


namespace DataAccess
{
    class Productos : ConnectionToSql
    {
        public bool AgregarProd(string nombre_producto, string descripcion, string marca, double precio_fabrica, double precio_venta, int unidades)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into productos values ('Gaseosa', '3 litros', 'Big Cola', 2000, 3000, 13)";
                    //command.Parameters.AddWithValue("@user", user);
                    //command.Parameters.AddWithValue("@pass", pass);

                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdUser = reader.GetInt32(0);
                            UserCache.FirstName = reader.GetString(3);
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
