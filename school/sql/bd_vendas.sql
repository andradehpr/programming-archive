
create database vendas

use vendas

create table cidade(
id int primary key,
nome varchar(50) not null
)

create table cliente(
id int primary key,
nome varchar(50) not null,
genero char(1) not null check (genero in ('m','f')),
CC char(8) unique not null,
data_nasc date,
id_cidade int constraint fk_cliente_cidade foreign key references cidade(id),
pontos_acum int
)

create table produto(
id int primary key,
descricao varchar(50),
preco money
)

create table vendas(
id int primary key,
data date,
id_produto int constraint fk_vendas_produto foreign key references produto(id),
qtd int,
id_cliente int constraint fk_vendas_cliente foreign key references cliente(id)
)

insert into cidade values(1,'Lisboa'),(2,'Porto'),(3,'Faro'),(4,'Coimbra');
insert into cliente values(1,'Guilherme','m','99887766','19990110',1,500),
                          (2,'Hugo','m','88990011','19931215',4,600),
                          (3,'Joana','f','11223344','20000323',1,200),
                          (4,'Rita','f','22334455','19800608',2,350),
                          (5,'João','m','33445566','19820422',3,650),
                          (6,'Paulo','m','44556677','19960630',2,150),
                          (7,'Ana','f','55667788','19921002',3,200),
                          (8,'David','m','66778899','19870501',2,450),
                          (9,'Maria','f','12345678','19950207',3,1000);
insert into produto values(1,'Lays',1),(2,'Ruffles',0.7),(3,'Cheetos',0.6);
insert into vendas values(1,'2018-03-02',1,2,2),(2,'2018-03-02',2,1,2),(3,'2018-03-02',1,1,1),(4,'2018-03-02',1,3,3),(5,'2018-03-03',3,2,3),(6,'2018-03-03',2,4,1);
