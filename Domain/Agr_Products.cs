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

        public void AddProduct(string Ref, string Nombre, string Categoria, string Stock, string CantMin, string PriceProv, string PriceSale)
        {
            product.AddProduct(Convert.ToInt32(Ref), Nombre, Categoria, Convert.ToInt32(Stock), Convert.ToInt32(CantMin), Convert.ToSingle(PriceProv), Convert.ToSingle(PriceSale));
        }

        public void EditProduct(string Ref, string Nombre, string Categoria, string Stock, string CantMin, string PriceProv, string PriceSale, string IdProduct)
        {
            product.EditProduct(Convert.ToInt32(Ref), Nombre, Categoria, Convert.ToInt32(Stock), Convert.ToInt32(CantMin), Convert.ToSingle(PriceProv), Convert.ToSingle(PriceSale), Convert.ToInt32(IdProduct));
        }

        public void DeleteProduct(string IdProduct)
        {
            product.DeleteProduct(Convert.ToInt32(IdProduct));
        }
    }

}

