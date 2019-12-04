CREATE PROCEDURE CreateProduct
(
	@Nombre varchar (70),
	@Cantidad int
)
AS
	BEGIN TRY  
		BEGIN TRAN
			INSERT INTO PRODUCTO (Nombre, Cantidad) values (@Nombre, @Cantidad);
		COMMIT TRAN;
	END TRY  
	BEGIN CATCH  
		 ROLLBACK TRAN;
		 THROW;
	END CATCH  
GO
CREATE PROCEDURE ReadProduct
AS
	BEGIN
		Select  IdProducto, Nombre, Cantidad from producto;
	END
GO
create PROCEDURE UpdateProduct
(
	@IdProducto  int,
	@Nombre varchar (70),
	@Cantidad int
)
AS
	BEGIN TRY  
		BEGIN TRAN
			update producto set Nombre = @Nombre, Cantidad = @Cantidad where IdProducto = @IdProducto;
		COMMIT TRAN;
	END TRY  
	BEGIN CATCH  
		 ROLLBACK TRAN;
		 THROW;
	END CATCH  
GO
create PROCEDURE DeleteProduct
(
	@IdProducto  int
)
AS
	BEGIN TRY  
		BEGIN TRAN
				delete producto where IdProducto = @IdProducto;
		COMMIT TRAN;
	END TRY  
	BEGIN CATCH  
		 ROLLBACK TRAN;
		 THROW;
	END CATCH  