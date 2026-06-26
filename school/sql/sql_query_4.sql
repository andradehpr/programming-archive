USE vendas

--1


SELECT cliente.nome, cidade.nome AS 'Cidade'
FROM cliente
INNER JOIN cidade ON cliente.id_cidade=cidade.id
ORDER BY cidade.nome, cliente.nome


--2

SELECT cliente.nome, cidade.nome AS 'Cidade'
FROM cliente
INNER JOIN cidade ON cliente.id_cidade=cidade.id
WHERE cliente.genero = 'F'
ORDER BY cidade.nome, cliente.nome


--3

SELECT cidade.nome AS 'Cidade', cliente.nome AS 'Nome cliente', cliente.CC
FROM cliente
INNER JOIN cidade ON cliente.id_cidade=cidade.id
WHERE cidade.nome like 'Lisboa'
ORDER BY cliente.nome


--4

SELECT cliente.nome AS 'Nome cliente', cidade.nome AS 'Cidade', cliente.CC
FROM cliente
INNER JOIN cidade ON cliente.id_cidade=cidade.id
WHERE cidade.nome LIKE 'Lisboa'
AND cliente.genero = 'm'
OR cidade.nome LIKE 'Porto'
AND cliente.genero = 'm'


--5

SELECT cliente.nome AS 'Nome cliente', cidade.nome AS 'Cidade', cliente.CC
FROM cliente
INNER JOIN cidade ON cliente.id_cidade=cidade.id
WHERE cidade.nome IN ('Lisboa','Porto')
AND cliente.genero = 'm'


--6

SELECT cliente.nome AS 'Nome cliente', cidade.nome AS 'Cidade'
FROM cliente
INNER JOIN cidade ON cliente.id_cidade=cidade.id
WHERE cliente.nome LIKE '%r%'
ORDER BY cliente.nome DESC


--7

SELECT vendas.id, vendas.data ,produto.descricao, vendas.qtd
FROM vendas
INNER JOIN produto ON vendas.id_produto=produto.id 
ORDER BY vendas.id

--8

SELECT vendas.id, vendas.data ,produto.descricao, vendas.qtd,produto.preco ,sum(produto.preco*qtd)
FROM vendas
INNER JOIN produto ON vendas.id_produto=produto.id 
GROUP BY vendas.id, vendas.data ,produto.descricao, vendas.qtd, produto.preco
ORDER BY vendas.id


--9 

SELECT vendas.id, vendas.data ,produto.descricao, vendas.qtd,produto.preco ,sum(produto.preco*qtd), cliente.nome
FROM vendas
INNER JOIN produto ON vendas.id_produto=produto.id
INNER JOIN cliente ON vendas.id_cliente = cliente.id
GROUP BY vendas.id, vendas.data ,produto.descricao, vendas.qtd, produto.preco, cliente.nome
ORDER BY vendas.id


--10

SELECT vendas.id, vendas.data ,produto.descricao, vendas.qtd,produto.preco ,sum(produto.preco*qtd), cliente.nome, cidade.nome
FROM vendas
INNER JOIN produto ON vendas.id_produto=produto.id
INNER JOIN cliente ON vendas.id_cliente = cliente.id
INNER JOIN cidade ON cliente.id_cidade = cidade.id
GROUP BY vendas.id, vendas.data ,produto.descricao, vendas.qtd, produto.preco, cliente.nome, cidade.nome
ORDER BY SUM(produto.preco*qtd)


--11
SELECT TOP 3
id, cliente.nome, cliente.pontos_acum
FROM cliente
ORDER BY cliente.pontos_acum DESC


--12

SELECT TOP 1
id, cliente.nome, cliente.pontos_acum
FROM cliente
ORDER BY cliente.pontos_acum 



--13


SELECT DISTINCT cidade.nome
FROM cliente
INNER JOIN cidade ON cliente.id_cidade = cidade.id
GROUP BY cidade.nome 
