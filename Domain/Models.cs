﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;
using System.Data;
using static DataAccess.DataConsult;

namespace Domain
{
    public class Models
    {
        //OBJECT COMMON
        DataConsult oDataConsult = new DataConsult();

        #region "Functions Users"
        public DataTable GetUsers()
        {
            DataTable tabla = oDataConsult.GetUsers();
            return tabla;
        }

        public List<DataUser> GetUser(string value)
        {
            return oDataConsult.GetUser(value);
        }

        public int AddUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email)
        {
            return oDataConsult.AddUser(LoginName, UserPass, FirstName, LastName, Position, Email);
        }

        public int SetUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email, string UserID)
        {
            return oDataConsult.SetUser(LoginName, UserPass, FirstName, LastName, Position, Email, Convert.ToInt32(UserID));
        }

        public int DeleteUser(string UserID)
        {
            return oDataConsult.DeleteUser(Convert.ToInt32(UserID));
        }

        public bool LoginUser(string user, string pass)
        {
            return oDataConsult.Login(user, pass);
        }

        #endregion

        #region "Functions DataStore"
        public bool GetDataStore()
        {
            return oDataConsult.GetDataStore();
        }

        public int AddDataStore(string namestore, string nameowner, string phone, string address, string nit)
        {
            return oDataConsult.AddDataStore(namestore, nameowner, phone, address, nit);
        }
        #endregion

        #region "Functions Products"
        public DataTable GetProductsLike(string word, int typeSearch)
        {
            return oDataConsult.GetProductsLike(word, typeSearch);
        }

        public DataTable GetProduct()
        {
            DataTable tabla = oDataConsult.GetProduct();
            return tabla;
        }

        public void AddProduct(string Ref, string Nombre, string Categoria, string Stock, string CantMin, string PriceProv, string PriceSale)
        {
            oDataConsult.AddProduct(Convert.ToInt32(Ref), Nombre, Categoria, Convert.ToInt32(Stock), Convert.ToInt32(CantMin), Convert.ToSingle(PriceProv), Convert.ToSingle(PriceSale));
        }

        public void SetProduct(string Ref, string Nombre, string Categoria, string Stock, string CantMin, string PriceProv, string PriceSale, string IdProduct)
        {
            oDataConsult.SetProduct(Convert.ToInt32(Ref), Nombre, Categoria, Convert.ToInt32(Stock), Convert.ToInt32(CantMin), Convert.ToSingle(PriceProv), Convert.ToSingle(PriceSale), Convert.ToInt32(IdProduct));
        }

        public void SetProduct(string Stock, string PriceProv, string PriceSale, string IdProduct)
        {
            oDataConsult.SetProduct(Convert.ToInt32(Stock), Convert.ToSingle(PriceProv), Convert.ToSingle(PriceSale), Convert.ToInt32(IdProduct));
        }

        public void SetProduct(string Stock, string IdProduct)
        {
            oDataConsult.SetProduct(Convert.ToInt32(Stock), Convert.ToInt32(IdProduct));
        }

        public void DeleteProduct(string IdProduct)
        {
            oDataConsult.DeleteProduct(Convert.ToInt32(IdProduct));
        }
        #endregion

        #region "Functions Providers"
        public DataTable GetProviders()
        {
            DataTable tblProviders = new DataTable();
            tblProviders = oDataConsult.GetProviders();
            return tblProviders;
        }

        public List<DataProvider> GetProvider(string value)
        {
            return oDataConsult.GetProvider(value);
        }

        public void AddProvider(string NameCompany, string Name, string Phone, string Email)
        {
            oDataConsult.AddProvider(NameCompany, Name, Phone, Email);
        }

        public void EditProvider(string NameCompany, string Name, string Phone, string Email, string ProveedoresID)
        {
            oDataConsult.EditProvider(NameCompany, Name, Phone, Email, Convert.ToInt32(ProveedoresID));
        }

        public void DeleteProvider(string ProveedoresID)
        {
            oDataConsult.DeleteProvider(Convert.ToInt32(ProveedoresID));
        }
        #endregion

        #region "Functions Bills"
        public DataTable GetBills()
        {
            DataTable tblProviders = oDataConsult.GetBills();
            return tblProviders;
        }

        public List<DataBills> GetBill(string value, string dStar, string dEnd, int proccess)
        {
            return oDataConsult.GetBill(value, dStar, dEnd, proccess);
        }

        public void AddBill(string Date, string Seller, string PriceTotal, string Products, string PriceChange, string PriceRecep)
        {
            oDataConsult.AddBill(Date, Seller, PriceTotal, Products, PriceChange, PriceRecep);
        }

        public int NumberBillsInitial()
        {
            return oDataConsult.GetNumberBillsInitial();
        }
        #endregion

        #region "Functions Shopping"
        public DataTable GetShoppings()
        {
            DataTable tblShopping = oDataConsult.GetShoppings();
            return tblShopping;
        }
        public void AddShopping(string IdProduct, string Stock, string PriceBuy, string PriceSale, string PriceTotal, string NumBill, string IdProvider)
        {
            oDataConsult.AddShopping(Convert.ToInt32(IdProduct), Convert.ToInt32(Stock), Convert.ToDouble(PriceBuy), Convert.ToDouble(PriceSale), Convert.ToDouble(PriceTotal), Convert.ToInt32(NumBill), Convert.ToInt32(IdProvider));
        }
        #endregion
    }
}
