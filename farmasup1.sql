create database farmacia;
use farmacia; 
create table cargo(
codigocargo int primary key auto_increment,
cargo varchar(100)
);
create table usuario(
codigo int primary key auto_increment ,
nome varchar(100),
email varchar(100),
senha varchar(255),
cargo int,
ativo tinyint,
constraint fk_cargo foreign key (cargo) references cargo(codigocargo)
);

insert into cargo(cargo) values ("gerente");
insert into cargo(cargo) values ("estoquista");
insert into cargo(cargo) values ("vendedor");

create table tipo(
codigotipo int primary key auto_increment,
tipo varchar(100)
);

insert into tipo(tipo) values ("Frutado");
insert into tipo(tipo) values ("Chá");
insert into tipo(tipo) values ("Cremoso");

create table produto(

codigoProduto int primary key auto_increment,
descricao varchar(100),
valor decimal(5,2),
quantidade int,
foto varchar(100),
nome varchar(100),
tipo int,
constraint fk_tipo foreign key (tipo) references tipo(codigotipo)
);

create table categoria(
codigotipocli int primary key auto_increment,
categoria varchar(800)
);

insert into categoria(categoria) values ("Paciente");
insert into categoria(categoria) values ("Profissional");
insert into categoria(categoria) values ("Estabelecimento");

create table cliente(
codigocliente int primary key auto_increment,
nome varchar(60),
fone varchar(15),
email varchar(100),
cpf varchar(30),
cep varchar(20),
foto varchar(100),
categoria int,
constraint fk_tipocliente foreign key (categoria) references categoria(codigotipocli)
);