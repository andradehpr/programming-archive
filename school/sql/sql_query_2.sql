
--1

SELECT * FROM cidade

--2

SELECT *
FROM cidade
ORDER BY nome DESC

--3

SELECT *
FROM cidade 
ORDER BY nome

--4

SELECT id, nome, genero, cc
FROM cliente
ORDER BY nome

--5 

SELECT id, nome, genero, cc
FROM cliente
ORDER BY genero, nome DESC

--6 

SELECT id as 'ID', nome as 'Nome Cliente', genero as 'Género Cliente', cc 'Cartão de Cidadão'
FROM cliente
ORDER BY genero, nome DESC

--7 

SELECT id as 'ID', nome as 'Nome Cliente', genero as 'Género Cliente', cc 'Cartão de Cidadão'
FROM cliente
WHERE id = 3

--8

SELECT id as 'ID', nome as 'Nome Cliente', genero as 'Género Cliente', cc 'Cartão de Cidadão'
FROM cliente
WHERE id != 3
ORDER BY nome

--9

SELECT id as 'ID', nome as 'Nome Cliente', genero as 'Género Cliente', cc 'Cartão de Cidadão'
FROM cliente
WHERE id IN ('3','5')
ORDER BY id

--10

SELECT id as 'ID', nome as 'Nome Cliente', genero as 'Género Cliente', cc 'Cartão de Cidadão'
FROM cliente
WHERE id = 3
OR id = 5
ORDER BY id

--11

SELECT id as 'ID', nome as 'Nome Cliente'
FROM cliente
WHERE genero = 'f'
AND id_cidade = 3
ORDER BY nome

--12

SELECT *
FROM cliente
WHERE id BETWEEN 3 AND 6 
ORDER BY nome 

--13

SELECT *
FROM cliente
WHERE id >= 3 AND id <= 6 
ORDER BY nome 


--14

SELECT *
FROM cliente
WHERE nome like 'J%'
ORDER BY nome 


--15 

SELECT *
FROM cliente
WHERE nome like '%o'
ORDER BY nome

--16

SELECT *
FROM cliente
WHERE nome like '%i%'
ORDER BY nome

--17

SELECT *
FROM cliente
WHERE nome like '____'
ORDER BY nome

--18

SELECT *
FROM cliente
WHERE nome like 'Jo__'
ORDER BY nome

--19

SELECT *
FROM cliente
WHERE nome like 'J%' 
OR nome like 'H%'
OR nome like 'M%'
ORDER BY nome

--20

SELECT *
FROM cliente
WHERE nome like '[DJMH]__%a' 
OR nome like '[DJMH]__%o'
ORDER BY nome

--21 

SELECT DISTINCT vendas.data 
FROM vendas 









