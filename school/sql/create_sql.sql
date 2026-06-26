CREATE TABLE [nome da base de dados].[nome tabela] (
	pk PRIMARY KEY IDENTITY(1, 1),
	coluna2 VARCHAR(100) NOT NULL,
	...
	table_constraints
  );




CREATE TABLE school.alunos (
	numero INT PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(256) NOT NULL,
	data_nascimento DATETIME NOT NULL,
	id_curso INT NOT NULL,
	trienio INT VARCHAR(9) NOT NULL,
	email VARCHAR(100) NULL,
	
	FOREIGN KEY (id_curso)    REFERENCES ecoladigital.cursos(id)
);
CREATE TABLE cartao.cidadao (
	numero INT PRIMARY KEY IDENTITY
	



)











/*char = indicar minimo de caracteres e indicar o maximo de caracters
varchar = indicar o numero maximo de caracteres
text = numero de caracteres de 256*/


	




























