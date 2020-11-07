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

        public void InsertarUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email)
        {
            users.Insertar(LoginName, UserPass, FirstName, LastName, Position, Email);
        }

        public void EditarUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email, string UserID)
        {
            users.Editar(LoginName, UserPass, FirstName, LastName, Position, Email, Convert.ToInt32(UserID));
        }

        public void EliminarUser(string UserID)
        {
            users.Eliminar(Convert.ToInt32(UserID));
        }
    }

    
}
