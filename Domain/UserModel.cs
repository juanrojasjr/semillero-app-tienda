using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;
using System.Data;
using static DataAccess.UserDao;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        FunDataStore store = new FunDataStore();
        public bool dataStore()
        {
            return store.getDataStore();
        }
        public int addDataStore(string namestore, string nameowner, string phone, string address)
        {
            return store.addDataStore(namestore, nameowner, phone, address);
        }

        UserDao users = new UserDao();

        public DataTable GetUser()
        {
            DataTable tabla = new DataTable();
            tabla = users.GetUser();
            return tabla;
        }

        public void AddUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email)
        {
           users.AddUser(LoginName, UserPass, FirstName, LastName, Position, Email);
        }

        public void SetUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email, string UserID)
        {
            users.SetUser(LoginName, UserPass, FirstName, LastName, Position, Email, Convert.ToInt32(UserID));
        }

        public void DeleteUser(string UserID)
        {
            users.DeleteUser(Convert.ToInt32(UserID));
        }

        public List<datosus> Getus(string value)
        {
            return users.Getus(value);
        }
    }

    
}
