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
    public class FunDataStore: ConnectionToSql
    {

        public int addDataStore(string namestore, string nameowner, string phone, string address)
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
                    DataStore.namestore = namestore;
                    DataStore.nameowner = nameowner;
                    DataStore.phone = phone;
                    DataStore.address = address;

                    return command.ExecuteNonQuery();
                }
            }
        }

        public bool getDataStore()
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
                            DataStore.namestore = reader.GetString(1);
                            DataStore.nameowner = reader.GetString(2);
                            DataStore.phone = reader.GetString(3);
                            DataStore.address = reader.GetString(4);
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
