using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using static DataAccess.DataProviders;

namespace Domain
{
    public class Agr_Providers
    {
        DataProviders prov = new DataProviders();

        public DataTable GetProvider()
        {
            DataTable tabla = new DataTable();
            tabla = prov.GetProvider();
            return tabla;
        }

        public void AddProvider(string NameCompany, string Name, string Phone, string Email)
        {
            prov.AddProvider(NameCompany, Name, Phone, Email);
        }

        public void EditProvider(string NameCompany, string Name, string Phone, string Email,string ProveedoresID)
        {
            prov.EditProvider(NameCompany, Name, Phone, Email, Convert.ToInt32(ProveedoresID));
        }

        public void DeleteProvider(string ProveedoresID)
        {
            prov.DeleteProvider(Convert.ToInt32(ProveedoresID));
        }


        public List<datospr> Getpr(string value)
        {
            return prov.Getpr(value);
        }

    }
}
