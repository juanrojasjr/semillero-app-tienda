create database MyCompany
go

use MyCompany
go

CREATE TABLE [dbo].[Bills](
	[IdBill] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[Seller] [nvarchar](50) NULL,
	[PriceTotal] [float] NULL,
	[Products] [text] NULL,
	[PriceChange] [float] NULL,
	[PriceRecep] [float] NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[IdBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[DataProviders](
	[ProveedoresID] [int] IDENTITY(1,1) NOT NULL,
	[NameCompany] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProveedoresID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DataStore](
	[idStore] [int] IDENTITY(1,1) NOT NULL,
	[NameStore] [nvarchar](100) NULL,
	[NameOwner] [nvarchar](100) NULL,
	[Phone] [nvarchar](10) NULL,
	[Address] [nvarchar](100) NULL,
	[Nit] [nchar](20) NULL,
 CONSTRAINT [PK_DataStore] PRIMARY KEY CLUSTERED 
(
	[idStore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Products](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[Ref] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Categoria] [nvarchar](50) NULL,
	[Stock] [int] NULL,
	[CanMin] [int] NULL,
	[PriceProv] [float] NULL,
	[PriceSale] [float] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Shopping](
	[IdShopping] [int] IDENTITY(1,1) NOT NULL,
	[IdProducts] [int] NULL,
	[Stock] [int] NULL,
	[PriceBuy] [float] NULL,
	[PriceSale] [float] NULL,
	[PriceTotal] [float] NULL,
	[NumBill] [int] NULL,
	[IdProvider] [int] NULL,
 CONSTRAINT [PK_Shopping] PRIMARY KEY CLUSTERED 
(
	[IdShopping] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Shopping]  WITH CHECK ADD  CONSTRAINT [FK_Shopping_DataProviders] FOREIGN KEY([IdProvider])
REFERENCES [dbo].[DataProviders] ([ProveedoresID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Shopping] CHECK CONSTRAINT [FK_Shopping_DataProviders]
GO

ALTER TABLE [dbo].[Shopping]  WITH CHECK ADD  CONSTRAINT [FK_Shopping_Products] FOREIGN KEY([IdProducts])
REFERENCES [dbo].[Products] ([IdProduct])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Shopping] CHECK CONSTRAINT [FK_Shopping_Products]
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[UserPass] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

insert into Users values ('admin','admin','Juan','Rojas','Administrator','juandarojas01@gmail.com')
insert into Users values ('user','user','Pedro','Ramires','User','soportinjap@gmail.com')
GO