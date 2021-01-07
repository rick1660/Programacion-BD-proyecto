create database ProyectoBD_2
use ProyectoBD_2
drop database ProyectoBD
go


------ CREACION DE TABLAS -------

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
IdEmpleado int,
CONSTRAINT FK_IdCliente2 FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente),
CONSTRAINT FK_Refaccion  FOREIGN KEY (IdRefaccion) REFERENCES Refaccion(IdRefaccion),
CONSTRAINT FK_IdServicio FOREIGN KEY (IdServicio) REFERENCES Servicios(IdServicio),
CONSTRAINT FK_Empleado   FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado)
)

create table Historial (
Fecha date,
Descripcion varchar (100),
Usuario varchar(50)
)

------- INSERCION DE DATOS --------
select * from Cliente
insert into Cliente values (1,'Alfreds Futterkiste', 'Maria Anders','Obere Str. 57 Berlin','6645214783','alfreds@gmail.com' )
insert into Cliente values (2,'Ana', 'Trujillo Truenos','Avda. de la Constitución 2222', '6648744521','Ana@gmail.com')
insert into Cliente values (3,'Antonio', 'Moreno Marquez','Mataderos 2312', '6648796322','Antonio@gmail.com')
insert into Cliente values (4,'Celsa', 'Piña Valderrama','avda. la cotorra', '6647789654','celsa@gmail.com')
insert into Cliente values (5,'Pablo', 'Perez Pulido','avda el penon', '6648996542','pablo@gmail.com')
insert into Cliente values (6,'Juan', 'Herandez','avda el penon', '6648996542','pablo@gmail.com')


select * from Automovil;
insert into Automovil values(1,8741,'Nissan','Altima','gris',2012, 2020-09-27 ,1)
insert into Automovil values(2,7784,'Honda','civic','Morado',1998, 2020-09-30 ,2)
insert into Automovil values(3,4521,'Ford','Fiesta','rojo',2006,2020-10-1,3)
insert into Automovil values(4,4587,'Volkswagen','Jetta','amarillo',2017,2020-10-3,4)
insert into Automovil values(5,1235,'Chevrolet','Camaro','blanco',2019,2020-10-4,5)
insert into Automovil values(6,4521,'Ford','Focus','Negro',2004,2020-10-6,3)
insert into Automovil values(7,1235,'Lambirghini','Aventor','Azul',2020,2020-09-13,2)
insert into Automovil values(8,4587,'Maserati','Gran turismo','Plateado',2018,2020-06-8,2)
insert into Automovil values(9,5417,'Mazda','RX-8','Rojo',2020,2020-07-10,1)


Select * from Departamentos
Insert into Departamentos values(1,'Carroceria',6149)
Insert into Departamentos values(2,'Electrico',8467)
Insert into Departamentos values(3,'Suspencion',5923)
Insert into Departamentos values(4,'Mecanico',1834)
Insert into Departamentos values(5,'Refaccionari',7358)



select * from Supervisor;
insert into Supervisor values (6149,'Matti Karttunen', 'Kala Wolski', '2431526874', 'Matti45_ws@gmail.com')
insert into Supervisor values (8467,'Karl', 'Jablonski', '9812862841', 'Kl_Jbsk@gmail.com')
insert into Supervisor values (5923,'Rita Müller', 'Wandernde', '7056398317', 'rita_muller72@gmail.com')
insert into Supervisor values (1834,'Palle Ibsen', 'Vaffeljernet', '820068319', 'ibsenx84@gmail.com')
insert into Supervisor values (7358,'Miguel Angel', 'Paolino', '8503315463', 'Mp_paolo92@gmail.com')


select * from Empleado
insert into Empleado values(0123,'Francisco Camacho',667456213,01,1);
insert into Empleado values (0223,'Israel Trujillo',667654321,02,4);
insert into Empleado values(0323,'Diego Lopez',667357159,03,5);
insert into Empleado values(0423,'Julio Calderon',664355412,04,2);
insert into Empleado values(0523,'Saul Sandoval',667753211,05,3);
insert into Empleado values(2187,'Juan Hernandez',6642626812,04,4);


select * from Diagnostico
insert into Diagnostico(IdDiagnostico,Falla,Causa,IdVehiculo) values(0012,'No direcciona bien','Alineacion de las llantas',5);
insert into Diagnostico(IdDiagnostico,Falla,Causa,IdVehiculo) values(0013,'Luces no prenden','Luces',4);
insert into Diagnostico(IdDiagnostico,Falla,Causa,IdVehiculo) values(0014,'Sonido raro cofre','Motor',1);
insert into Diagnostico(IdDiagnostico,Falla,Causa,IdVehiculo) values(0015,'Calentamiento en motor','Motor',1);



select * from Servicios;
insert into Servicios values (1,5000,2020-10-04,'Alineacion',10,1,2020-10-04,2020-11-04, 0012, 3 )
insert into Servicios values (2,3000,2020-10-03,'Focos',10,1,2020-10-03,2020-11-03, 0013, 2 )
insert into Servicios values (3,1000,2020-09-27,'Arreglo Motor ',10,1,2020-09-27,2020-10-27, 0014, 1 )



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
insert into Refaccion values (11,'Suspension' ,9590, '2020-09-24 12:58:00','2020-09-28 16:24:00' , 3)
insert into Refaccion values (12, 'focos',500,'2020-09-24 12:58:00','2020-10-03 16:24:00' , 2)
insert into Refaccion values (13, 'Rines 34 x4',4800,'2020-09-24 12:58:00','2020-10-03 16:24:00',3)
insert into Refaccion values (14, 'Llantas 34 x4 ',12000,'2020-09-24 12:58:00','2020-10-03 16:24:00',2)


insert into Factura values(1,2020-10-04,14590,5,1,11,0323)
insert into Factura values(2,2020-10-03,3500,4,2,12,0223)
insert into Factura values(3,2020-09-27,20850,1,3,9,0123)

select * from Cliente;
select * from Automovil;
select * from Departamentos;
select * from Empleado;
select * from Factura;
select * from Refaccion;
select * from Diagnostico;
select * from Supervisor;
select * from Servicios;


----- PROCEDIMIENTOS ALMACENADOS --------


-- MOSTRAR --
create proc MostrarClientes
as
select *from Cliente
go

create proc MostrarAutomovil
as
select *from Automovil
go

execute MostrarAutomovil


create proc MostrarDiagnostico
as
select *from Diagnostico
go

create proc MostrarRefaccion
as
select *from Refaccion
go

create proc MostrarEmpleado
as
select *from Empleado
go

create proc MostrarServicios
as
select *from Servicios
go


-- INSERTAR --
create proc InsertarCliente
@IdCliente int,
@Nombre varchar (25),
@Apellidos varchar (40),
@Direccion varchar (50),
@Telefono varchar (10),
@Correo varchar (40)
as
insert into Cliente values (@IdCliente,@Nombre,@Apellidos,@Direccion,@Telefono,@Correo)
go

create proc InsertarAutomovil 
@IdVehiculo int,
@NumSerie int,
@Marca varchar (15),
@Modelo varchar (15),
@Color varchar (10),
@Año smallint,
@Fecha_R datetime,
@IdCliente int
as
insert into Automovil values (@IdVehiculo,@NumSerie,@Marca,@Modelo,@Color,@Año,@Fecha_R,@IdCliente)
go


create proc InsertarEmpleado
@IdEmpleado int,
@Nombre varchar(40),
@Telefono varchar(10),
@IdDepartamento int,
@IdVehiculo int
as
insert into Empleado values (@IdEmpleado,@Nombre,@Telefono,@IdDepartamento,@IdVehiculo)
go

create proc InsertarDiagnostico
@IdDiagnstico int,
@Falla varchar (30),
@Causa varchar (30),
@IdVehiculo int
as
insert into Diagnostico values (@IdDiagnstico,@Falla,@Causa,@IdVehiculo)
go

create proc InsertarRefaccion
@IdRefaccion int,
@Nombre varchar(35),
@Costo float,
@FEntrada datetime,
@FSalida datetime,
@IdDepart int
as
insert into Refaccion values (@IdRefaccion,@Nombre,@Costo,@FEntrada,@FSalida,@IdDepart)
go

create proc InsertarServicio
@IdServicio int,
@Costo float,
@Fecha datetime,
@Nombre varchar(20),
@Promocion smallint,
@veces_c bigint,
@InicioGarant datetime,
@FinalGarant datetime,
@IdDiagnostico int,
@IdDepartamento int
as
insert into Servicios values (@IdServicio,@Costo,@Fecha,@Nombre,@Promocion,@veces_c,@InicioGarant,@FinalGarant,@IdDiagnostico,@IdDepartamento)
go




-- ELIMINAR --
create proc EliminarCliente
@IdCliente int
as
delete from Cliente where IdCliente=@IdCliente
go


create proc EliminarAutomovil
@IdVehiculo int
as
delete from Automovil where IdVehiculo=@IdVehiculo
go

create proc EliminarEmpleado
@IdEmpleado int
as
delete from Empleado where IdEmpleado=@IdEmpleado
go


create proc EliminarRefaccion
@IdRefaccion int
as
delete from Refaccion where IdRefaccion = @IdRefaccion
go


-- ACTUALIZAR

create proc ActualizarCliente
@IdCliente int,
@Nombre varchar (25),
@Apellidos varchar (40),
@Direccion varchar (50),
@Telefono varchar (10),
@Correo varchar (40)
as
Update Cliente set Nombre=@Nombre, Apellidos=@Apellidos, Direccion=@Direccion, Telefono=@Telefono, Correo=@Correo where IdCliente=@IdCliente
go

create proc ActualizarAutomovil 
@IdVehiculo int,
@NumSerie int,
@Marca varchar (15),
@Modelo varchar (15),
@Color varchar (10),
@Año smallint,
@FechaR datetime,
@IdCliente int
as
Update Automovil set NumSerie=@NumSerie, Marca=@Marca, Modelo=@Modelo, Color=@Color, Año=@Año, Feche_Registro=@FechaR, IdCliente=@IdCliente where IdVehiculo=@IdVehiculo
go

create proc ActualizarEmpleado
@IdEmpleado int,
@Nombre varchar(40),
@Telefono varchar(10),
@IdDepartamento int,
@IdVehiculo int
as
Update Empleado set Nombre=@Nombre, Telefono=@Telefono, IdDepartamento=@IdDepartamento, IdVehiculo=@IdVehiculo where IdEmpleado=@IdEmpleado
go


create proc ActualizarRefaccion
@IdRefaccion int,
@Nombre varchar(35),
@Costo float,
@FEntrada datetime,
@FSalida datetime,
@IdDepart int
as
Update Refaccion set Nombre=@Nombre, Costo=@Costo, FEntrada=@FEntrada, FSalida=@FSalida, IdDepartamento=@IdDepart where IdRefaccion=@IdRefaccion
go

create proc MostrarHistorial
as
select * from Historial
go



-- T R I G G E R 
create trigger TR_InsertAutomovil
on Automovil for insert
as
insert into Historial values(getdate(),'Automovil Registrado.', SYSTEM_USER)
go

-- VER PROCEDIMIENTOS --
SELECT ROUTINE_NAME FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE ROUTINE_TYPE = 'PROCEDURE'
   ORDER BY ROUTINE_NAME 