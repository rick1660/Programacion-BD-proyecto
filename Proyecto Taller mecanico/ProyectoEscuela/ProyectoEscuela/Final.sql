--Crear BD
Create database FINAL
use FINAL


--Crear tablas
Create table T_usuarios
(
ID_usuario int primary key,
Nombre varchar(15),
Apellido varchar(15),
Clave int,
Sexo varchar(1),
Rol varchar(7),
Fecha_Registro datetime,
Fecha_acceso datetime,
B_activo varchar(1)
)

Create table T_Calificaciones
(
ID_maestro int foreign key references T_usuarios(ID_usuario),
ID_alumno int foreign key references T_usuarios(ID_usuario),
Calificacion int check (Calificacion between 0 and 100),
B_Final varchar(1),
Fecha_Final datetime
)




Create table TH_acceso
(
I_seq int primary key identity(1,1),
ID_usuario int foreign key references T_usuarios(ID_usuario),
Fecha_acceso datetime 
)

Create  table TH_Clave
(
I_seq int primary key identity(1,1),
ID_usuario int foreign key references T_usuarios(ID_usuario),
Clave_ant int,
Fecha_cambio datetime 
)

select * from  T_usuarios order by Rol 
update T_usuarios set ID_usuario = 16212055 where Nombre=''
--
Insert into T_usuarios values 
(193440920,'Sebastian','Lopez',1234,'M','MAESTRO', getdate(), null,'T'),
(193440930,'Leonor','Paredes',1234,'F','MAESTRO', getdate(), null,'T'),
(193440940,'Garibo','Orozco',1234,'M','MAESTRO', getdate(), null,'T')


(593440121,'Martha','Romero',1234,'F','ALUMNO', getdate(), null,'T'),
(593440122,'Juan','Infante',1234,'M','ALUMNO', getdate(), null,'T'),
(593440123,'Maria','Zamora',1234,'F','ALUMNO', getdate(), null,'T'),
(593440124,'Diana','Reyes',1234,'F','ALUMNO', getdate(), null,'T'),
(16212055,'Gildeberto','Orizaga',1234,'M','ALUMNO', getdate(), null,'T'),
(16211999,'Fernando','Garcia',1234,'M','ALUMNO', getdate(), null,'T')


(193440921,'Ernesto','Ramirez',1234,'M','ADMIN', getdate(), null,'T'),
(40202187,'Carlos','Negrete',1234,'M','ADMIN', getdate(), null,'T')






select * from T_usuarios ORDER BY Rol

SELECT * FROM T_Calificaciones







Insert into T_Calificaciones values 
(193440940, 16212055, 100, 'T', null),
(193440940, 16212021, 69, 'F', null),
(193440940, 16211999, 85, 'T', null)

(193440920, 593440121, 100, 'F', null),
(193440920, 593440122, 50, 'F', null),
(193440930, 593440123, 100, 'F', null)
(193440940, 593440125, 100, 'F', null)
(193440940, 593440126, 90, 'F', null)
(193440940, 16212021, 69, 'F', null)
(193440930, 16212055,100,'T',NULL)


--Crear procedimiento
CREATE PROCEDURE sp_resumen
AS
SELECT COUNT(ID_alumno), MAX(Calificacion), MIN(Calificacion)        
FROM T_CALIFICACIONES
GO;






--Crear vista
CREATE VIEW v_consultas AS
SELECT COUNT(ID_alumno), MAX(Calificacion), MIN(Calificacion)        
FROM T_CALIFICACIONES 



--Trigger para la clave
create trigger TR_I_Claves on T_usuarios
for update as
begin
if update(Clave)
begin 
Declare @Clave int
Declare @Usuario int
Select @Clave = Clave from deleted
Select @Usuario = ID_usuario from deleted
Insert into TH_clave values(@Usuario, @Clave,Getdate())
end
end

Create trigger TR_I_ACCESO on T_usuarios
for update as
begin
if update(Fecha_acceso)
begin
Declare @Usuario int
Select @Usuario = ID_usuario from deleted
Insert into TH_acceso values(@Usuario, (select Fecha_acceso from inserted))
end
end

update T_usuarios set Apellido= 'Hernandez' where ID_usuario=16212021







select * from TH_acceso
Select * from  T_usuarios ORDER BY Rol
Select * from T_Calificaciones
select * from TH_clave



