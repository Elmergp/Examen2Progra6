CREATE TABLE [dbo].[Producto]
(
   [IdProducto] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Canton PRIMARY KEY CLUSTERED([IdProducto]),
	[NombreProducto] varchar(50) NULL,
	[PrecioProducto] int NOT NULL


)WITH (DATA_COMPRESSION = PAGE)
GO