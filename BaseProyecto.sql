drop database if exists proyecto;
create database proyecto;
use proyecto;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(1,'admin','1234',120);

create table socio(
CodSoc int auto_increment,
Nombre varchar (30) not null,
Apellido varchar (30) not null,
Dni int not null,
FechaNacimiento date not null,
Email varchar (30) not null,
Telefono varchar(15),
Direccion varchar (40),
FechaAlta date not null,
Activo boolean default true not null,
constraint pk_socio primary key (CodSoc)
);

/*insert into/ datos de socios*/
INSERT INTO socio (Nombre, Apellido, Dni, FechaNacimiento, Email, Telefono, Direccion, FechaAlta)
VALUES 
('Lucia', 'Perez', 33445566, '1990-03-15', 'lucia.perez@mail.com', '3511111111', 'Calle Falsa 123', '2024-04-18'),
('Tomas', 'Gonzalez', 44556677, '1985-08-10', 'tomas.g@mail.com', '3512222222', 'Av. Siempreviva 742', '2024-05-20'),
('Micaela', 'Suárez', 55667788, '1992-12-01', 'mica.suarez@mail.com', '3513333333', 'Mitre 456', '2025-01-08');

create table solicitante(
NSolic int primary key,
nombreS varchar(30) not null,
apellidoS varchar(30) not null);

create table nosocio(
CodNoSoc int auto_increment,
Nombre varchar (30) not null,
Apellido varchar (30) not null,
Dni int not null,
FechaNacimiento date not null,
Email varchar (30),
FechaAlta date not null,
NSolic int null,
constraint pk_nosocio primary key (CodNoSoc),
foreign key (NSolic) references solicitante (NSolic)
);

create table profesor(
IdProfesor int auto_increment primary key,
Nombre varchar (30) not null,
TipoDocumento varchar(20) not null,
Dni int not null,
SueldoMensual double
);

insert into profesor (Nombre, TipoDocumento, Dni, SueldoMensual) values
('Carlos Gómez', 'DNI', 34567890, 235000.00),
('María Pereyra', 'DNI', 29876543, 420000.00),
('Luis Adaro', 'Pasaporte', 12345678, 730000.00),
('Ana Roman', 'DNI', 27654321, 540000.00),
('Jorge Ramírez', 'Cédula', 45678901, 370000.00);

create table clase(
IdClase int auto_increment primary key,
IdProfesor INT,
Nombre varchar (30) not null,
Horario time not null,
Precio double,
CupoMaximo int,
HayDisponibilidad boolean,
foreign key (IdProfesor) references profesor(IdProfesor)
);

INSERT INTO clase (IdProfesor, Nombre, Horario, Precio, CupoMaximo, HayDisponibilidad) VALUES
(2,'Spinning','08:00:00', 1500.00, 20, TRUE),
(2,'Zumba','09:00:00', 1200.00, 25, TRUE),
(4,'Yoga','11:00:00', 1300.00, 15, TRUE),
(1,'Crossfit','17:00:00', 1800.00, 12, TRUE),
(1,'Funcional','18:00:00', 1600.00, 18, TRUE),
(4,'Pilates','07:00:00', 1400.00, 10, FALSE),
(5,'HIIT','19:00:00', 1650.00, 16, FALSE),
(4,'Stretching','13:00:00', 1100.00, 10, TRUE);

create table Profesor_Clase (
    IdProfesor int not null,
    IdClase int not null,
    primary key (IdProfesor, IdClase),
    foreign key (IdProfesor) references profesor(IdProfesor),
    foreign key (IdClase) references clase(IdClase)
);

create table AsistenciaProfesor (
    IdAsistencia int auto_increment primary key,
    IdProfesor int not null,
    Fecha date not null,
    foreign key (IdProfesor) references profesor(IdProfesor)
);

create table cuota (
     IdCuota int auto_increment primary key,
     Descripcion varchar (70) not null,
     Monto double,
     FechaVencimiento datetime,
     Pagada bool default false,
     CodSoc int not null,
     foreign key (CodSoc) references socio(CodSoc)
);

/*Insert into/datos para cuotas*/

INSERT INTO cuota (Descripcion, Monto, FechaVencimiento, Pagada, CodSoc) VALUES
('Cuota junio', 19000, CURDATE(), True, 1),         
('Cuota julio', 19000, CURDATE() + INTERVAL 13 DAY, False, 1),
('Cuota junio', 19000, CURDATE(), True, 2),
('Cuota julio', 19000, CURDATE() + INTERVAL 12 DAY, False, 2),
('Cuota junio', 19000, CURDATE() + INTERVAL 3 DAY, True, 3),
('Cuota julio', 19000, CURDATE() + INTERVAL 11 DAY, False, 3);


create table edicion (
    IdEdicion int primary key,
    IdClase int,
    fecha date,
    foreign key (IdClase) references clase(IdClase)
);

CREATE TABLE inscripcion (
    IdInscri int primary key,
    IdEdicion int,
    CodNoSoc int,
    foreign key (IdEdicion) references edicion(IdEdicion),
    foreign key (CodNoSoc) references nosocio(CodNoSoc)
);

/* insert dato de solicitante */
insert into solicitante (NSolic,nombreS, apellidoS) values (1,'Romina', 'Galman');
insert into nosocio(Nombre, Apellido, Dni, FechaNacimiento, Email, FechaAlta, NSolic) values ('Romina', 'Galman', 28654735, '1989-05-15', 'rgalman@gmail.com', '2024-11-25', 1);
insert into edicion (IdEdicion, IdClase, fecha) values (1,2, '2025-06-10');
insert into inscripcion (IdInscri,IdEdicion, CodNoSoc) values (1,1,1);


/* CREACION DEL PROCEDIMIENTO IngresoLogin */
/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */
delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */
end 
//

/* ==========================
si queremos probar el procedure se usa call
call IngresoLogin('dato1', 'dato2')//
====================================================== */
/* ===============================
si los datos de los parametros existen la consulta arroja 1 FILA
si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */

/* CREACION DEL PROCEDIMIENTO NuevoSocio
*************************************************   */
delimiter //  
create procedure NuevoSocio(
	in Nom varchar(30),
    in Ape varchar(30),
    in pDni int,
    in FeNac date,
    in Email varchar (30),
    in Tel varchar (15),
    in Dir varchar (40),
    in FeAlta date,
    out rta int)

begin
	declare existe int default 0;
    
    -- Verificamos si el socio ya existe por DNI
    select count(*) into existe from socio where Dni = pDni;
    
    if existe = 0 then
		-- Insertamos sin CodSoc, que es autoincremental
		insert into socio (Nombre, Apellido, Dni, FechaNacimiento, Email, Telefono, Direccion, FechaAlta)
        values (Nom, Ape, pDni, FeNac, Email, Tel, Dir, FeAlta);
		
        -- Obtenemos el ID autogenerado
        select LAST_INSERT_ID() into rta;
	else
		set rta = 0;
	end if;		 
end //

/* CREACION DEL PROCEDIMIENTO NuevoNoSocio
*************************************************   */
delimiter //  
create procedure NuevoNoSocio(
	in Nom varchar(30),
    in Ape varchar(30),
    in pDni int,
    in FeNac date,
    in Email varchar (30),
    in FeAlta date,
    in NSolic int,
    out rta int)

begin
	declare existe int default 0;
    
    -- Verificamos si el No Socio ya existe por DNI
    select count(*) into existe from nosocio where Dni = pDni;
    
    if existe = 0 then
		-- Insertamos sin CodNoSoc, que es autoincremental
		insert into nosocio (Nombre, Apellido, Dni, FechaNacimiento, Email, FechaAlta, NSolic)
        values (Nom, Ape, pDni, FeNac, Email, FeAlta, NSolic);
		
        -- Obtenemos el ID autogenerado
        select LAST_INSERT_ID() into rta;
	else
		set rta = 0;
	end if;		 
end //