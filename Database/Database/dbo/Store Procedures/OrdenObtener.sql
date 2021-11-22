CREATE PROCEDURE [dbo].[OrdenObtener]
  @IdOrden int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     a.IdOrden,    
     a.CantidadProducto,
     a.Estado,    
     b.IdProducto,
     b.NombreProducto

   FROM Orden a
    INNER JOIN Producto b
       ON b.IdProducto= a.IdProducto
    WHERE
    (@IdOrden IS NULL OR IdOrden=@IdOrden)

END