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
