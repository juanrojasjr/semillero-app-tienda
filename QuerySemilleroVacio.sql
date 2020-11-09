CREATE DATABASE [MyCompany]
GO

USE [MyCompany]
GO

CREATE TABLE [Bills](
	[IdBill] [int] IDENTITY(1,1) NOT NULL,
	[Date] [nvarchar](max) NULL,
	[Seller] [nvarchar](50) NULL,
	[PriceTotal] [float] NULL,
	[Products] [text] NULL,
	[PriceChange] [float] NULL,
	[PriceRecep] [float] NULL)
GO

CREATE TABLE [DataProviders](
	[ProveedoresID] [int] IDENTITY(1,1) NOT NULL,
	[NameCompany] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL)
GO

CREATE TABLE [DataStore](
	[idStore] [int] IDENTITY(1,1) NOT NULL,
	[NameStore] [nvarchar](100) NULL,
	[NameOwner] [nvarchar](100) NULL,
	[Phone] [nvarchar](10) NULL,
	[Address] [nvarchar](100) NULL)
GO

CREATE TABLE [Products](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[Ref] [nvarchar](50) NULL,
	[Nombre] [nvarchar](50) NULL,
	[Categoria] [nvarchar](50) NULL,
	[Stock] [int] NULL,
	[CanMin] [int] NULL,
	[PriceProv] [int] NULL,
	[PriceSale] [int] NULL)
GO

CREATE TABLE [Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[UserPass] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL)
GO

INSERT INTO Users VALUES('admin','admin','Ingenieros','Unitec','Administrator','contacto@correo.com')
INSERT INTO Users VALUES('user','user','Ingenieros','Unitec','Cajero','contacto@correo.com')