
create database remedios

use remedios

create table pais(
id int primary key,
descricao varchar(50) not null);

create table cidade(
id int primary key,
descricao varchar(50) not null,
id_pais int references pais(id));

create table cliente(
id int primary key,
nome varchar(50) not null,
nif  varchar(50)  not null,
genero char(1) check(genero in ('M','F')),
datanasc date,
id_encEduc int references cliente(id)
);

create table laboratorio(
id int primary key,
descricao varchar(50) not null,
id_pais int references pais(id));



create table medicamento (
id int primary key,
descricao varchar(50) not null,
id_laboratorio int references laboratorio(id),
qtd_stock int check(qtd_stock >=0),
preco decimal(6,2) 
);

create table venda(
id int primary key,
data date,
id_cliente int references cliente(id),
id_cidade int references cidade(id),
id_medicamento int references medicamento(id),
qtd int not null check (qtd > 0)
);



 -- paises
  insert into pais values(1, 'PORTUGAL');
  insert into pais values(2, 'ESPANHA');
  insert into pais values(3, 'FRANÇA');
  insert into pais values(4, 'ALEMANHA');
  insert into pais values(5, 'ITALIA');

  -- cidades
  insert into cidade values (1,'LISBOA',1);
  insert into cidade values (2,'PORTO',1);
  insert into cidade values (3,'BRAGANÇA',1);
  insert into cidade values (4,'BRAGA',1);
  insert into cidade values (5,'BARCELONA',2);
  insert into cidade values(6,'MADRID',2);
  insert into cidade values (7,'BILBAO',2);
  insert into cidade values(8,'BURGOS',2);
  insert into cidade values(9,'MILAO',5);
  insert into cidade values(10,'XANGAI',NULL);


  -- clientes
  insert into cliente values (1,'Ana Silva','133787654','F','19900302',null);
  insert into cliente values (2,'Teresa Gonçalves','676435132','F','19851006',null);
  insert into cliente values (3,'João Mendes','453239872','M','20010523',null);
  insert into cliente values (4,'Ivo Ribeiro','154653987','M','19701221',null);
  insert into cliente values (5,'João Júnior Mendes','555555555','M','20100701',3);
  insert into cliente values (6,'Ana Rita Gonçalves','666666666','F','20171130',2);



  -- laboratórios
  insert into laboratorio values (1,'GENERIS',1);
  insert into laboratorio values (2,'PIERRE FABRE',3);
  insert into laboratorio values (3,'JABA RECORDATI',5);
  insert into laboratorio values (4,'BENE',4);
  insert into laboratorio values (5,'UNILFARMA',null);


  -- medicamentos
  insert into medicamento values (1,'Pain Killer',1,4,10.50);
  insert into medicamento values (2,'Stop Fever',1,3,5);
  insert into medicamento values (3,'Stay Awake',1,10,8.30);
  insert into medicamento values (4,'Strong Bones',1,2,20.85);
  insert into medicamento values (5,'Muscles',1,4,30);

  insert into medicamento values (6,'Fresh&Clean',3,0,2.5);
  insert into medicamento values (7,'Kill Jet Leg',3,1,12.10);
  insert into medicamento values (8,'Peaceful Sleep',3,0,25.30);
  insert into medicamento values (9,'Good moon',3,2,40.90);
  insert into medicamento values (10,'Stay Young',3,8,33.23);

  insert into medicamento values (11,'Bandage',2,0,2.5);
  insert into medicamento values (12,'Álcool',2,1,12.10);
  insert into medicamento values (13,'Betadine',4,0,25.30);
  insert into medicamento values (14,'Paracetamol',2,12,4.90);
  insert into medicamento values (15,'ben-u-ron',4,20,5.79);

 -- venda

 insert into venda values(1,'2017-02-03',1,2,1,3);
 insert into venda values(2,'2017-02-03',1,2,2,1);
 insert into venda values(3,'2017-02-03',2,1,3,3);
 insert into venda values(4,'2017-02-03',2,1,4,1);
 insert into venda values(5,'2017-02-03',2,1,10,1);
 insert into venda values(6,'2017-02-03',2,1,7,1);
 insert into venda values(7,'2017-02-03',4,3,11,2);
 insert into venda values(8,'2017-02-03',4,4,8,1);
 insert into venda values(9,'2017-02-03',3,4,6,3);
 insert into venda values(10,'2017-02-03',3,4,1,4);

 insert into venda values(11,'2017-02-03',4,2,4,1);
 insert into venda values(12,'2017-02-03',4,2,4,2);
 insert into venda values(13,'2017-02-03',3,1,10,3);
 insert into venda values(14,'2017-02-04',4,1,15,1);
 insert into venda values(15,'2017-02-04',3,1,10,3);
 insert into venda values(16,'2017-02-03',2,1,7,2);
 insert into venda values(17,'2017-02-05',3,1,12,1);
 insert into venda values(18,'2017-02-03',4,4,13,1);
 insert into venda values(19,'2017-02-03',3,4,13,1);
 insert into venda values(20,'2017-02-03',3,4,2,3);  

