create database Moto_Road ;
use Moto_Road ;

-- se crea la tabla de pasajeros 

create table registro_pasajero (
id_pas int auto_increment primary key  ,
nombres varchar (45) not null,
apellidos varchar (45) not null,
correo varchar (50) not null,
telefono varchar (20) not null,
contraseña varchar (40) not null,
fecha_nacimiento date  not null,
genero varchar (10)
);

-- se crea la tabla de conductores

create table registro_conductor (
id_con int auto_increment primary key  ,
nombres varchar (45) not null,
apellidos varchar (45) not null,
correo varchar (50) not null,
telefono varchar (20) not null,
contraseña varchar (40) not null,
fecha_nacimiento date  not null,
genero varchar (10) not null 
);

-- se crea la tabla de muchos  a muchos 

create table registro_pasajero_registro_conductor (
id_pas int ,
id_con int ,
constraint fk_registro_pasajero  foreign key (id_pas) references registro_pasajero (id_pas),
constraint fk_registro_conductor foreign key (id_con) references registro_conductor (id_con)
);
