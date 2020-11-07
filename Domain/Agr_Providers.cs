using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace Domain
{
    public class Agr_Providers
    {
        private DataProviders prov = new DataProviders();

        public DataTable MostrarProv()
        {
            DataTable tabla = new DataTable();
            tabla = prov.Mostrar();
            return tabla;
        }

        public void InsertarProv(string NameCompany, string Name, string Phone, string Email)
        {
            prov.Insertar(NameCompany, Name, Phone, Email);
        }

        public void EditarPov(string NameCompany, string Name, string Phone, string Email,string ProveedoresID)
        {
            prov.Editar(NameCompany, Name, Phone, Email, Convert.ToInt32(ProveedoresID));
        }

        public void EliminarProv(string ProveedoresID)
        {
            prov.Eliminar(Convert.ToInt32(ProveedoresID));
        }
    }
}
