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

select * from Automovil
insert into Automovil values(1,8741,'Nissan','Altima','gris',2012, 2020-09-27 ,1)
insert into Automovil values(2,7784,'Honda','civic','Morado',1998, 2020-09-30 ,2)
insert into Automovil values(3,4521,'Ford','Fiesta','rojo',2006,2020-10-1,3)
insert into Automovil values(4,4587,'Volkswagen','Jetta','amarillo',2017,2020-10-3,4)
insert into Automovil values(5,1235,'Chevrolet','Camaro','blanco',2019,2020-10-4,5)
insert into Automovil values(6,4521,'Ford','Focus','Negro',2004,2020-10-6,3)
insert into Automovil values(7,1235,'Lambirghini','Aventor','Azul',2020,2020-09-13,2)
insert into Automovil values(8,4587,'Maserati','Gran turismo','Plateado',2018,2020-06-8,2)




Select * from Departamentos
Insert into Departamentos values(1,'Carroceria',6149)
Insert into Departamentos values(2,'Electrico',8467)
Insert into Departamentos values(3,'Suspencion',5923)
Insert into Departamentos values(4,'Mecanico',1834)
Insert into Departamentos values(5,'Refaccionari',7358)



--ALE
--Empleados
--Carrocería y pintura 01
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0123,'Francisco Camacho',667456213,01,345);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0124,'Santiago Ortega',667789411,01,242);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0125,'Joel Molina',667279171,01,120);

--Eléctrico 02
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0223,'Israel Trujillo',667654321,02,771);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0224,'Daniel Sanchez',667741258,02,305);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0225,'Mario Gomez',667321456,02,471);

--Alineación y balanceo, suspensión 03
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0323,'Diego Lopez',667357159,03,153);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0324,'Jonathan Martinez',667971364,03,682);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0325,'Simon Velasquez',667326748,03,024);

--Mecánico 04
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0423,'Julio Calderon',664355412,04,910);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0424,'Santiago Muñoz',667369852,04,547);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0425,'Ricardo Cebreros',667147987,04,241);

--Refaccionaria 05
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0523,'Saul Sandoval',667753211,05,301);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0524,'Bryan Perez',667108535,05,852);
insert into Empleado(IdEmpleado,Nombre,Telefono,IdDepartamento,IdVehiculo) values(0525,'Lucas Acosta',667997711,05,151);

--Diagnostico
insert into Diagnostico(IdDiagnostico,Falla,Causa,IdVehiculo) values(0012,'Al manejar el carro se direcciona de mal manera','Alineacion de las llantas',682);
insert into Diagnostico(IdDiagnostico,Falla,Causa,IdVehiculo) values(0013,'No se prendren las luces del frente','Luces',471);
insert into Diagnostico(IdDiagnostico,Falla,Causa,IdVehiculo) values(0014,'Se escucha un sonido raro en el cofre','Motor',241);

--Factura
insert into Factura(IdFactura,Fecha,Total,IdCliente,IdServicio,IdRefaccion) values(537,'2020-10-09',200.00,048,011,344);
insert into Factura(IdFactura,Fecha,Total,IdCliente,IdServicio,IdRefaccion) values(538,'2020-10-09',350.00,048,012,411);
insert into Factura(IdFactura,Fecha,Total,IdCliente,IdServicio,IdRefaccion) values(539,'2020-10-09',80.00,048,013,503);




select * from Supervisor;
insert into Supervisor values (6149,'Matti Karttunen', 'Kala Wolski', '2431526874', 'Matti45_ws@gmail.com')
insert into Supervisor values (8467,'Karl', 'Jablonski', '9812862841', 'Kl_Jbsk@gmail.com')
insert into Supervisor values (5923,'Rita Müller', 'Wandernde', '7056398317', 'rita_muller72@gmail.com')
insert into Supervisor values (1834,'Palle Ibsen', 'Vaffeljernet', '820068319', 'ibsenx84@gmail.com')
insert into Supervisor values (7358,'Miguel Angel', 'Paolino', '8503315463', 'Mp_paolo92@gmail.com')

select * from Refaccion

insert into Refaccion values (1,'Autolite Iridium Iridio Bujia',307, 2020-10-01,2020-10-04, 5)
insert into Refaccion values (2,'Base Palanca De Cambios Ford F150',1190, '2020-10-01 07:00:25','2020-10-05 08:24:35' , 5)
insert into Refaccion values (3,'Motor de Arranque Electrico',2943, '2020-10-01 07:00:25','2020-10-05 08:24:35' , 2)
insert into Refaccion values (4,'Marcha Automotriz Electrica' , 3201, '2020-10-01 07:00:25','2020-10-05 08:24:35' , 2)
insert into Refaccion values (5,'Cuartos Frontal VW Sedan 1600' , 300, '2020-10-02 07:00:25','2020-10-03 08:24:35' , 1)
insert into Refaccion values (6,'Smalte Automotriz Max Sr' , 718, '2020-10-02 07:00:25','2020-10-03 08:24:35' , 1)
insert into Refaccion values (7,'Amortiguadores Jetta Golf A2 A3' ,1824 , '2020-10-04 07:00:25','2020-10-03 08:24:35' , 3)
insert into Refaccion values (8,'Tensor Ajustable Muelle' ,1499 , '2020-10-04 07:00:25','2020-10-03 08:24:35' , 3)
insert into Refaccion values (9,'Motor Dodge O Jeep V6' ,19850 , '2020-09-24 12:58:00','2020-09-28 16:24:00' , 4)
insert into Refaccion values (10,'Motor Nissan Valvulas Pick Up' ,18650 , '2020-09-24 12:58:00','2020-09-28 16:24:00' , 4)

/* Falta Factura */ 
