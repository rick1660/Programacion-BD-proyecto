create database ProyectoBD
use ProyectoBD
drop database ProyectoBD
go

create table Cliente(
IdCliente int PRIMARY KEY NOT NULL,
Nombre varchar(25),
Apellidos varchar (40),
Direccion varchar(50),
Telefono varchar(10),
Correo varchar (40),
)

create table Automovil(
IdVehiculo int PRIMARY KEY NOT NULL,
NumSerie int,
Marca varchar (15),
Modelo varchar (15),
Color varchar(10),
Año smallint,
Feche_Registro datetime,
IdCliente int
CONSTRAINT FK_IdCliente_TBAutomovil FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente)
)

create table Empleado(
IdEmpleado int primary key NOT NULL,
Nombre varchar(40),
Telefono varchar(10),
IdDepartamento int,
IdVehiculo int,
CONSTRAINT FK_IdVehiculo_TBEmpleado FOREIGN KEY (IdVehiculo) REFERENCES Automovil(IdVehiculo)
);

create table Diagnostico(
IdDiagnostico int PRIMARY KEY NOT NULL,
Falla varchar (30),
Causa varchar (30),
IdVehiculo int,
CONSTRAINT FK_IdVehiculo_TBDiagnostico FOREIGN KEY (IdVehiculo) REFERENCES Automovil(IdVehiculo)
)

/* Create table Encargado(
IdEncargado int primary key NOT NULL,
IdEmpleado int ,
CONSTRAINT FK_IdEmpleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado)
)
*/
create table Supervisor(
IdSupervisor int PRIMARY KEY NOT NULL,
Nombre varchar(25),
Apellidos varchar (30),
Telefono varchar(10),
Correo varchar (40),
)

create table Departamentos (
IdDepartamento int PRIMARY KEY NOT NULL,
NomDepartamento varchar (15),
IdSupervisor int,
CONSTRAINT FK_Supervisor_TBDepartamentos FOREIGN KEY (IdSupervisor) REFERENCES Supervisor(IdSupervisor)
)

create table Refaccion (
IdRefaccion int PRIMARY KEY NOT NULL,
Nombre varchar (35),
Costo float,
FEntrada Datetime,
FSalida Datetime,
IdDepartamento int,
CONSTRAINT FK_IdDepartamento_TBRefaccion FOREIGN KEY (IdDepartamento) REFERENCES Departamentos(IdDepartamento)
)



create table Servicios (
IdServicio int PRIMARY KEY NOT NULL,
Costo float,
Fecha datetime,
Nombre varchar (20),
Promocion smallint,
veces_count bigint,
InicioGarantia datetime,
FinalGarantia datetime,
IdDiagnostico int,
IdDepartamento int,
CONSTRAINT FK_Diagnostico_TBServicios FOREIGN KEY (IdDepartamento) REFERENCES Departamentos(IdDepartamento),
CONSTRAINT FK_Departamentos_TBServicios FOREIGN KEY (IdDiagnostico) REFERENCES Diagnostico(IdDiagnostico)
)


create table Factura(
IdFactura int PRIMARY KEY NOT NULL,
Fecha Datetime,
Total float,
IdCliente int,
IdServicio int,
IdRefaccion int,
CONSTRAINT FK_IdCliente2 FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente),
CONSTRAINT FK_Refaccion FOREIGN KEY (IdRefaccion) REFERENCES Refaccion(IdRefaccion),
CONSTRAINT FK_IdServicio FOREIGN KEY (IdServicio) REFERENCES Servicios(IdServicio)
)

