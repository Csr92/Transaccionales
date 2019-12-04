CREATE TABLE PRODUCTO
(
	IdProducto  int Identity(1,1) primary Key,
	Nombre varchar (70),
	Cantidad int
)
GO
CREATE TABLE Cliente
(
	IdCliente  int Identity(1,1) primary Key,
	TipoDocumento char (3),
	NumeroDocumento varchar (70),
	Nombre varchar (100),
	Direccion varchar (100)
)
GO
CREATE TABLE Movimiento
(
	Id  int Identity(1,1) primary Key,
	IdProducto  int FOREIGN KEY REFERENCES PRODUCTO(IdProducto),
	Cantidad int,
	TipoMovimiento char (1),
	FechaMov Datetime
)
GO