CREATE DATABASE pessoas

use pessoas

CREATE TABLE Cidade(
id int primary key,
nome varchar(20) not null,
)

CREATE TABLE Cliente(
id int primary key,
nome varchar(50) not null,
genero varchar(1) CHECK (genero='M' AND genero='F') not null,
cc int not null,
datanascimento varchar(10),
id_cidade int 
foreign key (id_cidade) REFERENCES Cidade(id),
pontos_acum int CHECK (pontos_acum>=0),
)


CREATE TABLE Produto(
id int primary key,
descricao varchar(20) not null,
preco float not null,
)


CREATE TABLE Vendas(
id int primary key,
data datetime not null,
id_produto int not null,
foreign key (id_produto) REFERENCES produto(id),
qtd int CHECK (qtd>=0) not null,
id_cliente int not null,
foreign key (id_cliente) REFERENCES Cliente(id),
)