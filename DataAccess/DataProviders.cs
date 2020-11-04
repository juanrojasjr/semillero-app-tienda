using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataProviders : ConnectionToSql
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM DataProviders";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        public void Insertar(string NameCompany,string Name,string Phone,string Email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DataProviders(NameCompany, Name, Phone, Email) VALUES (@NameCompany, @Name, @Phone, @Email)";
                    command.Parameters.AddWithValue("@NameCompany", NameCompany);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

      
        public void Editar(string NameCompany, string Name, string Phone, string Email,int ProveedoresID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update DataProviders set NameCompany=@NameCompany,Name=@Name,Phone=@Phone,Email=@Email where ProveedoresID = @ProveedoresID";
                    command.Parameters.AddWithValue("@NameCompany", NameCompany);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@ProveedoresID", ProveedoresID);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int ProveedoresID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from DataProviders where ProveedoresID = @ProveedoresID";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ProveedoresID",ProveedoresID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
