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
estoque int,
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

create table vendas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data_venda DATETIME DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10,2) NOT NULL,
    forma_pagamento VARCHAR(50) NOT NULL
);

create table venda_itens (
    id INT AUTO_INCREMENT PRIMARY KEY,
    venda_id INT NOT NULL,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    preco_unitario DECIMAL(10,2) NOT NULL,
    desconto DECIMAL(10,2) DEFAULT 0,
    FOREIGN KEY (venda_id) REFERENCES vendas(id),
    FOREIGN KEY (produto_id) REFERENCES produtos(id)
);

SELECT * FROM produto WHERE nome LIKE @nome;

INSERT INTO vendas (total, forma_pagamento) 
VALUES (@total, @formaPagamento);

INSERT INTO venda_itens (venda_id, produto_id, quantidade, preco_unitario, desconto)
VALUES (@vendaId, @produtoId, @quantidade, @preco, @desconto);

UPDATE produtos 
SET estoque = estoque - @quantidade 
WHERE id = @produtoId;
