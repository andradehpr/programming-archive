
CREATE TABLE aula2.cliente(
	id INT PRIMARY KEY IDENTITY (1, 1),
	nome VARCHAR(256) NOT NULL,
	email VARCHAR(100) NOT NULL,
	telefone VARCHAR(13),
	morada VARCHAR(100),
	criacao DATETIME NOT NULL,
	loja INT NOT NULL,
	FOREIGN KEY (loja) REFERENCES aula2.loja(id)
);


CREATE TABLE aula2.loja(
	id INT PRIMARY KEY IDENTITY(1, 1),
	nome_loja VARCHAR(100) NOT NULL,
	codigo_postal VARCHAR(8) NOT NULL,
	gerente INT NOT NULL,
	FOREIGN KEY (gerente) REFERENCES exercicio.gerente(id)
);


CREATE TABLE aula2.gerente(
	id INT PRIMARY KEY IDENTITY (1, 1),
	nome VARCHAR(256) NOT NULL,
	email VARCHAR(100) NOT NULL,
	telefone VARCHAR(13) NOT NULL,
	morada VARCHAR(100) NOT NULL,
	criacao DATETIME NOT NULL,
);