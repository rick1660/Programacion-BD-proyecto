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







select * from Cliente;	 


insert into Cliente values (1,'Alfreds Futterkiste', 'Maria Anders','Obere Str. 57 Berlin','6645214783','alfreds@gmail.com' )
insert into Cliente values (2,'Ana', 'Trujillo Truenos','Avda. de la Constitución 2222', '6648744521','Ana@gmail.com')
insert into Cliente values (3,'Antonio', 'Moreno Marquez','Mataderos 2312', '6648796322','Antonio@gmail.com')
insert into Cliente values (4,'Celsa', 'Piña Valderrama','avda. la cotorra', '6647789654','celsa@gmail.com')
insert into Cliente values (5,'Pablo', 'Perez Pulido','avda el penon', '6648996542','pablo@gmail.com')


insert into Automovil values(1,8741,'Nissan','Altima','gris',2012, 2020-09-27 ,1)
insert into Automovil values(2,7784,'Honda','civic','Morado',1998, 2020-09-30 ,2)
insert into Automovil values(3,4521,'Ford','Fiesta','rojo',2006,2020-10-1,3)
insert into Automovil values(4,4587,'Volkswagen','Jetta','amarillo',2017,2020-10-3,4)
insert into Automovil values(5,1235,'Chevrolet','Camaro','blanco',2019,2020-10-4,5)
insert into Automovil values(6,4521,'Ford','Focus','Negro',2004,2020-10-6,3)
insert into Automovil values(7,1235,'Lambirghini','Aventor','Azul',2020,2020-09-13,2)
insert into Automovil values(8,4587,'Maserati','Gran turismo','Plateado',2018,2020-06-8,2)

select * from Automovil


Insert into Departamentos values(1,'Carroceria',3)
Insert into Departamentos values(2,'Electrico',5)
Insert into Departamentos values(3,'Suspencion',2)
Insert into Departamentos values(4,'Mecanico',1)
Insert into Departamentos values(5,'Refaccionari',4)

