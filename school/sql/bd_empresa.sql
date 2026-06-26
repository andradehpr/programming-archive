create database empresa
use empresa
create table cidade(
  id int primary key identity,
  nome varchar(50)
)
insert into cidade values ('Lisboa'),('Porto'),('Leiria'),('Faro')
create table departamento(
  id int primary key identity,
  nome varchar(50)
)
insert into departamento values ('Vendas'),('Informática'),('Finanças'),('Recursos Humanos')

create table empregado(
  id int primary key identity,
  nome varchar(50),
  genero char(1) check(genero in ('F','M')),
  id_cidade int references cidade(id),
  salario money,
  idade int, 
  id_departamento int references departamento(id)
)
insert into empregado values 
  ('João','M',1,1500,24,2),
  ('Maria','F',1,2500,32,3),
  ('Inês','F',4,1700,34,3),
  ('André','M',3,1900,42,4),
  ('Rita','F',3,3400,42,null)

