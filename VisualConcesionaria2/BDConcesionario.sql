create database concesionario
use concesionario          

------------Creacion de tablas------------------------------------
--Sucursal principal

CREATE TABLE Sucursal_principal
(
 IdSucursal INT PRIMARY KEY NOT NULL,
 Nombre VARCHAR(45),
 Direccion VARCHAR(45),
 Telefono Varchar,
 Correo VARCHAR(45),
)

ALTER TABLE Administrador ALTER COLUMN  Telefono Varchar(10);

Insert into Sucursal_principal values('1','National cars','Zona rio','664123578','NationalsCarsRio@gmail.com');

Create TABLE Administrador
(
	 IdAdministrador INT PRIMARY KEY NOT NULL,
	 Nombre VARCHAR(45),
	 Direccion VARCHAR(45),
	 Telefono Varchar(10),
	 Correo VARCHAR(45),
	 Contraseña Varchar(45),
	 FechaIngreso DATE ,
	 TipoUsuario INT NOT NULL,
	 CONSTRAINT FK_Admin_TBRol FOREIGN KEY (TipoUsuario) REFERENCES Rol (IdRol),
)		

Drop Table Empleados
select * from Administrador
Insert into Administrador values('1','Jefemaestro','halo',564213,'jefe@gmail.com','12345','2020-11-02',3);


--Empleados

drop Table Empleados
CREATE TABLE Empleados
(
  IdEmpleados INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  Nombre VARCHAR(45) NOT NULL ,
  Apellidos VARCHAR(45) NOT NULL ,
  Correo Varchar (45) NOT NULL,
  PasswordEmpleado varchar(45),
  FechaNacimiento DATETIME NOT NULL, 
  FechaIngreso DATE NOT NULL ,
  Telefono Varchar(10) NOT NULL ,
  Sucursal INT NOT NULL,
  TipoUsuario INT NOT NULL,
  CONSTRAINT FK_IdRol_TBRol FOREIGN KEY (TipoUsuario) REFERENCES Rol (IdRol),
  CONSTRAINT FK_IdEmpleados_TBSucursalPrincipal FOREIGN KEY (Sucursal) REFERENCES Sucursal_principal (IdSucursal)
 
)

Insert into Empleados values('Saul','Partida','Saul@gmail.com','12345','1975-11-02','2019-02-12','66412489',1,1);
select * from Empleados


--Clientes

CREATE TABLE Clientes 
(
  IdClientes INT PRIMARY KEY NOT NULL Identity (1,1),
  Nombre VARCHAR(45) NOT NULL,
  apellidos VARCHAR(45) NOT NULL,
  PasswordCliente VARCHAR(20) NOT NULL,
  Telefono varchar(10) NOT NULL,
  Correo VARCHAR(45) NOT NULL,
  Edad INT NOT NULL,
  Direccion VARCHAR(45) NOT NULL,
  Sexo VARCHAR(45) NOT NULL,
  FechaNacimiento DATETIME NOT NULL,
  RFC VARCHAR(45) NOT NULL,
  ReferenciaUno VARCHAR(45) NOT NULL,
  NumRefUno Varchar(10) NOT NULL,
  ReferenciaDos VARCHAR(45) NOT NULL,
  NumRefDos varchar(10)  NOT NULL,
  ReferenciaTres VARCHAR(45) NOT NULL,
  NumRefTres varchar(10) NOT NULL,
  TipoUsuario INT NOT NULL,
  CONSTRAINT FK_IdRolCliente_TBRol FOREIGN KEY (TipoUsuario) REFERENCES Rol (IdRol)
)
Insert into Clientes values('Ricardo','Jacuinde', '12345',6645929,'ricardo@mail.com',22,'Otay', 'Masculino','2020-10-01','fdsfsd','marta',664, 'cris',663, 'sofia',662,2);
Insert into Clientes values(2,'marta','Jimenes', '12345',6645929,'ricardo@mail.com',22,'Otay', 'Masculino','2020-10-01 07:00:25','fdsfsd','marta',664, 'cris',663, 'sofia',662,2);

Delete from Clientes where IdClientes=4
 Drop Table Clientes
 Drop Table CompraVenta

select * from Empleados
--Automovil


CREATE TABLE Automoviles 
(
  IdAutomovil INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  Marca VARCHAR(45) NOT NULL,
  Modelo VARCHAR(45) NOT NULL,
  Color VARCHAR(45) NOT NULL,
  Año VARCHAR(45) NOT NULL,
  Serie VARCHAR(25) NOT NULL,
  FechaIngreso DATE NOT NULL,
  PrecioCompra INT NOT NULL,
  PrecioVenta INT NOT NULL,
  Sucursal INT NOT NULL,
  CONSTRAINT FK_SucursalAuto_TBSucursalPrincipal FOREIGN KEY (Sucursal) REFERENCES Sucursal_principal (IdSucursal)
  )

  ALTER TABLE Automoviles DROP CONSTRAINT FK_SucursalAuto_TBSucursalPrincipal
  Drop Table Automoviles

--Autopartes-----

drop table Autopartes
CREATE TABLE Autopartes 
(
  IdAutopartes INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  Nombre VARCHAR(45) NOT NULL,
  Modelo VARCHAR(45) NOT NULL,
  precio int,
  Cantidad INT NOT NULL,
  
  Sucursal INT NOT NULL,
  CONSTRAINT FK_SucursalPart_TBSucursalPrincipal FOREIGN KEY (Sucursal) REFERENCES Sucursal_principal (IdSucursal)
  )

--Sucursal secundaria



CREATE TABLE Sucursal_Secundaria
(
  IdSucursal_Secundaria INT PRIMARY KEY NOT NULL ,
  Nombre VARCHAR(45) NOT NULL,
  Direccion VARCHAR(45) NOT NULL,
  Telefono INT NOT NULL,
  Correo VARCHAR(45) NOT NULL,
)


Insert into Sucursal_Secundaria values(1,'NC Otay','Otay','66412147','cOtay@gmail.com');
Insert into Sucursal_Secundaria values(2,'NC Playas','Playas','664781235','ncplayas@gmail.com');


--Traspasos

Drop Table TraspasoSaS
CREATE TABLE TraspasoSaS
(
  IdTraspasoSaS INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  Fecha date NOT NULL,
  SucursalEntrega INT NOT NULL,
  SucursalRecibe INT NOT NULL,
  TipoTraspaso VARCHAR(45),
  CONSTRAINT FK_SucursalRecibe_TBSucursal_principal  FOREIGN KEY (SucursalEntrega) REFERENCES Sucursal_principal (IdSucursal),
  CONSTRAINT FK_SucursalEntrega_TBSucursal_Secunadaria  FOREIGN KEY (SucursalRecibe) REFERENCES Sucursal_Secundaria (IdSucursal_Secundaria)
)

Drop table DetalleTraspaso
CREATE TABLE DetalleTraspaso 
(
  idDetalle_Traspaso INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  IdTraspasoSAS INT NOT NULL,
  Automovil INT NOT NULL,
  CONSTRAINT FK_IdTraspasoSAS_TBDClientes   FOREIGN KEY (IdTraspasoSAS) REFERENCES TraspasoSaS (IdTraspasoSaS),
  CONSTRAINT FK_Automovil_TBDClientes   FOREIGN KEY (Automovil) REFERENCES Automoviles (IdAutomovil),
)

--Compra venta
CREATE TABLE Compraventa 
(
  IdCompraVenta INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  Cliente INT,
  Fecha DATE,
  TipoFinanciamiento VARCHAR(45),
  Total Float,
  CONSTRAINT FK_Cliente_TBDClientes   FOREIGN KEY (Cliente) REFERENCES Clientes (IdClientes)
)

--Detalle compra vente
CREATE TABLE DetalleCompraVenta 
(
  IdDetalleCompraVenta INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  Automovil INT NOT NULL,
  Cantidad INT NOT NULL,
  IdCompraventa INT NOT NULL,
  Accesorios INT NOT NULL,
  Promocion INT NOT NULL,
  CONSTRAINT FK_ClienteDetalleCompraVenta_TBDClientes   FOREIGN KEY (Accesorios) REFERENCES Autopartes (IdAutopartes),
  CONSTRAINT FK_IdCompraventa_TBDCompraVenta   FOREIGN KEY (IdCompraventa) REFERENCES Compraventa (IdCompraVenta),
  CONSTRAINT FK_AutomovilCompraVenta_TBDClientes   FOREIGN KEY (Automovil) REFERENCES Automoviles (IdAutomovil),
  CONSTRAINT FK_idDescuento_TBPromocion   FOREIGN KEY (Promocion) REFERENCES Promocion (IdPromocion),

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
  Nombre VARCHAR(45),
 
 )
 select * from rol
 Update Rol set Nombre='Cliente' where IdRol=2

----------Modulos para los roles a los cuales se tendran acceso---------
CREATE TABLE Modulos
(
 IdModulo INT PRIMARY KEY NOT NULL  ,
 Nombre VARCHAR(20),

)

------------Operaciones a realizar-------------
CREATE TABLE Operaciones
(
 IdOperacion INT PRIMARY KEY NOT NULL  ,
 Nombre VARCHAR(20),
 Modulo INT NOT NULL
 CONSTRAINT FK_Operaciones_Modulo   FOREIGN KEY (Modulo) REFERENCES Modulos (IdModulo),
)

drop table Modulos

CREATE TABLE Rol_Operacion
(
 IdRolOperacion INT PRIMARY KEY NOT NULL  ,
 IdRol INT  ,
 IdOperacion INT
 CONSTRAINT FK_Rol_Operacion_Rol   FOREIGN KEY (IdRol) REFERENCES Rol (IdRol), 
 CONSTRAINT FK_Rol_Operacion_Operacion   FOREIGN KEY (IdOperacion) REFERENCES Operaciones (IdOperacion)
)

drop table RutaImg
CREATE TABLE RutaImg
(
idRuta int,
 Ruta varchar(200)
)


select * From Rol
--------------------------------------------------------------------------------------
--------------------------------------inserción--------------------------------------
insert into Rol values(1,'Cliente');
insert into Rol values(2,'Empleado');
insert into Rol values(3,'Admin');

select * from Modulos
insert into Modulos values(1,'Sucursal_principal');
insert into Modulos values(2,'Empleados');
insert into Modulos values(3,'Clientes');
insert into Modulos values(4,'Automoviles');
insert into Modulos values(5,'Autopartes');
insert into Modulos values(6,'Sucursal_Secundaria');
insert into Modulos values(7,'Compraventa');
insert into Modulos values(8,'DetalleCompraVenta');
insert into Modulos values(9,'DetalleTraspaso');
insert into Modulos values(10,'Promocion');
insert into Modulos values(11,'Accesorios');
insert into Modulos values(12,'Modulos');
insert into Modulos values(13,'Operaciones');
insert into Modulos values(14,'Rol_Operacion');

----Operaciones permitidas para Tabla Sucursal_ Principal-----
insert into Operaciones values(1,'agregar',1);
insert into Operaciones values(2,'editar',1);
insert into Operaciones values(3,'eliminar',1);
insert into Operaciones values(4,'ver',1);

----Operaciones permitidas para Tabla Empleados-----

insert into Operaciones values(5,'agregar',2);
insert into Operaciones values(6,'editar',2);
insert into Operaciones values(7,'eliminar',2);
insert into Operaciones values(8,'ver',2);

----Operaciones permitidas para Tabla Clientes-----
insert into Operaciones values(9,'agregar',3);
insert into Operaciones values(10,'editar',3);
insert into Operaciones values(11,'eliminar',3);
insert into Operaciones values(12,'ver',3);

----Operaciones permitidas para Tabla automoviles-----
insert into Operaciones values(13,'agregar',4);
insert into Operaciones values(14,'editar',4);
insert into Operaciones values(15,'eliminar',4);
insert into Operaciones values(16,'ver',4);

----Operaciones permitidas para Tabla autopartes-----
insert into Operaciones values(17,'agregar',5);
insert into Operaciones values(18,'editar',5);
insert into Operaciones values(19,'eliminar',5);
insert into Operaciones values(20,'ver',5);

----Operaciones permitidas para Tabla Sucursal_Secundaria-----      
insert into Operaciones values(21,'agregar',6);
insert into Operaciones values(22,'editar',6);
insert into Operaciones values(23,'eliminar',6);
insert into Operaciones values(24,'ver',6);

----Operaciones permitidas para Tabla Compraventa-----
insert into Operaciones values(25,'agregar',7);
insert into Operaciones values(26,'editar',7);
insert into Operaciones values(27,'eliminar',7);
insert into Operaciones values(28,'ver',7);

----Operaciones permitidas para Tabla DetalleCompraVenta-----
insert into Operaciones values(29,'agregar',8);
insert into Operaciones values(30,'editar',8);
insert into Operaciones values(31,'eliminar',8);
insert into Operaciones values(32,'ver',8);

----Operaciones permitidas para Tabla DetalleTraspaso-----
insert into Operaciones values(33,'agregar',9);
insert into Operaciones values(34,'editar',9);
insert into Operaciones values(35,'eliminar',9);
insert into Operaciones values(36,'ver',9);


----Operaciones permitidas para Tabla Promocion-----
insert into Operaciones values(37,'agregar',10);
insert into Operaciones values(38,'editar',10);
insert into Operaciones values(39,'eliminar',10);
insert into Operaciones values(40,'ver',10);

----Operaciones permitidas para Tabla Accesorios-----
insert into Operaciones values(25,'agregar',11);
insert into Operaciones values(26,'editar',11);
insert into Operaciones values(27,'eliminar',11);
insert into Operaciones values(28,'ver',11);

----Operaciones permitidas para Tabla Modulos-----
insert into Operaciones values(25,'agregar',12);
insert into Operaciones values(26,'editar',12);
insert into Operaciones values(27,'eliminar',12);
insert into Operaciones values(28,'ver',12);

----Operaciones permitidas para Tabla Operaciones-----
insert into Operaciones values(25,'agregar',13);
insert into Operaciones values(26,'editar',13);
insert into Operaciones values(27,'eliminar',13);
insert into Operaciones values(28,'ver',13);

----Operaciones permitidas para Tabla Rol_Operacion-----
insert into Operaciones values(25,'agregar',14);
insert into Operaciones values(26,'editar',14);
insert into Operaciones values(27,'eliminar',14);
insert into Operaciones values(28,'ver',14);


select * from Operaciones


----------------------------------------------------------------------------------------





---------------------------Procedimientos------------------------

-- INSERTAR --

----Codigo para borrar un procedimiento------
if object_id('InsertarCliente') is not null
  drop proc InsertarCliente

----Procedimiento para insetar cliente------

Go
create procedure InsertarCliente
@Nombre varchar (45),
@Apellidos varchar (45),
@PasswordCliente varchar(20),
@Telefono varchar (10),
@Correo varchar (45),
@Edad int,
@Direccion varchar (45),
@Sexo Varchar (45),
@FechaNacimiento DATETIME,
@RFC Varchar(45),
@ReferenciaUno VARCHAR(45),
@NumRefUno varchar (10) ,
@ReferenciaDos VARCHAR(45) ,
@NumRefDos varchar (10),
@ReferenciaTres VARCHAR(45) ,
@NumRefTres varchar (10),
@TipoUsuario INT 

as
insert into Clientes values (@Nombre,@Apellidos,@PasswordCliente,@Telefono,@Correo,@Edad,@Direccion,@Sexo,@FechaNacimiento,@RFC,@ReferenciaUno,@NumRefUno,@ReferenciaDos,@NumRefDos,@ReferenciaTres,@ReferenciaTres, @TipoUsuario)

go

exec InsertarCliente 'Ricardo','Jacuinde', '12345',6645929,'ricardo@mail.com',22,'Otay', 'Masculino','2020-10-01','fdsfsd','marta',664, 'cris',663, 'sofia',662,2


--------------------Procedimiento para insertar empleado-----------

if object_id('InsertarEmpleado') is not null
  drop proc InsertarEmpleado

Go
create procedure InsertarEmpleado
@Nombre varchar (45),
@Apellidos varchar (45),
@Correo varchar (45),
@PasswordEmpleado varchar(20),
@FechaNacimiento DATETIME,
@FechaIngreso DATETIME,
@Telefono varchar (10) ,
@Sucursal INT ,
@TipoUsuario INT 

as
insert into Empleados values (@Nombre,@Apellidos,@Correo,@PasswordEmpleado,@FechaNacimiento,@FechaIngreso,@Telefono,@Sucursal, @TipoUsuario)
go

exec InsertarEmpleado 'Magnus','Mefisto','Magnus@gmail.com','12345','1975-10-01','2020-09-01','61248121',1,1
exec InsertarEmpleado 'prueba','testeo','prueba@gmail.com','12345','1975-10-01','2020-09-01','61248121',1,1


----------------Procedimiento para insertar automovil--------------
Go
create procedure InsertarAutomovil
@Marca varchar (45),
@Modelo varchar (45),
@Color varchar (45),
@Año varchar(45),
@Serie Varchar(25),
@FechaIngreso DATETIME,
@PrecioCompra INT ,
@PrecioVenta INT ,
@Sucursal INT 

as
insert into Automoviles values (@Marca,@Modelo,@Color,@Año,@Serie,@FechaIngreso,@PrecioCompra,@PrecioVenta,@Sucursal)
go

exec InsertarAutomovil 'Ford','Focus','Rojo','2019','dsf412d1','2020-09-01',170000,200000,1



   

----------------Procedimiento para insertar Accesorio--------------
Go
create procedure InsertarAccesorio
@Nombre VARCHAR(45) ,
@Modelo VARCHAR(45) ,
@Cantidad INT ,
@Precio Int,
@Sucursal INT 
as
insert into Autopartes values (@Nombre,@Modelo,@Precio,@Cantidad ,@Sucursal)
go

if object_id('InsertarTraspaso') is not null
  drop proc InsertarTraspaso
----------------Procedimiento para insertar Traspaso--------------
Go
create procedure InsertarTraspaso
@Fecha date ,
@SucursalEntrega INT,
@SucursalRecibe INT ,
@TipoTraspaso Varchar(45)
as
insert into TraspasoSaS values (@Fecha,@SucursalEntrega,@SucursalRecibe,@TipoTraspaso)
go


----------------Procedimiento para insertar DetalleTraspaso--------------
Go
create procedure InsertarDetalleTraspaso
@IdTraspasoSAS INT ,
@Automovil INT 
as
insert into DetalleTraspaso values (@IdTraspasoSAS,@Automovil)
go


 idDetalle_Traspaso INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  IdTraspasoSAS INT NOT NULL,
  Automovil INT NOT NULL,






----------------Procedimiento para insertar Ruta de imagen--------------
Go
create procedure InsertarRuta
@idRuta int,
@Ruta varchar (200)

as
insert into RutaImg values (@idRuta,@Ruta)
go

-----procedimiento para consultar clientes----------
CREATE PROCEDURE MostrarClientes
AS
SELECT * FROM Clientes
GO



-----procedimiento para consultar clientes----------
CREATE PROCEDURE MostrarEmpleados
AS
SELECT * FROM Empleados
GO
 
 if object_id('MostrarAutos') is not null
  drop proc MostrarAutos

-----procedimiento para consultar Autos ----------
CREATE PROCEDURE MostrarAutos
AS
SELECT * FROM Automoviles
GO


-----procedimiento para consultar accesorios ----------
CREATE PROCEDURE MostrarAccesorios
AS
SELECT * FROM Autopartes
GO
 

 -----procedimiento para consultar accesorios ----------
CREATE PROCEDURE MostrarAdmin
AS
SELECT * FROM Administrador
GO

if object_id('MostrarSucursalSecundaria') is not null
  drop proc MostrarSucursalSecundaria

-----procedimiento para consultar Sucursal Secundari ----------
CREATE PROCEDURE MostrarSucursalPrincipal
AS
SELECT * FROM Sucursal_principal;
GO


-----procedimiento para consultar Sucursal Secundari ----------
CREATE PROCEDURE MostrarSucursalSecundaria
AS
SELECT * FROM Sucursal_Secundaria;
GO
 


--------Procedimiento para eliminar cliente
create proc EliminarCliente
@IdCliente int
as
delete from Clientes where IdClientes=@IdCliente
go

-------Procedimiento para eliminar Empleado

create proc EliminarEmpleado
@IdEmpleados int
as
delete from Empleados where IdEmpleados=@IdEmpleados
go

-------Procedimiento para eliminar automovil

create proc EliminarAutomovil
@IdAutomovil int
as
delete from Automoviles where IdAutomovil=@IdAutomovil
go

-------Procedimiento para eliminar Accesorio

create proc EliminarAccesorio
@IdAutopartes int
as
delete from Autopartes where IdAutopartes=@IdAutopartes
go

create proc EliminarRuta
@IdRuta int
as
delete from RutaImg where IdRuta=@IdRuta
go


-- Procedimiento para actualizar cliente

create proc ActualizarCliente
@Nombre varchar (45),
@Apellidos varchar (45),
@PasswordCliente varchar(20),
@Telefono varchar (10),
@Correo varchar (45),
@Edad int,
@Direccion varchar (45),
@Sexo Varchar (45),
@FechaNacimiento DATETIME,
@RFC Varchar(45),
@ReferenciaUno VARCHAR(45),
@NumRefUno varchar (10) ,
@ReferenciaDos VARCHAR(45) ,
@NumRefDos varchar (10),
@ReferenciaTres VARCHAR(45) ,
@NumRefTres varchar (10),
@TipoUsuario INT 
as
Update Clientes set Nombre=@Nombre, Apellidos=@Apellidos,PasswordCliente=@PasswordCliente,Telefono=@Telefono,Correo=@Correo, Edad=@Edad,Direccion=@Direccion, Sexo=@Sexo, FechaNacimiento=@FechaNacimiento,RFC=@RFC,ReferenciaUno=@ReferenciaUno,NumRefUno=@NumRefUno,ReferenciaDos=@ReferenciaDos,NumRedDos=@NumRefDos,ReferenciaTres=@ReferenciaTres,NumRefTres=@NumRefTres,TipoUsuario=@TipoUsuario where RFC=@RFC
go

-- Procedimiento para actualizar Empleado------

create proc ActualizarEmpleado
@Nombre varchar (45),
@Apellidos varchar (45),
@Correo varchar (45),
@PasswordEmpleado varchar(20),
@FechaNacimiento DATETIME,
@FechaIngreso DATETIME,
@Telefono varchar (10) ,
@Sucursal INT ,
@TipoUsuario INT 
as
Update Empleados set Nombre=@Nombre, Apellidos=@Apellidos,Correo=@Correo,PasswordEmpleado=@PasswordEmpleado,FechaNacimiento=@FechaNacimiento,FechaIngreso=@FechaIngreso,Telefono=@Telefono,Sucursal=@Sucursal,TipoUsuario=@TipoUsuario where Telefono=@Telefono
go

-- Procedimiento para actualizar Automovil------

create proc ActualizarAutomovil
@Marca varchar (45),
@Modelo varchar (45),
@Color varchar (45),
@Año varchar(45),
@Serie Varchar(25),
@FechaIngreso DATETIME,
@PrecioCompra INT ,
@PrecioVenta INT ,
@Sucursal INT  
as
Update Automoviles set Marca=@Marca, Modelo=@Modelo, Color=@Color, Año=@Año, Serie=@Serie, FechaIngreso=@FechaIngreso, PrecioCompra=@PrecioCompra, PrecioVenta=@PrecioVenta, Sucursal=@Sucursal where Serie=@Serie
go

-- Procedimiento para actualizar Accesorios------


create proc ActualizarAccesorios
@Nombre VARCHAR(45) ,
@Modelo VARCHAR(45) ,
@Precio int,
@Cantidad INT ,
@Sucursal INT 

as
Update Autopartes set Nombre=@Nombre, Modelo=@Modelo, Precio=@Precio,Cantidad=@Cantidad, Sucursal=@Sucursal
go

-- Procedimiento para actualizar Admin------


create proc ActualizarAdmin
@IdAdministrador int,
@Nombre VARCHAR(45) ,
@Direccion VARCHAR(45) ,
@Telefono Varchar(10),
@Correo VARCHAR(45),
@Contraseña VARCHAR(45),
@FechaIngreso DATE,
@TipoUsuario INT
as
Update Administrador set IdAdministrador=@IdAdministrador, Nombre=@Nombre, Direccion=@Direccion, Telefono=@Telefono,Correo=@Correo,Contraseña=@Contraseña,FechaIngreso=@FechaIngreso, TipoUsuario=@TipoUsuario
go


 -- Procedimiento para actualizar Accesorios------



	



--TRIGGERS	
/*Selección de un automóvil y que permita llevar un proceso de aplicación de accesorios 
al seleccionar un vehículo con características básicas*/
create trigger SeleccionVehiculo


/*Cancelación de una compra que se encontraba en un proceso avanzado de adquisición.*/
create trigger cancelar


/*Modificaciónde las características particulares de un vehículo cuando se encuentra 
en un proceso de compra-venta y este realiza el cambio de todas las características...*/
create trigger modificar


/*Realizar una auditoría de los vendedores de autos, el cual contenga, vendedor, automóvil, 
si  este  tuvo  equipamiento especial o  no,  si  se  le  aplica  alguna  promoción,  si  fue
solo 1 auto o flotilla (aplica a partir de 2 autos en adelante), monto final de la venta, 
comisión por la apertura del crédito y hora/fecha de la transacción.*/
create trigger auditoria


/*Proceso que permita registra un nuevo modelo de automóvil que nunca haya estado en el 
inventario.*/
create trigger registrar



--TABLAS PARA TRIGGER
create table BitacoraComprasVentas (
 IdCompraVenta INT,
 Cliente INT,
 TipoFinanciamiento VARCHAR(45),
 Total Float,
  Fecha DATETime,
  Accion varchar(20)
)

create table BitacoraTraspasos (
  IdTraspasoSaS INT,
  Rol varchar(15),
  SucursalEntrega INT NOT NULL,
  SucursalRecibe INT NOT NULL,
  TipoTraspaso VARCHAR(45),
  Fecha DateTime,
  Accion varchar(20)
)

create table BitacoraClientes (
Rol varchar(15),
Fecha DateTime,
Accion varchar(20)
)

create table BitacoraEmpleados (
Rol varchar(15),
Fecha DateTime,
Accion varchar(20)
)

create table BitacoraAutos (
Rol varchar(15),
Fecha DateTime,
Accion varchar(20)
)

create table BitacoraAccesorios (
Rol varchar(15),
Fecha DateTime,
Accion varchar(20)
)

if object_id('tr_BitacoraClientesAlta') is not null
  drop Trigger tr_BitacoraClientesAlta

create trigger tr_BitacoraClientesAlta
on Clientes for insertas
declare @Fecha DateTime
set @Fecha = (select GETDATE())
insert into BitacoraClientes ( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Alta de Cliente Nuevo' )
go



DROP TRIGGER IF EXISTS tr_BitacoraClientesBaja
create trigger tr_BitacoraClientesBaja
on Clientes for delete
as
declare @Fecha DateTime

et @Fecha = (select GETDATE())
insert into BitacoraClientes ( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Eliminacion de Cliente' )
go

if object_id('tr_BitacoraClientesActualizacion') is not null
  drop Trigger tr_BitacoraClientesActualizacion

create trigger tr_BitacoraClientesActualizacion
on Clientes for update
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraClientes ( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Actualizacion de Datos de Cliente' )
go



if object_id('tr_BitacoraEmpleadosAlta') is not null
  drop Trigger tr_BitacoraEmpleadosAlta
---------------
create trigger tr_BitacoraEmpleadosAlta
on Empleados for insert
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraEmpleados ( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Alta de Empleado Nuevo' )
go

if object_id('tr_BitacoraEmpleadosBaja') is not null
  drop Trigger tr_BitacoraEmpleadosBaja



create trigger tr_BitacoraEmpleadosBaja
on Empleados for delete
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraEmpleados ( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Eliminacion de Empleado' )
go

if object_id('tr_BitacoraEmpleadosActualizacion') is not null
  drop Trigger tr_BitacoraEmpleadosActualizacion

create trigger tr_BitacoraEmpleadosActualizacion
on Empleados for update
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraEmpleados( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Actualizacion de Datos de Empleado' )
go

--------------------

if object_id('tr_BitacoraAutosAlta') is not null
  drop Trigger tr_BitacoraAutosAlta


create trigger tr_BitacoraAutosAlta
on Automoviles for insert
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraAutos( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Alta de Automovil' )
go
 if object_id('tr_BitacoraAutosBaja') is not null
  drop Trigger tr_BitacoraAutosBaja

create trigger tr_BitacoraAutosBaja
on Automoviles for delete
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraAutos ( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Eliminacion de Automovil' )
go

if object_id('tr_BitacoraAutosActualizacion') is not null
  drop Trigger tr_BitacoraAutosActualizacion

create trigger tr_BitacoraAutosActualizacion
on Automoviles for update
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraAutos( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Actualizacion de Datos de Automovil' )
go

------------------------------

create trigger tr_BitacoraAutopartesAlta
on Autopartes for insert
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraAccesorios( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Alta de Accesorio' )
go

 if object_id('tr_BitacoraAutoPartesBaja') is not null
  drop Trigger tr_BitacoraAutoPartesBaja



create trigger tr_BitacoraAutoPartesBaja
on Autopartes for delete
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraAccesorios ( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Eliminacion de Automovil' )
go


create trigger tr_BitacoraAutopartesActualizacion
on Autopartes for update
as
declare @Fecha DateTime

set @Fecha = (select GETDATE())
insert into BitacoraAccesorios( Rol, Fecha, Accion)
values ('Administrador',@Fecha, 'Actualizacion de Datos de Automovil' )
go


-----------------------
create trigger tr_BitacoraTraspasos
on TraspasoSaS for insert
as
declare @IdTraspasoSaS int
declare @Rol varchar(15)
declare @SucursalEntrega INT 
declare @SucursalRecibe INT 
declare @TipoTraspaso VARCHAR(45)
declare @Fecha DateTime
declare @Accion varchar(20)


set @IdTraspasoSaS = (select IdTraspasoSaS from Inserted)
set @SucursalEntrega = (select SucursalEntrega from Inserted)
set @SucursalRecibe = (select SucursalRecibe from Inserted)
set @TipoTraspaso = (select TipoTraspaso from Inserted)
set @Fecha = (select GETDATE())

insert into BitacoraTraspasos( IdTraspasoSaS, Rol, SucursalEntrega, SucursalRecibe, TipoTraspaso, Fecha, Accion)
values (@IdTraspasoSaS,'Administrador', @SucursalEntrega, @SucursalRecibe, @TipoTraspaso, @Fecha, 'Alta de Traspaso Nuevo' )
go



create trigger tr_BitacoraCompraVenta
on CompraVenta for insert
as
declare @IdCompraVenta int
declare @Cliente int
declare @TipoFinanciamiento varchar(45)
declare @Total float
declare @Fecha datetime
declare @Accion varchar(20)

set @Fecha = (select GETDATE())
insert into BitacoraComprasVentas( IdCompraVenta, Cliente, TipoFinanciamiento, Total, Fecha, Accion)
values (@IdCompraVenta,@Cliente, @TipoFinanciamiento, @Total , @Fecha, 'Registro de Compra Venta' )
go

------- PROCEDIMIENTOS ALMACENADOS

-- BITACORA
create proc MostrarBitacoraCompraVenta
as
select *from BitacoraComprasVentas
go

create proc MostrarBitacoraTraspasos
as
select *from BitacoraTraspasos
go


select * from DetalleCompraVenta