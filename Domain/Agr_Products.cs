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
     public class Agr_Products
    {
        private DataProduct product = new DataProduct();

        public DataTable GetProduct()
        {
            DataTable tabla = new DataTable();
            tabla = product.GetProduct();
            return tabla;
        }

        public void AddProduct(string nombre_producto, string Descripcion, string Marca, string Precio_fabrica, string Precio_venta, string Unidades)
        {
            product.AddProduct(nombre_producto, Descripcion, Marca, Convert.ToSingle(Precio_fabrica), Convert.ToSingle(Precio_venta), Convert.ToInt32(Unidades));
        }

        public void EditProduct(string nombre_producto, string Descripcion, string Marca, string Precio_fabrica, string Precio_venta, string Unidades, string id_producto)
        {
            product.EditProduct(nombre_producto, Descripcion, Marca, Convert.ToSingle(Precio_fabrica), Convert.ToSingle(Precio_venta), Convert.ToInt32(Unidades), Convert.ToInt32(id_producto));
        }

        public void DeleteProduct(string id_producto)
        {
            product.DeleteProduct(Convert.ToInt32(id_producto));
        }
    }

}

