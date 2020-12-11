create database concesionario
use concesionario


--Sucursal principal
CREATE TABLE Sucursal_principal
(
 IdSucursal INT PRIMARY KEY NOT NULL,
 Nombre VARCHAR(45),
 Direccion VARCHAR(45),
 Telefono INT,
 Correo VARCHAR(45),
)

--Empleados
CREATE TABLE Empleados
(
  IdEmpleados INT PRIMARY KEY NOT NULL,
  Nombre VARCHAR(45) ,
  Apellidos VARCHAR(45) ,
  FechaIngreso DATE ,
  Telefono INT ,
  Empleadoscol VARCHAR(45) ,
  Sucursal INT NOT NULL,
  CONSTRAINT FK_IdEmpleados_TBSucursalPrincipal FOREIGN KEY (IdEmpleados) REFERENCES Sucursal_principal (IdSucursal)
)

--Clientes
CREATE TABLE Clientes 
(
  IdClientes INT PRIMARY KEY NOT NULL,
  Nombre VARCHAR(45),
  apellidos VARCHAR(45),
  Telefono VARCHAR(45),
  Correo VARCHAR(45),
  Edad INT,
  Direccion VARCHAR(45),
  Sexo VARCHAR(45),
  FechaNacimiento DATE,
  RFC VARCHAR(45),
  ReferenciaUno VARCHAR(45) NOT NULL,
  ReferenciaDos VARCHAR(45) NOT NULL,
  ReferenciaTres VARCHAR(45) NOT NULL,
  NumRefUno INT NOT NULL,
  NumRedDos INT NOT NULL,
  NumRefTres INT NOT NULL,
)

--Automovil
CREATE TABLE Automoviles 
(
  IdAutomovil INT PRIMARY KEY NOT NULL,
  Marca VARCHAR(45) NOT NULL,
  Modelo VARCHAR(45) NOT NULL,
  Color VARCHAR(45) NOT NULL,
  A�o VARCHAR(45) NOT NULL,
  Serie VARCHAR(25) NOT NULL,
  FechaIngreso VARCHAR(45) NOT NULL,
  PrecioCompra INT,
  PrecioVenta INT,
  PrecioTotal INT,
  PrecioPromo INT,
  Sucursal INT NOT NULL,
  CONSTRAINT FK_SucursalAuto_TBSucursalPrincipal FOREIGN KEY (Sucursal) REFERENCES Sucursal_principal (IdSucursal)
  )


--Autopartes
CREATE TABLE Autopartes 
(
  IdAutopartes INT PRIMARY KEY NOT NULL,
  Nombre VARCHAR(45) NOT NULL,
  Modelo VARCHAR(45) NOT NULL,
  Cantidad INT NOT NULL,
  Sucursal INT NOT NULL,
  CONSTRAINT FK_SucursalPart_TBSucursalPrincipal FOREIGN KEY (Sucursal) REFERENCES Sucursal_principal (IdSucursal)
  )

--Sucursal secundaria
CREATE TABLE Sucursal_Secundaria
(
  IdSucursal_Secundaria INT PRIMARY KEY NOT NULL,
  Nombre VARCHAR(45) NOT NULL,
  Direccion VARCHAR(45) NOT NULL,
  Telefono INT NOT NULL,
  Correo VARCHAR(45) NOT NULL,
)

--Traspasos
CREATE TABLE TraspasoSaS
(
  IdTraspasoSaS INT PRIMARY KEY NOT NULL,
  SucursalEntrega INT NOT NULL,
  SucursalRecibe INT NOT NULL,
  TipoTraspaso VARCHAR(45),
  CONSTRAINT FK_SucursalRecibe_TBSucursal_principal  FOREIGN KEY (SucursalEntrega) REFERENCES Sucursal_principal (IdSucursal),
  CONSTRAINT FK_SucursalEntrega_TBSucursal_Secunadaria  FOREIGN KEY (SucursalRecibe) REFERENCES Sucursal_Secundaria (IdSucursal_Secundaria)
)

--Compra venta
CREATE TABLE Compraventa 
(
  IdCompraVenta INT PRIMARY KEY NOT NULL,
  Cliente INT,
  Fecha DATE,
  TipoFinanciamiento VARCHAR(45),
  Total Float,
  CONSTRAINT FK_Cliente_TBDClientes   FOREIGN KEY (Cliente) REFERENCES Clientes (IdClientes)
)

--Detalle compra vente
CREATE TABLE DetalleCompraVenta 
(
  IdDetalleCompraVenta INT PRIMARY KEY NOT NULL,
  Automovil INT NOT NULL,
  Cantidad INT NOT NULL,
  precio VARCHAR(45) NOT NULL,
  IdCompraventa INT NOT NULL,
  Accesorios INT NOT NULL,
  CONSTRAINT FK_ClienteDetalleCompraVenta_TBDClientes   FOREIGN KEY (Automovil) REFERENCES Automoviles (IdAutomovil),
  CONSTRAINT FK_IdCompraventa_TBDCompraVenta   FOREIGN KEY (IdCompraventa) REFERENCES Compraventa (IdCompraVenta)
  )

CREATE TABLE DetalleTraspaso 
(
  idDetalle_Traspaso INT PRIMARY KEY NOT NULL,
  IdTraspasoSAS INT NOT NULL,
  Autoparte INT NOT NULL,
  Cantidad INT NOT NULL,
  Automovil INT NOT NULL,
  CONSTRAINT FK_IdTraspasoSAS_TBDClientes   FOREIGN KEY (IdTraspasoSAS) REFERENCES TraspasoSaS (IdTraspasoSaS),
  CONSTRAINT FK_Autoparte_TBDClientes   FOREIGN KEY (Autoparte) REFERENCES Autopartes (IdAutopartes),
  CONSTRAINT FK_Automovil_TBDClientes   FOREIGN KEY (Automovil) REFERENCES Automoviles (IdAutomovil),
)


CREATE TABLE Promocion
(
   IdPromocion INT PRIMARY KEY NOT NULL,
   Cantidad_Autos INT,
   Descuento INT,
   FechaVigencia DATE
)


CREATE TABLE Rol
(
  IdRol INT PRIMARY KEY NOT NULL,
  Tipo VARCHAR(10),
  Contrase�a VARCHAR(10),
)


CREATE TABLE Accesorios
(
 IdAccesorios INT PRIMARY KEY NOT NULL,
 Nombre VARCHAR(20),
 Descripcion VARCHAR(45),
 IdAutomovil INT NOT NULL,
)

--TRIGGERS
/*Selecci�n de un autom�vil y que permita llevar un proceso de aplicaci�n de accesorios 
al seleccionar un veh�culo con caracter�sticas b�sicas*/
create trigger SeleccionVehiculo


/*Cancelaci�n de una compra que se encontraba en un proceso avanzado de adquisici�n.*/
create trigger cancelar


/*Modificaci�nde las caracter�sticas particulares de un veh�culo cuando se encuentra 
en un proceso de compra-venta y este realiza el cambio de todas las caracter�sticas...*/
create trigger modificar


/*Realizar una auditor�a de los vendedores de autos, el cual contenga, vendedor, autom�vil, 
si  este  tuvo  equipamiento especial o  no,  si  se  le  aplica  alguna  promoci�n,  si  fue
solo 1 auto o flotilla (aplica a partir de 2 autos en adelante), monto final de la venta, 
comisi�n por la apertura del cr�dito y hora/fecha de la transacci�n.*/
create trigger auditoria


/*Proceso que permita registra un nuevo modelo de autom�vil que nunca haya estado en el 
inventario.*/
create trigger registrar



