drop database if exists Proyecto;
create database Proyecto;
use Proyecto;

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
constraint pk_usuario primary key (CodSoc)
);


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
