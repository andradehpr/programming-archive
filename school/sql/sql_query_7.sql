CREATE DATABASE xpto 

CREATE TABLE test2(

id int primary key,
nome varchar (50) not null,
idade int



)

CREATE TABLE test1(

id int primary key,
nome varchar (50),
id_test int 
FOREIGN KEY (id_test) REFERENCES test2(id)

)

INSERT INTO test2 (id, nome)
VALUES ('27', 'Joao');

INSERT INTO test1 (id, nome)
VALUES ('4146', 'Ana');


DROP TABLE test1 ; 

ALTER TABLE table2
ADD genero varchar not null;


