--create database recetas

--USE recetas

create table Tipo_Recetas
(
	tipo_recetas int identity(1,1),
	tipo varchar(50),
	constraint fk_Tipo_Recetas primary key(tipo_recetas)
)


CREATE TABLE Recetas
(
	id_receta int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	cheff varchar(100) NULL,
	tipo_receta int NOT NULL,
	constraint Fk_Recetas primary key (id_receta)
)

CREATE TABLE Ingredientes
(
	id_ingrediente int NOT NULL,
	n_ingrediente varchar(50) NOT NULL,
	unidad_medida varchar(50) NULL,
 CONSTRAINT PK_Ingredientes PRIMARY KEY (id_ingrediente) 
)

CREATE TABLE Detalles_Receta
(
	id_detalle_receta int identity(1,1),
	id_receta int NOT NULL,
	id_ingrediente int NOT NULL,
	cantidad numeric(5, 2) NOT NULL
	constraint Fk_Detalles_Receta primary key(id_detalle_receta),
	constraint PK_Detalles_Receta_Recetas foreign key(id_receta)
	references Recetas(id_receta),
	constraint PK_PK_Detalles_Receta_Ingredientes foreign key(id_ingrediente)
	references Ingredientes(id_ingrediente)
)


INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (1, N'Sal', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (2, N'Pimienta', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (3, N'Agua', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (4, N'Aceite', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (5, N'carne', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (6, N'caldo', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (7, N'Azucar', N'gramos')

select * from Ingredientes

select* from Tipo_Recetas

insert into Tipo_Recetas values('Recetas Ensaladas')
insert into Tipo_Recetas values('Recetas Rapidas')
insert into Tipo_Recetas values('Recetas Pastas')
insert into Tipo_Recetas values('Recetas Postres')
insert into Tipo_Recetas values('Recetas Comida Tradicional')
insert into Tipo_Recetas values('Recetas Comida Carnes')

select * from recetas

delete recetas where id_receta=2

insert into recetas (nombre,cheff, tipo_receta) values('Empanadas', 'Martitegui',5)
insert into recetas (nombre,cheff, tipo_receta) values('Asado', 'Coniglio',6)

select * from recetas
select * from Detalles_Receta

delete Detalles_Receta where id_detalle_receta=5

delete Detalles_Receta where id_detalle_receta 
insert into Detalles_Receta (id_receta,id_ingrediente,cantidad) values(4,5,2)
insert into Detalles_Receta (id_receta,id_ingrediente,cantidad) values(4,1,1)


-- sp Ingredientes 

CREATE PROC SP_CONSULTAR_INGREDIENTES
AS
BEGIN
	
	SELECT * from Ingredientes 
END

exec SP_CONSULTAR_INGREDIENTES

--Sp Tipos receta

CREATE PROC SP_CONSULTAR_TIPOS_RECETAS
AS
BEGIN
	
	SELECT * from Tipo_Recetas 
END

exec SP_CONSULTAR_TIPOS_RECETAS

--sp proxima factura

create proc SP_PROXIMA_FACTURA
@NEXT INT OUTPUT
AS
BEGIN 
SET @NEXT=(SELECT MAX(id_receta)+1 FROM recetas);
END