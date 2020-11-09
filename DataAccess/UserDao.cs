using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao: ConnectionToSql
    {
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
                            UserLogin.idUser = reader.GetInt32(0);
                            UserLogin.firstName = reader.GetString(3);
                            UserLogin.lastName = reader.GetString(4);
                            UserLogin.position = reader.GetString(5);
                            UserLogin.email = reader.GetString(6);
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
        DataTable tabla = new DataTable();

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
                    tabla.Load(view);
                    return tabla;
                }
            }
        }

        public void AddUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email)
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
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SetUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email, int UserID)
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
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int UserID)
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
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<datosus> Getus(string value)
        {
            List<datosus> dataus = new List<datosus>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName LIKE '%" + value + "%'";
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        datosus oDatosus = new datosus();
                        oDatosus.UserID = leer.GetInt32(0);
                        oDatosus.LoginName = leer.GetString(1);
                        oDatosus.UserPass = leer.GetString(2);
                        oDatosus.FirstName = leer.GetString(3);
                        oDatosus.LastName = leer.GetString(4);
                        oDatosus.Position = leer.GetString(5);
                        oDatosus.Email = leer.GetString(6);
                        dataus.Add(oDatosus);
                    }
                }
            }
            return dataus;
        }

        public class datosus
        {
            public int UserID { get; set; }
            public string LoginName { get; set; }
            public string UserPass { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
        }
    }
}
