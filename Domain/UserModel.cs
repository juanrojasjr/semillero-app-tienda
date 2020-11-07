using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;
using System.Data;

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

        private UserDao users = new UserDao();

        public DataTable MostrarUsers()
        {
            DataTable tabla = new DataTable();
            tabla = users.Mostrar();
            return tabla;
        }

        public int insertarUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email)
        {
            return users.insertar(LoginName, UserPass, FirstName, LastName, Position, Email);
        }

        public int EditarUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email, string UserID)
        {
            return users.Editar(LoginName, UserPass, FirstName, LastName, Position, Email, Convert.ToInt32(UserID));
        }

        public int EliminarUser(string UserID)
        {
            return users.Eliminar(Convert.ToInt32(UserID));
        }
    }

    
}
