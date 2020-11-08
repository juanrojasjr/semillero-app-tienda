using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataProduct : ConnectionToSql
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable GetProduct()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM DataProduct";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }
        public void AddProduct(string nombre_producto, string Descripcion, string Marca, float Precio_fabrica, float Precio_venta, int Unidades)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DataProduct(nombre_producto, Descripcion, Marca, Precio_fabrica, Precio_venta, Unidades) VALUES (@nombre_producto, @Descripcion, @Marca, @Precio_fabrica, @Precio_venta, @Unidades)";
                    command.Parameters.AddWithValue("@nombre_producto", nombre_producto);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@Marca", Marca);
                    command.Parameters.AddWithValue("@Precio_fabrica", Precio_fabrica);
                    command.Parameters.AddWithValue("@Precio_venta", Precio_venta);
                    command.Parameters.AddWithValue("@Unidades", Unidades);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditProduct(string nombre_producto, string Descripcion, string Marca, float Precio_fabrica, float Precio_venta, int Unidades, int id_producto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update DataProduct set nombre_producto=@nombre_producto,Descripcion=@Descripcion,Marca=@Marca,Precio_fabrica=@Precio_fabrica, Precio_venta=@Precio_venta, Unidades=@Unidades where id_producto = @id_producto";
                    command.Parameters.AddWithValue("@nombre_producto", nombre_producto);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@Marca", Marca);
                    command.Parameters.AddWithValue("@Precio_fabrica", Precio_fabrica);
                    command.Parameters.AddWithValue("@Precio_venta", Precio_venta);
                    command.Parameters.AddWithValue("@Unidades", Unidades);
                    command.Parameters.AddWithValue("@id_producto", id_producto);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduct(int id_producto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from DataProduct where id_producto = @id_producto";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_producto", id_producto);
                    command.ExecuteNonQuery();
                }
            }
        }
    }


}
