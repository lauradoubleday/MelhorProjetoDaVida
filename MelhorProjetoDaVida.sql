create database Laura_Doubleday;
use Laura_Doubleday;

create table tbl_Login(
cpf varchar (11) not null primary key,
email varchar (40) not null,
senha int not null
);

create table tbl_dados(
id int not null auto_increment primary key,
lhckd varchar (100) not null,
l04 varchar (40) not null,
d05 varchar (40) not null
);

create table tbl_usuario(
nome varchar (100) not null,
cpf varchar (11) not null primary key,
email varchar (40) not null,
senha varchar (40) not null
);

