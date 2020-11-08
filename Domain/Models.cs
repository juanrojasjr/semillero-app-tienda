using System;
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
        public DataTable GetUser()
        {
            DataTable tabla = new DataTable();
            tabla = oDataConsult.GetUser();
            return tabla;
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

        public int AddDataStore(string namestore, string nameowner, string phone, string address)
        {
            return oDataConsult.AddDataStore(namestore, nameowner, phone, address);
        }
        #endregion

        #region "Functions ATM"
        public List<DataProductsATM> GetProductsATM(string word)
        {
            return oDataConsult.GetProductsLike(word);
        }
        #endregion

        #region "Functions Providers"
        public DataTable GetProvider()
        {
            DataTable tblProviders = new DataTable();
            tblProviders = oDataConsult.GetProvider();
            return tblProviders;
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
    }


}
