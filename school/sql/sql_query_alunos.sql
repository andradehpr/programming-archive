--1
--ALTER TABLE aluno ALTER COLUMN nome VARCHAR (255) NOT NULL 

--2
--ALTER TABLE aluno ADD morada VARCHAR(100), localidade VARCHAR(30), codigo_postal VARCHAR(8)

--3
--ALTER TABLE aluno DROP COLUMN foto 

--4
--ALTER TABLE aluno DROP CONSTRAINT fk_aluno_turma 

--5
ALTER TABLE turma_has_professor DROP CONSTRAINT fk_turma_has_professor_turma
ALTER TABLE turma DROP CONSTRAINT pk_turma
ALTER TABLE turma ALTER COLUMN silga INT NOT NULL 
ALTER TABLE turma ADD CONSTRAINT pk_turma PRIMARY KEY
ALTER TABLE turma_has_professor ALTER COLUMN turma_sigla INT NOT NULL 
ALTER TABLE turma_has_professor ADD CONSTRAINT fk_turma_has_professor_turma FOREIGN KEY(turma_sigla) REFERENCES turma(sigla)