﻿using Common.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataConsult : ConnectionToSql
    {
        #region "Functions User"
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where LoginName=@user and UserPass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        
        public DataTable GetUsers()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader view;
                    DataTable tblUsers = new DataTable();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users";
                    view = command.ExecuteReader();
                    tblUsers.Load(view);
                    return tblUsers;
                }
            }
        }

        public List<DataUser> GetUser(string value)
        {
            List<DataUser> dataus = new List<DataUser>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName LIKE '%" + value + "%'";
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        DataUser oDataUser = new DataUser();
                        oDataUser.UserID = leer.GetInt32(0);
                        oDataUser.LoginName = leer.GetString(1);
                        oDataUser.UserPass = leer.GetString(2);
                        oDataUser.FirstName = leer.GetString(3);
                        oDataUser.LastName = leer.GetString(4);
                        oDataUser.Position = leer.GetString(5);
                        oDataUser.Email = leer.GetString(6);
                        dataus.Add(oDataUser);
                    }
                }
            }
            return dataus;
        }

        public int AddUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Users VALUES (@LoginName, @UserPass, @FirstName, @LastName, @Position, @Email)";
                    command.Parameters.AddWithValue("@LoginName", LoginName);
                    command.Parameters.AddWithValue("@UserPass", UserPass);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int SetUser(string LoginName, string UserPass, string FirstName, string LastName, string Position, string Email, int UserID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Users SET LoginName=@LoginName,UserPass=@UserPass,FirstName=@FirstName,LastName=@LastName,Position=@Position,Email=@Email WHERE UserID = @UserID";
                    command.Parameters.AddWithValue("@LoginName", LoginName);
                    command.Parameters.AddWithValue("@UserPass", UserPass);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Position", Position);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int DeleteUser(int UserID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Users WHERE UserID = @UserID";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    return command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region "Functions DataStore"
        public int AddDataStore(string namestore, string nameowner, string phone, string address, string nit)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DataStore VALUES (@namestore, @nameowner, @phone, @address, @nit)";
                    command.Parameters.AddWithValue("@namestore", namestore);
                    command.Parameters.AddWithValue("@nameowner", nameowner);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@nit", nit);
                    command.CommandType = CommandType.Text;

                    //Cargar datos obtenidos en la clase/caché
                    DataStoreCache.Namestore = namestore;
                    DataStoreCache.Nameowner = nameowner;
                    DataStoreCache.Phone = phone;
                    DataStoreCache.Address = address;
                    DataStoreCache.Nit = nit;

                    return command.ExecuteNonQuery();
                }
            }
        }

        public bool GetDataStore()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from DataStore";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataStoreCache.Namestore = reader.GetString(1);
                            DataStoreCache.Nameowner = reader.GetString(2);
                            DataStoreCache.Phone = reader.GetString(3);
                            DataStoreCache.Address = reader.GetString(4);
                            DataStoreCache.Nit = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        #endregion

        #region "Functions Provider"
        public DataTable GetProviders()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ProveedoresID, NameCompany 'Compañía', Name 'Nombre', Phone 'Teléfono', Email 'Correo electrónico' FROM DataProviders";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        public List<DataProvider> GetProvider(string value)
        {
            List<DataProvider> datapr = new List<DataProvider>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ProveedoresID, NameCompany 'Compañía', Name 'Nombre', Phone 'Teléfono', Email 'Correo electrónico' FROM DataProviders WHERE NameCompany LIKE '%" + value + "%'";
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        DataProvider oDatospr = new DataProvider();
                        oDatospr.ProveedoresID = leer.GetInt32(0);
                        oDatospr.NameCompany = leer.GetString(1);
                        oDatospr.Nombre = leer.GetString(2);
                        oDatospr.Phone = leer.GetString(3);
                        oDatospr.Email = leer.GetString(4);
                        datapr.Add(oDatospr);
                    }
                }
            }
            return datapr;
        }

        public void AddProvider(string NameCompany,string Name,string Phone,string Email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DataProviders(NameCompany, Name, Phone, Email) VALUES (@NameCompany, @Name, @Phone, @Email)";
                    command.Parameters.AddWithValue("@NameCompany", NameCompany);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditProvider(string NameCompany, string Name, string Phone, string Email,int ProveedoresID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update DataProviders set NameCompany=@NameCompany,Name=@Name,Phone=@Phone,Email=@Email where ProveedoresID = @ProveedoresID";
                    command.Parameters.AddWithValue("@NameCompany", NameCompany);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@ProveedoresID", ProveedoresID);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProvider(int ProveedoresID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from DataProviders where ProveedoresID = @ProveedoresID";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ProveedoresID",ProveedoresID);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region "Functions Products"
        public DataTable GetProductsLike(string word, int typeSearch)
        {
            DataTable data = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (typeSearch == 1)
                    {
                        command.CommandText = "SELECT IdProduct, Ref 'Ref.', Nombre, Categoria, Stock Inventario, CanMin 'Inv. Min', PriceProv 'P. Proveedor', PriceSale 'P. Venta' FROM Products WHERE Ref LIKE '%" + word + "%'";
                    }
                    else
                    {
                        command.CommandText = "SELECT IdProduct, Ref 'Ref.', Nombre, Categoria, Stock Inventario, CanMin 'Inv. Min', PriceProv 'P. Proveedor', PriceSale 'P. Venta' FROM Products WHERE Nombre LIKE '%" + word + "%'";
                    }
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    data.Load(leer);
                }
            }
            return data;
        }

        public DataTable GetProduct()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdProduct, Ref 'Ref.', Nombre, Categoria, Stock Inventario, CanMin 'Inv. Min', PriceProv 'P. Proveedor', PriceSale 'P. Venta' FROM Products";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        public void AddProduct(int Ref, string Nombre, string Categoria, int Stock, int CantMin, float PriceProv, float PriceSale)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Products VALUES (@ref, @nombre, @categoria, @stock, @cantmin, @priceprov, @pricesale)";
                    command.Parameters.AddWithValue("@ref", Ref);
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@categoria", Categoria);
                    command.Parameters.AddWithValue("@stock", Stock);
                    command.Parameters.AddWithValue("@cantmin", CantMin);
                    command.Parameters.AddWithValue("@priceprov", PriceProv);
                    command.Parameters.AddWithValue("@pricesale", PriceSale);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SetProduct(int Ref, string Nombre, string Categoria, int Stock, int CantMin, float PriceProv, float PriceSale, int IdProduct)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Products SET Ref=@ref, Nombre=@nombre, Categoria=@categoria, Stock=@stock, CanMin=@canmin, PriceProv=@priceprov, PriceSale=@pricesale WHERE IdProduct = @idproduct";
                    command.Parameters.AddWithValue("@ref", Ref);
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@categoria", Categoria);
                    command.Parameters.AddWithValue("@stock", Stock);
                    command.Parameters.AddWithValue("@canmin", CantMin);
                    command.Parameters.AddWithValue("@priceprov", PriceProv);
                    command.Parameters.AddWithValue("@pricesale", PriceSale);
                    command.Parameters.AddWithValue("@idproduct", IdProduct);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SetProduct(int Stock, float PriceProv, float PriceSale, int IdProduct)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Products SET Stock=@stock, PriceProv=@priceprov, PriceSale=@pricesale WHERE IdProduct = @idproduct";
                    command.Parameters.AddWithValue("@stock", Stock);
                    command.Parameters.AddWithValue("@priceprov", PriceProv);
                    command.Parameters.AddWithValue("@pricesale", PriceSale);
                    command.Parameters.AddWithValue("@idproduct", IdProduct);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SetProduct(int Stock, int IdProduct)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Products SET Stock=@stock WHERE IdProduct = @idproduct";
                    command.Parameters.AddWithValue("@stock", Stock);
                    command.Parameters.AddWithValue("@idproduct", IdProduct);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int IdProduct)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from Products where IdProduct = @idproduct";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idproduct", IdProduct);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region "Functions Bills"
        public DataTable GetBills()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdBill, Date 'Fecha', Seller 'Vendedor', PriceTotal 'P. Total', Products 'Productos', PriceChange 'Cambio', PriceRecep 'Pago' FROM Bills ORDER BY Date DESC";
                    leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        public List<DataBills> GetBill(string value, string dStar, string dEnd, int proccess)
        {
            List<DataBills> dataBills = new List<DataBills>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    if (proccess==1)
                    {
                        //Buscar por fecha
                        command.CommandText = "SELECT IdBill '# Factura', Date 'Fecha', Seller 'Vendedor', PriceTotal 'P. Total', Products 'Productos', PriceChange 'Cambio', PriceRecep 'Pago' FROM Bills WHERE Date BETWEEN @dStart AND @dEnd";
                        command.Parameters.AddWithValue("@dStart", dStar);
                        command.Parameters.AddWithValue("@dEnd", dEnd);
                    }
                    else
                    {
                        //Buscar por número de factura
                        command.CommandText = "SELECT IdBill '# Factura', Date 'Fecha', Seller 'Vendedor', PriceTotal 'P. Total', Products 'Productos', PriceChange 'Cambio', PriceRecep 'Pago' FROM Bills WHERE IdBill LIKE '%" + value + "%'";
                    }
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        DataBills oDataBills = new DataBills();
                        oDataBills.Factura = leer.GetInt32(0);
                        oDataBills.Fecha = leer.GetDateTime(1);
                        oDataBills.Vendedor = leer.GetString(2);
                        oDataBills.Total = leer.GetDouble(3);
                        oDataBills.Productos = leer.GetString(4);
                        oDataBills.Devuelto = leer.GetDouble(5);
                        oDataBills.Recibido = leer.GetDouble(6);
                        dataBills.Add(oDataBills);
                    }
                }
            }
            return dataBills;
        }

        public void AddBill(string Date, string Seller, string PriceTotal, string Products, string PriceChange, string PriceRecep)
        {
            float fPriceTotal = Convert.ToSingle(PriceTotal);
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Bills VALUES (@Date, @Seller, @PriceTotal, @Products, @PriceChange, @PriceRecep)";
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Seller", Seller);
                    command.Parameters.AddWithValue("@PriceTotal", fPriceTotal);
                    command.Parameters.AddWithValue("@Products", Products);
                    command.Parameters.AddWithValue("@PriceChange", PriceChange);
                    command.Parameters.AddWithValue("@PriceRecep", PriceRecep);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public int GetNumberBillsInitial()
        {
            int value = 0;
            //SELECT IdBill FROM Bills
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdBill FROM Bills";
                    command.CommandType = CommandType.Text;
                    SqlDataReader leer = command.ExecuteReader();
                    while (leer.Read())
                    {
                        value = leer.GetInt32(0);
                    }
                }
            }
            return value;
        }
        #endregion

        #region "Functions Shopping"
        public DataTable GetShoppings()
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT DISTINCT C.Nombre 'Producto', A.Stock 'U_Compradas', A.PriceBuy 'Compra', A.PriceSale 'Venta', A.PriceTotal C_Total, A.NumBill Factura, B.NameCompany Proveedor " +
                        "FROM Shopping A INNER JOIN DataProviders B ON A.IdProvider = B.ProveedoresID INNER JOIN Products C ON A.IdProducts = C.IdProducT";
                    SqlDataReader leer = command.ExecuteReader();
                    tabla.Load(leer);
                    return tabla;
                }
            }
        }

        public void AddShopping(int IdProduct, int Stock, double PriceBuy, double PriceSale, double PriceTotal, int NumBill, int IdProvider)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Shopping VALUES(@IdProduct, @Stock, @PriceBuy, @PriceSale, @PriceTotal, @NumBill, @IdProvider)";
                    command.Parameters.AddWithValue("@IdProduct", IdProduct);
                    command.Parameters.AddWithValue("@Stock", Stock);
                    command.Parameters.AddWithValue("@PriceBuy", PriceBuy);
                    command.Parameters.AddWithValue("@PriceSale", PriceSale);
                    command.Parameters.AddWithValue("@PriceTotal", PriceTotal);
                    command.Parameters.AddWithValue("@NumBill", NumBill);
                    command.Parameters.AddWithValue("@IdProvider", IdProvider);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }

    public class DataUser
    {
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string UserPass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
    }

    public class DataProvider
    {
        public int ProveedoresID { get; set; }
        public string NameCompany { get; set; }
        public string Nombre { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class DataBills
    {
        public int Factura { get; set; }
        public DateTime Fecha { get; set; }
        public string Vendedor { get; set; }
        public double Total { get; set; }
        public string Productos { get; set; }
        public double Devuelto { get; set; }
        public double Recibido { get; set; }
    }

    public class DataProducts
    {
        public int IdProduct { get; set; }
        public int Ref { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public double PriceSale { get; set; }
        public double PriceProv { get; set; }
    }
}
