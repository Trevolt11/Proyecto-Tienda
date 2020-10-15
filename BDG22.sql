create database BDG2
go
create table Productos(
Idproductos int constraint pk_idp primary key,
nombre_producto varchar(20) not null,
codigo int not null,
stock int not null,
fecha_vencimiento datetime,
descripcion varchar(20) not null,
IDcategoriap int,
estado varchar(20) not null
)
go
create table categorias(
IDcategoria int constraint pk_idc primary key,
nombre_producto varchar(20) not null,
Estado varchar(10) not null,
)
go

--drop table Productos
--drop table categorias

go
alter table Productos add CONSTRAINT fk_categoria foreign key  (IDcategoriap) references categorias (IDcategoria)
go

insert into categorias values (1,'embutidos','Disponible')
insert into categorias values (2,'frutas','Disponible')
go
insert into Productos values (2,'jamon','1','10','12-4-2025','Nada',1,'Activo')
insert into Productos values (3,'manzana','1','8','10-31-2020','Nada',2,'Activo')

--delete from Productos where Idproductos = 5
--delete from categorias where IDcategoria = 2


select * from categorias
select * from Productos

create PROC ModificarRegistro
@Idproductos int,
@nombre_producto nvarchar(100),
@codigo int,
@stock int,
@fecha_vencimiento nvarchar(100),
@descripcion nvarchar(100),
@IDcategoriap int,
@estado nvarchar(100)
as
Update Productos set nombre_producto=@nombre_producto,codigo=@codigo,stock=@stock,fecha_vencimiento=@fecha_vencimiento,descripcion=@descripcion,IDcategoriap=@IDcategoriap,estado=@estado
where Idproductos=@Idproductos
go
create proc EliminarProducto
@Idproductos int
as
delete from Productos where Idproductos=@Idproductos
go

go

--drop proc ModificarRegistro

exec ModificarRegistro 2,'bbbb','1','8','02-11-2020','Nada',1,'Innactivo'



--test
SET TRANSACTION ISOLATION LEVEL REPEATABLE	READ
BEGIN TRY
	BEGIN TRANSACTION  

	select Productos.*,categorias.nombre_producto from Productos
		inner join categorias on Productos.IDcategoriap = categorias.IDcategoria

			select Productos.*,categorias.nombre_producto  as categoria from Productos
		inner join categorias on Productos.IDcategoriap = categorias.IDcategoria

	COMMIT   
end try
BEGIN CATCH   
	ROLLBACK   
	print'Error: '+ERROR_MESSAGE()
end catch



