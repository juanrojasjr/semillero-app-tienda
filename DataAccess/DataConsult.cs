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
    public class DataConsult : ConnectionToSql
    {
        #region "Functions User"
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where LoginName=@user and UserPass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
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

        SqlDataReader view;
        DataTable tblUsers = new DataTable();
        public DataTable GetUser()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users";
                    view = command.ExecuteReader();
                    tblUsers.Load(view);
                    return tblUsers;
                }
            }
        }

        public int AddUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Users VALUES (@LoginName, @UserPass, @FirstName, @LastName, @Position, @Email)";
                    command.Parameters.AddWithValue("@LoginName", LoginName);
                    command.Parameters.AddWithValue("@UserPass", UserPass);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int SetUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email, int UserID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Users SET LoginName=@LoginName,UserPass=@UserPass,FirstName=@FirstName,LastName=@LastName,Position=@Position,Email=@Email WHERE UserID = @UserID";
                    command.Parameters.AddWithValue("@LoginName", LoginName);
                    command.Parameters.AddWithValue("@UserPass", UserPass);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int DeleteUser(int UserID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Users WHERE UserID = @UserID";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    return command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region "Functions DataStore"
        //#####################
        //FUNCTIONS DATASTORE
        //#####################
        public int AddDataStore(string namestore, string nameowner, string phone, string address)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DataStore(NameStore, NameOwner, Phone, Address) VALUES (@namestore, @nameowner, @phone, @address)";
                    command.Parameters.AddWithValue("@namestore", namestore);
                    command.Parameters.AddWithValue("@nameowner", nameowner);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);
                    command.CommandType = CommandType.Text;

                    //Cargar datos obtenidos en la clase/caché
                    DataStoreCache.Namestore = namestore;
                    DataStoreCache.Nameowner = nameowner;
                    DataStoreCache.Phone = phone;
                    DataStoreCache.Address = address;

                    return command.ExecuteNonQuery();
                }
            }
        }

        public bool GetDataStore()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from DataStore";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataStoreCache.Namestore = reader.GetString(1);
                            DataStoreCache.Nameowner = reader.GetString(2);
                            DataStoreCache.Phone = reader.GetString(3);
                            DataStoreCache.Address = reader.GetString(4);
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
        #endregion

        #region "Functions Provider"
        //#####################
        //FUNCTIONS PROVIDER
        //#####################
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable GetProvider()
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

        public void AddProvider(string NameCompany,string Name,string Phone,string Email)
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

        public void EditProvider(string NameCompany, string Name, string Phone, string Email,int ProveedoresID)
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

        public void DeleteProvider(int ProveedoresID)
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
        #endregion

        #region "Functions ATM"
        public List<DataProductsATM> GetProductsLike(string value, int process)
        {
            List<DataProductsATM> data = new List<DataProductsATM>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (process == 1)
                    {
                        command.CommandText = "SELECT * FROM Products WHERE Ref LIKE '%" + value + "%'";
                    }
                    else
                    {
                        command.CommandText = "SELECT * FROM Products WHERE Nombre LIKE '%" + value + "%'";
                    }
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        DataProductsATM oDatos = new DataProductsATM();
                        oDatos.IdProduct = leer.GetInt32(0);
                        oDatos.Ref = leer.GetString(1);
                        oDatos.Nombre = leer.GetString(2);
                        oDatos.PriceSale = leer.GetInt32(7);
                        data.Add(oDatos);
                    }
                }
            }
            return data;
        }
        #endregion
    }
}
