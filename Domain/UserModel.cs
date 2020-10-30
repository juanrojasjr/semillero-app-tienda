using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;

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

    }

    
}
