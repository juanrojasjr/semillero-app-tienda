using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class DataCajero
    {
        private FunCajero products = new FunCajero();

        public DataTable getProducts(string data)
        {
            DataTable tabla = new DataTable();
            tabla = products.getProduct(data);
            return tabla;
        }
    }
}
