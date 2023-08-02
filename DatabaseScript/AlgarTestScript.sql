USE [master]
GO


----NOTA: LOS ARCHIVOS DE BASE DE DATOS SERAN CREADOS EN C:\MSSQL\DATA\ LA RUTA DEBE EXISTIR EN EL SISTEMA OPERATIVO
CREATE DATABASE [AlgarTiendaCiclismo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AlgarTiendaCiclismo', FILENAME = N'C:\MSSQL\DATA\AlgarTiendaCiclismo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AlgarTiendaCiclismo_log', FILENAME = N'C:\MSSQL\DATA\AlgarTiendaCiclismo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

use [AlgarTiendaCiclismo]
GO

----CREATE TABLES
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nchar](300) NULL,
	[ProductReference] [nchar](300) NULL,
	[ProductPrice] [numeric](18, 3) NULL,
	[UrlImage] [nvarchar](200) NOT NULL,
	[ProductDescription] [nvarchar](2048) NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Purchase](
	[purchaseId] [int] NOT NULL,
	[purchaseDate] [datetime] NOT NULL,
	[customerName] [nvarchar](300) NOT NULL,
	[customerAdrress] [nvarchar](300) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PurchaseDetail](
	[purchaseDetailId] [int] IDENTITY(1,1) NOT NULL,
	[productId] [int] NOT NULL,
	[purchaseId] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[unitPrice] [numeric](18, 3) NOT NULL,
	[TotalPrice] [numeric](18, 3) NOT NULL
) ON [PRIMARY]
GO

---CREATE STORED PROCEDURES
CREATE OR ALTER PROCEDURE GET_ALL_PRODUCTS
AS
BEGIN
	
	SELECT ProductId, ProductName, ProductReference, ProductDescription, ProductPrice, UrlImage
	FROM Product
	ORDER BY ProductId asc
	
END
GO

CREATE OR ALTER PROCEDURE INSERT_PURCHASE (
	@CustomerName nvarchar(300),
	@CustomerAddress nvarchar(300)
)
AS
BEGIN
	DECLARE @ID AS INT
	SELECT @ID = ISNULL(MAX(purchaseId) + 1,1) from Purchase 

	INSERT INTO Purchase (purchaseId, purchaseDate, customerName, customerAdrress) VALUES
	(@ID, GetDate(),@CustomerName,@CustomerAddress)


	select @ID 
END
GO
CREATE OR ALTER PROCEDURE INSERT_PURCHASE_DETAILS (
	@productId int,
	@purchaseId int, 
	@quantity int, 
	@unitPrice numeric(18,3),
	@TotalPrice numeric(18,3)
)
AS
BEGIN
	INSERT INTO PurchaseDetail (productId, purchaseId, quantity, unitPrice, TotalPrice) VALUES
	(@productId, @purchaseId, @quantity, @unitPrice, @TotalPrice)

END
GO
---INSERT SOME PRODUCTS

insert into Product values ('Casco Deportivo','432342342',5000,'https://i.ibb.co/Hdwy4w5/casco1.webp', 'El complemento necesario para tus actividades
Este casco te dará comodidad y seguridad para que puedas disfrutar de las actividades que más te gustan sin preocupaciones.')
GO
insert into Product values ('Uniforme Ciclismo Ruta','80082244',15000,'https://i.ibb.co/rymv3WD/uniforme1.webp','UNIFORMES DE CICLISMO COLOMBIA prendas de excelente calidad, con los mejores acabados.

El jersey cuenta con una tecnología DRI-FIT de secado rápido, permitiendo una buena transpiración, aliviando la sensación de humedad.
banda antideslizante en silicona, costados transpirables en tela microperforada, tres bolsillos en la parte posterior inferior. Material 100% poliéster. Cremallera completa.')


