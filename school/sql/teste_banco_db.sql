--- Criação da base de dados---
-------------------------------
-------------------------------

create database bancoDB

use bancoDB

create table cidade(
  id int primary key identity,
  nome varchar(50) not null unique 
)

create table balcao(
  id int primary key identity,
  codigo varchar(20) not null unique,
  id_cidade int not null references cidade(id)  
)


create table cliente(
  id int primary key identity,
  nome varchar(50) not null,
  cc char(12) not null unique,
  nif char(8) not null unique,
  genero char(1) check (genero in ('M','F')),
  datanasc date not null,
  estado_civil char(3) check (estado_civil in ('CAS','SOL','SEP','UNI','VIU')),
  salario money,
  id_cidade_habitacao int references cidade(id),
  id_EncEdu int references cliente(id)
)

create table conta(
  id int primary key identity,
  iban varchar(50) not null unique,
  ctOrdenado bit default 0,  -- 0 não é conta ordenado; 1 é conta ordenado
  id_titular1 int references cliente(id) not null,
  id_titular2 int references cliente(id),
  saldo money not null,
  id_balcao int references balcao(id) not null
)

create table tipoEmprestimo(
  id int primary key identity,
  descricao varchar(50) not null unique
)

create table emprestimo(
  codigo varchar(20) primary key,
  dataInicio date,
  importancia money not null,
  estado char(1) check (estado in ('P','A','L')),
  id_cliente int references cliente(id),
  tipoEmprestimo int references tipoEmprestimo(id)
)

create table pagamento(
  num_emp varchar(20) references emprestimo(codigo),
  id_pagamento smallint,
  datapag date not null,
  importanciapaga money not null,
  primary key (num_emp, id_pagamento) 
)

-- ----------------------
-- Inserção de dados
-- ----------------------

-- Cidades

insert into cidade values ('Lisboa'),('Porto'),('Faro'),('Leiria'),('Aveiro'),('Maia'),('Évora'),('Beja'),('Tavira'),('Braga')


-- Balcões

insert into balcao values ('001',1),('002',2),('003',3),('004',5),('005',6)


-- Clientes

insert into cliente values ('Ana Maria','0963456','16623345','F','1978-03-22','SOL',2500,1,null)
insert into cliente values ('João Gonçalves','7063337','4428378','M','1980-11-17','CAS',600,2,null)
insert into cliente values ('Pedro Gonçalves','1063337','5428378','M','1960-12-05','VIU',1500,1,null)
insert into cliente values ('Luisa Pereira','8867314','6428399','F','2010-06-15','SOL',null,1,1)
insert into cliente values ('Miguel Pé-Descalço','3857315','242839','M','1983-04-30','SOL',500,1,null)
insert into cliente values ('Ana GastaTudo','4856312','152738','F','1981-01-02','UNI',5500,2,null)
insert into cliente values ('Miguel Poupadinho','3857318','252839','M','1985-03-25','SOL',1500,2,null)
insert into cliente values ('João Snob','5852316','512833','M','1975-02-23','CAS',5500,3,null)
insert into cliente values ('Pedro Betinho','7142313','914835','M','1975-02-23','UNI',2500,4,null)
insert into cliente values ('Junior Betinho','6142112','224730','M','2005-07-10','SOL',null,4,9)
insert into cliente values ('Rita Fonseca','9944312','614835','F','1979-05-13','CAS',1300,5,null)
insert into cliente values ('Luis Fonseca','9855359','714837','M','1977-07-09','CAS',1500,5,null)
insert into cliente values ('Manuel Massas','0145397','415834','M','1983-12-27','UNI',3500,6,null)
insert into cliente values ('José Rico','2165394','215833','M','1983-04-26','SOL',6500,6,null)
insert into cliente values ('Isabel Mendes','8165492','016823','F','1993-08-15','CAS',1800,6,null)
insert into cliente values ('Rafael BoaPinga','7365482','736828','M','1991-02-08','UNI',1900,7,null)
insert into cliente values ('José Ponderado','7866494','565827','M','1969-05-05','CAS',2100,7,null)
insert into cliente values ('Fernanda Ponderado','5865403','665723','F','2012-11-18','SOL',null,7,17)
insert into cliente values ('António Ponderado','6665422','095721','M','2010-05-01','SOL',null,7,17)
insert into cliente values ('Alexandre BoaVida','1325432','376623','M','1991-01-08','UNI',1000,10,null)
insert into cliente values ('Licia BoaVida','3325438','476627','F','1978-05-12','UNI',1300,10,null)
insert into cliente values ('Guilherme OldMan','12345678','321321','M','1929-02-28','VIU',1350,3,null)
insert into cliente values ('Alexandre Pereira','25345677','623329','M','1957-03-07','VIU',2350,null,null)



-- Conta

insert into conta values ('PT50 001 002 003',0,11,12,2345.30,5)
insert into conta values ('PT50 001 003 003',1,21,20,3152.50,5)
insert into conta values ('PT50 001 003 103',1,17,null,4330.45,3)
insert into conta values ('PT50 001 003 113',1,17,null,330,3)
insert into conta values ('PT50 001 003 223',0,18,null,3330,3)
insert into conta values ('PT50 001 003 222',0,19,null,4000,3)
insert into conta values ('PT50 001 003 233',0,8,null,10000,3)
insert into conta values ('PT50 001 003 200',0,8,null,3000,3)
insert into conta values ('PT50 001 003 210',1,8,null,2000,3)
insert into conta values ('PT50 001 003 215',0,22,null,20000,3)
insert into conta values ('PT50 001 003 220',1,9,null,12000,5)
insert into conta values ('PT50 001 003 221',0,10,null,2500,5)
insert into conta values ('PT50 001 003 224',1,1,3,1500,1)
insert into conta values ('PT50 001 003 225',1,3,1,2500,1)
insert into conta values ('PT50 001 003 226',1,4,null,1550.25,1)
insert into conta values ('PT50 001 003 227',0,4,null,1650,1)
insert into conta values ('PT50 001 003 228',1,13,null,6650,4)
insert into conta values ('PT50 001 003 229',0,13,null,3650,4)
insert into conta values ('PT50 001 003 332',0,13,null,7000,1)
insert into conta values ('PT50 001 003 333',0,13,null,3200,2)
insert into conta values ('PT50 001 003 400',1,14,null,5000,5)
insert into conta values ('PT50 001 003 401',0,14,null,25000,1)
insert into conta values ('PT50 001 003 402',0,14,null,55000,2)
insert into conta values ('PT50 001 003 403',0,6,null,600,2)
insert into conta values ('PT50 001 003 404',0,2,6,750,2)
insert into conta values ('PT50 001 003 405',0,7,6,950,2)
insert into conta values ('PT50 001 003 406',0,7,null,1050,2)


-- Tipos de Emprestimo

insert into tipoEmprestimo values('Casa'),('Carro'),('Estudo'),('Viagem'),('Negócio'),('Outros')



-- Emprestimos

insert into emprestimo values ('CAS001','2016-02-01',15000,'A',6,1)
insert into emprestimo values ('CAS002','2017-08-01',20000,'A',8,1)
insert into emprestimo values ('CAS003',null,50000,'P',1,1)
insert into emprestimo values ('CAS004',null,40000,'P',4,1)
insert into emprestimo values ('CAR001','2016-05-01',55000,'L',6,2)
insert into emprestimo values ('CAR002','2017-08-01',10000,'A',4,2)
insert into emprestimo values ('CAR003',null,13000,'P',2,2)
insert into emprestimo values ('NEG001','2016-05-01',60000,'L',15,5)
insert into emprestimo values ('NEG002','2017-08-01',15000,'A',6,5)
insert into emprestimo values ('NEG003','2017-08-01',18000,'A',2,5)
insert into emprestimo values ('NEG004','2018-01-01',33000,'P',17,5)
insert into emprestimo values ('NEG005',null,25000,'P',16,5)

-- Pagamentos

insert into pagamento values ('CAS001',1,'2016-02-01',300)
insert into pagamento values ('CAS001',2,'2016-03-01',300)
insert into pagamento values ('CAS001',3,'2016-04-01',300)
insert into pagamento values ('CAS001',4,'2016-05-01',300)
insert into pagamento values ('CAS001',5,'2016-06-01',300)
insert into pagamento values ('CAS001',6,'2016-07-01',300)
insert into pagamento values ('CAS001',7,'2016-08-01',300)
insert into pagamento values ('CAS001',8,'2016-09-01',300)
insert into pagamento values ('CAS001',9,'2016-10-01',300)
insert into pagamento values ('CAS001',10,'2016-11-01',300)
insert into pagamento values ('CAS001',11,'2016-12-01',300)
insert into pagamento values ('CAS001',12,'2017-01-01',300)
insert into pagamento values ('CAS001',13,'2017-02-01',300)
insert into pagamento values ('CAS001',14,'2017-03-01',300)
insert into pagamento values ('CAS001',15,'2017-04-01',300)
insert into pagamento values ('CAS001',16,'2017-05-01',300)
insert into pagamento values ('CAS001',17,'2017-06-01',300)
insert into pagamento values ('CAS001',18,'2017-07-01',300)
insert into pagamento values ('CAS001',19,'2017-08-01',300)
insert into pagamento values ('CAS001',20,'2017-09-01',300)
insert into pagamento values ('CAS001',21,'2017-10-01',300)
insert into pagamento values ('CAS001',22,'2017-11-01',300)
insert into pagamento values ('CAS001',23,'2017-12-01',300)
insert into pagamento values ('CAS001',24,'2018-01-01',300)
insert into pagamento values ('CAS001',25,'2018-02-01',300)
insert into pagamento values ('CAS001',26,'2018-03-01',300)
insert into pagamento values ('CAS001',27,'2018-04-01',300)
insert into pagamento values ('CAS001',28,'2018-05-01',300)
insert into pagamento values ('CAS001',29,'2018-06-01',300)


insert into pagamento values ('CAS002',1,'2017-09-01',500)
insert into pagamento values ('CAS002',2,'2017-10-01',500)
insert into pagamento values ('CAS002',3,'2017-11-01',500)
insert into pagamento values ('CAS002',4,'2017-12-01',500)
insert into pagamento values ('CAS002',5,'2018-01-01',500)
insert into pagamento values ('CAS002',6,'2018-02-01',500)
insert into pagamento values ('CAS002',7,'2018-03-01',500)
insert into pagamento values ('CAS002',8,'2018-04-01',500)
insert into pagamento values ('CAS002',9,'2018-05-01',500)
insert into pagamento values ('CAS002',10,'2018-06-01',500)


insert into pagamento values ('CAR001',1,'2016-05-01',2000)
insert into pagamento values ('CAR001',2,'2016-06-01',2000)
insert into pagamento values ('CAR001',3,'2016-07-01',2000)
insert into pagamento values ('CAR001',4,'2016-08-01',2000)
insert into pagamento values ('CAR001',5,'2016-09-01',2000)
insert into pagamento values ('CAR001',6,'2016-10-01',2000)
insert into pagamento values ('CAR001',7,'2016-11-01',2000)
insert into pagamento values ('CAR001',8,'2016-12-01',2000)
insert into pagamento values ('CAR001',9,'2017-01-01',2000)
insert into pagamento values ('CAR001',10,'2017-01-01',2000)


insert into pagamento values ('CAR002',1,'2017-09-01',100)
insert into pagamento values ('CAR002',2,'2017-10-01',100)
insert into pagamento values ('CAR002',3,'2017-11-01',100)
insert into pagamento values ('CAR002',4,'2017-12-01',100)
insert into pagamento values ('CAR002',5,'2018-01-01',100)
insert into pagamento values ('CAR002',6,'2018-02-01',100)
insert into pagamento values ('CAR002',7,'2018-03-01',100)
insert into pagamento values ('CAR002',8,'2018-04-01',100)
insert into pagamento values ('CAR002',9,'2018-05-01',100)
insert into pagamento values ('CAR002',10,'2018-06-01',100)



insert into pagamento values ('NEG001',1,'2016-06-01',3000)
insert into pagamento values ('NEG001',2,'2016-07-01',3000)
insert into pagamento values ('NEG001',3,'2016-08-01',3000)
insert into pagamento values ('NEG001',4,'2016-09-01',3000)
insert into pagamento values ('NEG001',5,'2016-10-01',3000)
insert into pagamento values ('NEG001',6,'2016-11-01',3000)
insert into pagamento values ('NEG001',7,'2016-12-01',3000)
insert into pagamento values ('NEG001',8,'2017-01-01',3000)
insert into pagamento values ('NEG001',9,'2017-02-01',3000)
insert into pagamento values ('NEG001',10,'2017-03-01',3000)
insert into pagamento values ('NEG001',11,'2017-04-01',3000)
insert into pagamento values ('NEG001',12,'2017-05-01',3000)
insert into pagamento values ('NEG001',13,'2017-06-01',3000)
insert into pagamento values ('NEG001',14,'2017-07-01',3000)
insert into pagamento values ('NEG001',15,'2017-08-01',3000)
insert into pagamento values ('NEG001',16,'2017-09-01',3000)
insert into pagamento values ('NEG001',17,'2017-10-01',3000)
insert into pagamento values ('NEG001',18,'2017-11-01',3000)
insert into pagamento values ('NEG001',19,'2017-12-01',3000)
insert into pagamento values ('NEG001',20,'2018-01-01',3000)


insert into pagamento values ('NEG002',1,'2017-09-01',500)
insert into pagamento values ('NEG002',2,'2017-10-01',500)
insert into pagamento values ('NEG002',3,'2017-11-01',500)
insert into pagamento values ('NEG002',4,'2017-12-01',500)
insert into pagamento values ('NEG002',5,'2018-01-01',500)
insert into pagamento values ('NEG002',6,'2018-02-01',500)
insert into pagamento values ('NEG002',7,'2018-03-01',500)
insert into pagamento values ('NEG002',8,'2018-04-01',500)
insert into pagamento values ('NEG002',9,'2018-05-01',500)
insert into pagamento values ('NEG002',10,'2018-06-01',500)
