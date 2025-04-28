Create database fixo;
use fixo;
drop database fixo;
create table direccion(
	idDireccion int(11)primary key,
    Direccion varchar(45),
    Ciudad varchar(45),
    Pais varchar(45)
);
insert into direccion (idDireccion, Direccion, Ciudad, Pais) values
(02918, '11av D casa 21', 'Guatemala', 'Guatemala'),
(34892, '14av F casa 2132', 'Bogota', 'Colombia'),
(12341, '4av E casa 21', 'Cartagena', 'Colombia'),
(12452, '5av B casa 21', 'CDMX', 'Mexico'),
(56864, '21av A casa 21', 'Guatemala', 'Guatemala');


create table cliente (
    idCliente int(11)primary key,
    Nombre varchar(45),
    Apellido varchar(45),
    Edad int(11),
    Direccion_idDireccion int(11),
    FOREIGN KEY (Direccion_idDireccion) REFERENCES direccion(idDireccion)  on delete cascade
);
insert into cliente(idCliente, Nombre, Apellido, Edad, Direccion_idDireccion) values
(21332, 'Eduardo', 'Paredes', '24', 02918),
(2342345, 'Juliana', 'Escobar','34', 34892),
(14645, 'Andre', 'Morales','53', 12341),
(2341, 'Sandra', 'Torres', '23', 12452),
(54252, 'Elise', 'Chutan', '57', 56864);


create table renta (
    idRenta int(11) primary key,
    Fecha_renta date,
    Fecha_devolucion date,
    Inventario_idCopiasPeliculas int(11),
    cliente_idCliente int(11),
    foreign key (cliente_idCliente) references cliente(idCliente)  on delete cascade
);
insert into renta(idRenta,Fecha_renta,Fecha_devolucion, Inventario_idCopiasPeliculas,cliente_idCliente) values
(42311, '2025-04-13', '2025-04-28', 233122, 21332),
(23453445, '2022-03-23', '2022-05-28', 25251, 2342345),
(345221, '2023-01-21', '2024-04-28', 36542431, 14645),
(235265, '2025-05-13', '2025-07-12', 422354, 2341),
(363532, '2025-04-12', '2025-06-23', 2541232, 54252);


create table categoria(
	idCategoria int(11)primary key,
    Nombre varchar(45)
);
insert into categoria(idCategoria, Nombre) values
(12, 'Suspenso'),
(15, 'Terror'),
(11, 'Heroes'),
(4, 'Ciencia Ficcion'),
(23, 'Animacion');


create table peliculas (
    idPeliculas int(11)primary key,
    Nombre varchar(45),
    Duracion varchar(45),
    Descripcion text,
    Año int(11),
    Categoria_idCategoria int(11),
    FOREIGN KEY (Categoria_idCategoria) REFERENCES categoria(idCategoria)  on delete cascade
);
insert into peliculas(idPeliculas, Nombre, Duracion, Descripcion, Año, Categoria_idCategoria) values
(12123, 'Super Man', '120 minutos', 'Combatir a grandes amenazas', 2012, 12),
(435522, 'Spider Man', '124minutos', 'Combatir a grandes amenazas', 2016, 15),
(213523, 'Sonic', '110 minutos', 'Una rata azul que rueda', 2022, 11),
(54362, 'POKEMON1', '100 minutos', 'Animales mutados geneticamente', 2033, 4),
(643773, 'Deadpool', '124 minutos', 'Un inmortal que no tiene nada que hacer', 2024, 23);


create table inventario (
    idCopiasPeliculas int(11)primary key,
    Peliculas_idPeliculas int(11),
    Disponible tinyint(1),
    FOREIGN KEY (peliculas_idPeliculas) REFERENCES peliculas(idPeliculas)  on delete cascade
);
insert into inventario(idCopiasPeliculas, Peliculas_idPeliculas, Disponible) values
(32432,  12123, 7),
(75633, 435522, 3),
(23562, 213523, 5),
(21443, 54362, 4),
(23423, 643773, 1);


create table tiendas_FIXO(
	idTienda int(11) primary key,
	Nombre_tienda varchar(44),
    Pais_tienda varchar(44),
    Direccion_tienda varchar(44),
    Gerente_tienda varchar(44),
    Telefono_tienda int(11)
);
insert into tiendas_FIXO (idTienda, Nombre_tienda, Pais_tienda, Direccion_tienda, Gerente_tienda, Telefono_tienda) values
('23142', 'FIXO Portales', 'Guatemala','5 av. A calle 37 Zn.9', 'Luis Miguel', '34542165'),
('746743', 'FIXO Yucat', 'Mexico','8 av. B calle 32 Zn.3', 'Francisco Orellana', '673325634'),
('364579', 'FIXO Ostia', 'España','4 av. D calle 6 Zn.4', 'Miguel Oliva', '76453423'),
('26746543', 'FIXO Wasa', 'Peru','2 av. A calle 45 Zn.5', 'Oscar Lemus', '3654322'),
('345342', 'FIXO Cifuentes', 'Colombia','4 av. C calle 23 Zn.5', 'Camilo Ortega', '54256654');


create table lista_negra(
	idCliente int(11) primary key,
    Nombre_cliente varchar(44),
    Motivo_de_vetado varchar(44)
);
insert into lista_negra(idCliente, Nombre_cliente, Motivo_de_vetado) values
('4362524','Raul','Robo'),
('233243','Oscar','Falta de respeto'),
('2351113','Daniel','No realizo una devolucion'),
('43641','Jose','Robo'),
('65362','Otto','Falta de respeto');


select * from direccion;

select * from cliente;
select * from cliente where Nombre = 'Juliana';

select * from renta;
select * from renta order by Fecha_renta DESC;

select * from inventario;

select * from categoria;
select * from categoria order by nombre ASC;

select * from peliculas;
delete from peliculas where Nombre = 'POKEMON1';

select * from tiendas_FIXO;
select * from lista_negra;
