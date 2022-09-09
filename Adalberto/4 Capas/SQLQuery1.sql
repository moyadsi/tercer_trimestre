-- Crear l base de datos
create database DB_Empresa;

-- Usar la base de datos
use DB_Empresa;

-- Crear tabla
create table Empleado(
	id_Emp varchar(15) primary key,
	nombre varchar(30) not null,
	apellido varchar(50) not null,
	telefono varchar(15) null,
	salario float 
);

-- Insertar registro
INSERT INTO Empleado(id_Emp,nombre,apellido,telefono,salario) 
values('124356434','Juan Carlos','Gómez Perez','2345677',4000000);

-------------------------------------------------------------------------------
-- Manejo de variables
-- Definicion de variables
declare @nom varchar(20);
declare @nom2 varchar(20);
declare @salario float

-- Asignacion de variables
-- Set o Select
set @nom='Pedro';
set @salario=900;
select @nom2=nombre from Empleado where id_Emp='124356434';

-- Como imprimir el valor de una variable
-- print / select
print 'nombre:'+@nom;
print @nom2;
select @nom as nombre;
print 'Salario:'+convert(varchar(10),@salario)
select @salario

if(@salario>3000000)
	begin
	select'Mayor a 3000000'
	select @salario;
	end
else
	select 'Menor a 3000000'

create procedure USP_lista_Emp

as
begin
	select * from empleado 
end

create procedure USP_consultar_Emp
	@id_Emp varchar(15)
as
begin
	select * from empleado where id_Emp=@id_Emp
end


create procedure USP_grabar_Emp
	@id_Emp varchar(15), @nombre varchar(30),
	@apellido varchar(50), @telefono varchar(15),
	@salario float
as
begin
INSERT INTO Empleado(id_Emp,nombre,apellido,telefono,salario) 
values(@id_Emp,@nombre,@apellido,@telefono,@salario);
end

create procedure USP_eliminar_Emp
	@id_Emp varchar(15)
as
begin
	delete from empleado where id_Emp=@id_Emp
end

create procedure USP_actualizar_Emp
	@id_Emp varchar(15)
as
begin
	delete from empleado where id_Emp=@id_Emp
end

--ejecutar procedimiento
execute USP_eliminar_Emp '1094902413'
execute USP_consultar_Ep '124356434'
execute USP_grabar_Emp '1094902413','Diana','Moya','3002507458','1000000';

actualizar
eliminr cienets

select * from empleado;