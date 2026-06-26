USE ATM

CREATE TABLE conta (

Numero VARCHAR(16) PRIMARY KEY,
Saldo DECIMAL(16,2) NOT NULL,
);

CREATE TABLE atm(
Id INT PRIMARY KEY,
Local VARCHAR(20),
);

CREATE TABLE levantamento(
Id INT PRIMARY KEY,
Data DATETIME,
Montante DECIMAL(6,2),
atm_id INT,
conta_numero VARCHAR(16),
FOREIGN KEY(atm_id) REFERENCES atm(id),
FOREIGN KEY(conta_numero) REFERENCES conta(numero),
);

USE ATM;
INSERT INTO conta(numero, saldo) VALUES ('CONTA1','500');
INSERT INTO conta(numero, saldo) VALUES ('CONTA2','500');
INSERT INTO ATM(id, local) VALUES(1, 'EntreCampos');
INSERT INTO ATM(id, local) VALUES(2, 'Campo Grande');


INSERT INTO levantamento(data, montante, atm_id, conta_numero)
	VALUES (GETDATE(),'100', 1, 'CONTA2');
INSERT INTO levantamento(data, montante, atm_id, conta_numero)
	VALUES (GETDATE(),'-100', 1, 'CONTA1');
UPDATE conta SET saldo=saldo-100 WHERE numero='CONTA1';
UPDATE conta SET saldo=saldo+100 WHERE numero='CONTA2';
COMMIT TRANSACTION 



