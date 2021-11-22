CREATE TABLE [dbo].[Orden]
(
	[IdOrden] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Orden PRIMARY KEY CLUSTERED([IdOrden]),
	[IdProducto] INT NOT NULL CONSTRAINT FK_Orden_Producto FOREIGN KEY([IdProducto]) REFERENCES dbo.Producto([IdProducto]), 
    [CantidadProducto] int NOT NULL,
    [Estado] BIT NULL
)WITH (DATA_COMPRESSION = PAGE)
GO

