Create database Consultame

USE Consultame
GO


CREATE TABLE Materias
(
	Id_materias int primary Key IDENTITY(1,1), 
	Nombre_Materia nvarchar(50)
)

CREATE TABLE Consultas
(
	ID_Consultas int primary key Not null IDENTITY(1,1),
	IDmaterias INT FOREIGN KEY (IDmaterias) references Materias(Id_materias),
	Numero_semana int,
	Cantidad_estudiante int,
	Tipo_consulta nvarchar (max),
	Tema_consulta nvarchar (max),
	Fecha Datetime,
	Hora nvarchar(50),
	N_Carnet nvarchar(12),/*texto*/
	Firma_Est nvarchar (100),
	Observaciones nvarchar(max),
	Vobo_JefeDept int /*int*/
)

insert into Materias(Nombre_Materia)
values('Cultura de paz')

insert into Materias(Nombre_Materia)
values('Matematicas Discretas')

select * from Materias

insert into Consultas(ID_Consultas,IDmaterias,Numero_semana,Cantidad_estudiante,Tipo_consulta,Tema_consulta,
					Fecha,Hora,N_Carnet,Firma_Est,Observaciones,Vobo_JefeDept)
Values (1,2,12,5,'jajja','Funciones',11/22/2021,'10.30 am','2020-0269U','Treminio','reforzar el tema',1)

update Consultas
set Fecha= '2021-11-22'/*Año/mes/dia*/
where ID_Consultas=1

update Consultas
set Hora= '10.30 am'
where ID_Consultas=1


insert into Consultas(ID_Consultas,IDmaterias,Numero_semana,Cantidad_estudiante,Tipo_consulta,Tema_consulta,
					Fecha,Hora,N_Carnet,Firma_Est,Observaciones,Vobo_JefeDept)
Values (2,1,10,3,'jjejeje','Funciones',11/22/2021,'10.30 am','2020-0289U','jjj','reforzar el tema',1)


select *from Consultas

