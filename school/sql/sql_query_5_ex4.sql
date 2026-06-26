USE vendas

--1

SELECT COUNT (vendas.qtd) 'Total de Vendas'
FROM vendas


--2

SELECT MAX (produto.preco) 'Preço MAX dos produtos'
FROM produto

--3 

SELECT MIN (cliente.pontos_acum) 'Numero MIN de pontos acumulados'
FROM cliente


--4

SELECT AVG(p.preco*v.qtd) 'Media'
FROM produto AS p
INNER JOIN vendas AS v ON v.id_produto = p.id  



--5 

SELECT SUM (p.preco*v.qtd) AS 'Soma do Valor das Vendas'
FROM produto AS p
INNER JOIN vendas AS v ON v.id_produto = p.id 


--6

SELECT genero 'Género' , SUM (pontos_acum) 'Pontos Acumulados por Género' 
FROM cliente
GROUP BY genero


--7

SELECT cidade.nome 'Cidade' , SUM (cliente.pontos_acum) 'Pontos Acumulados por Género' 
FROM cliente 
INNER JOIN cidade ON cliente.id_cidade=cidade.id
GROUP BY cidade.nome


--8 

SELECT cidade.nome 'Cidade' , SUM (cliente.pontos_acum) 'Pontos Acumulados por Género' , cliente.genero 'Género'
FROM cliente 
INNER JOIN cidade ON cliente.id_cidade=cidade.id
GROUP BY cidade.nome , genero


--9 

SELECT (produto.descricao) 'Nome', SUM (vendas.qtd) 'Valor de Vendas'
FROM vendas
INNER JOIN produto ON vendas.id_produto=produto.id
GROUP BY produto.descricao


--10

SELECT cidade.nome as 'Cidade' , AVG(V.qtd*P.preco) as 'Média do Valor de Vendas' 
FROM PRODUTO as p 
INNER JOIN vendas AS v ON v.id_produto=p.id
INNER JOIN cliente AS cl ON v.id_cliente=cl.id 
INNER JOIN cidade ON cidade.id=cl.id_cidade
GROUP BY cidade.nome



--11

SELECT cl.genero, cidade.nome, MAX(p.preco*v.qtd) AS 'MAX Valor' , MIN(p.preco*v.qtd) AS 'MIN Valor'
FROM produto as p 
INNER JOIN vendas AS v ON v.id_produto=p.id
INNER JOIN cliente AS cl ON v.id_cliente= cl.id
INNER JOIN cidade on cidade.id=cl.id_cidade
GROUP BY cidade.nome, cl.genero 



--12

SELECT ci.nome AS 'Cidade', SUM(v.qtd*p.preco) AS 'SUM Valor de Vendas >2€' 
FROM produto AS p 
INNER JOIN vendas AS v ON v.id_produto=p.id 
INNER JOIN cliente AS cl ON v.id_cliente=cl.id
INNER JOIN cidade AS ci ON ci.id = cl.id_cidade
GROUP BY ci.nome
HAVING SUM(v.qtd*p.preco) >= 2




--13
SELECT ci.nome AS 'Cidade' , AVG(cl.pontos_acum) AS 'Pontos Acumulados' 
FROM cliente AS cl
INNER JOIN cidade AS ci ON ci.id=cl.id_cidade
WHERE ci.nome!= 'Lisboa'
GROUP BY ci.nome



--14
SELECT ci.nome AS 'Cidade' , COUNT(*) as 'Número de Clientes por Cidade' 
FROM cliente AS cl
INNER JOIN cidade AS ci ON ci.id = cl.id_cidade
GROUP BY ci.nome
HAVING COUNT(*) > 2
ORDER BY ci.nome






-- TEST 

SELECT UPPER (nome) 'MAIUSCULAS' , LOWER (nome) 'MINUSCULAS'
FROM cliente

SELECT LEN (nome)
FROM cliente 
WHERE nome like 'A'


SELECT CONCAT (nome,cc) 'Identifica'
FROM cliente


SELECT nome +' '+cc
FROM cliente








