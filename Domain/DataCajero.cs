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
        FunCajero ca = new FunCajero();
        public List<datos> funcion(string value)
        {
            return ca.Get(value);
        }
    }
}
