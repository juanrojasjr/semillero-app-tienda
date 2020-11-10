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
                    command.CommandText = "SELECT * FROM Products";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }
        public void AddProduct(int Ref, string Nombre, string Categoria, int Stock, int CantMin, float PriceProv, float PriceSale)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Products VALUES (@ref, @nombre, @categoria, @stock, @cantmin, @priceprov, @pricesale)";
                    command.Parameters.AddWithValue("@ref", Ref);
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@categoria", Categoria);
                    command.Parameters.AddWithValue("@stock", Stock);
                    command.Parameters.AddWithValue("@cantmin", CantMin);
                    command.Parameters.AddWithValue("@priceprov", PriceProv);
                    command.Parameters.AddWithValue("@pricesale", PriceSale);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void EditProduct(int Ref, string Nombre, string Categoria, int Stock, int CantMin, float PriceProv, float PriceSale, int IdProduct)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Products set Ref=@ref, Nombre=@nombre, Categoria=@categoria, Stock=@stock, CanMin=@canmin, PriceProv=@priceprov, PriceSale=@pricesale where IdProduct = @idproduct";
                    command.Parameters.AddWithValue("@ref", Ref);
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@categoria", Categoria);
                    command.Parameters.AddWithValue("@stock", Stock);
                    command.Parameters.AddWithValue("@canmin", CantMin);
                    command.Parameters.AddWithValue("@priceprov", PriceProv);
                    command.Parameters.AddWithValue("@pricesale", PriceSale);
                    command.Parameters.AddWithValue("@idproduct", IdProduct);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduct(int IdProduct)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from Products where IdProduct = @idproduct";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idproduct", IdProduct);
                    command.ExecuteNonQuery();
                }
            }
        }
    }


}
