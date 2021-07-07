create database MyCompany
go

use MyCompany
go

CREATE TABLE [dbo].[Bills](
	[IdBill] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[Seller] [nvarchar](50) NULL,
	[PriceTotal] [float] NULL,
	[Products] [text] NULL,
	[PriceChange] [float] NULL,
	[PriceRecep] [float] NULL)
GO

CREATE TABLE [dbo].[DataProviders](
	[ProveedoresID] [int] IDENTITY(1,1) NOT NULL,
	[NameCompany] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL)
GO

CREATE TABLE [dbo].[DataStore](
	[idStore] [int] IDENTITY(1,1) NOT NULL,
	[NameStore] [nvarchar](100) NULL,
	[NameOwner] [nvarchar](100) NULL,
	[Phone] [nvarchar](10) NULL,
	[Address] [nvarchar](100) NULL,
	[Nit] [nchar](20) NULL)
GO

CREATE TABLE [dbo].[Products](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[Ref] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Categoria] [nvarchar](50) NULL,
	[Stock] [int] NULL,
	[CanMin] [int] NULL,
	[PriceProv] [float] NULL,
	[PriceSale] [float] NULL
 )
GO

CREATE TABLE [dbo].[Shopping](
	[IdShopping] [int] IDENTITY(1,1) NOT NULL,
	[IdProducts] [int] NULL,
	[Stock] [int] NULL,
	[PriceBuy] [float] NULL,
	[PriceSale] [float] NULL,
	[PriceTotal] [float] NULL,
	[NumBill] [int] NULL,
	[IdProvider] [int] NULL)
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[UserPass] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL)
GO

-- Agregar usuarios por defecto
insert into [dbo].[Users] values ('admin','admin','usuario','principal','Administrator','correo@ejemplo.com')
GO

insert into [dbo].[Users] values ('cajero','cajero','cajero','principal','User','correo@ejemplo.com')
GO

-- Agregar proveedores de ejemplo
INSERT INTO [dbo].[DataProviders] VALUES ('Compañia 1','Juan Carlos','3101234567','correo@ejemplo.com')
GO
INSERT INTO [dbo].[DataProviders] VALUES ('Compañia 2','María Fernandez','3101234567','correo@ejemplo.com')
GO

INSERT INTO [dbo].[Products] VALUES(1,'Producto 1','Categoria 1',100,10,1000,2500)
GO

INSERT INTO [dbo].[Products] VALUES(2,'Producto 2','Categoria 1',100,10,1000,2500)
GO