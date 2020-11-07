﻿using System;
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
        public List<datos> Get(string value)
        {
            List<datos> data = new List<datos>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Products WHERE Nombre LIKE '%"+value+"%'";
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        datos oDatos = new datos();
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
    }

    public class datos
    {
        public int IdProduct { get; set; }
        public string Ref { get; set; }
        public string Nombre { get; set; }
        public int PriceSale { get; set; }
    }
}