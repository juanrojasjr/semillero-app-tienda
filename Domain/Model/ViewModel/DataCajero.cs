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
        public int IdProduct { get; set; }
        public string Ref { get; set; }
        public string Nombre { get; set; }
        public int PriceSale { get; set; }

    }
}
