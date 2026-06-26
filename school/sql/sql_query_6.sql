use vendas

--ex1
select concat(nome,cc) as 'Nome | ID de identificação' from cliente
order by nome

--ex2
select concat(nome,LEFT(cc,4)) as 'Nome | 4 Primeiros dígitos do ID de identificação' from cliente
where cliente.genero ='F'
order by nome

--ex3
select concat(nome,RIGHT(cc,4)) as 'Nome | 4 Ultimos dígitos do ID de identificação' from cliente
order by nome DESC

--ex4
select 'Nome: ' + (LEFT(nome,3)) + REPLICATE('*',10) + ' CC: ' + REPLICATE('*',5) +(RIGHT(CC,3)) as 'Resultado' from cliente

--ex5
select upper(nome) as 'Nome em Maiúsculas', lower(nome) as 'Nome em Minúsculas' from cliente
order by genero,nome 


--ex6
select cliente.nome as 'Nome', LEN(nome) as 'Nº Caracteres' from cliente
where cliente.nome like '%s' 
group by cliente.nome
order by LEN(nome) DESC

--ex7
select nome, + ' ' + REPLACE(genero,'F','Feminino') as 'Resultado' from cliente
where genero = 'F' 
group by nome,genero

--ex8
select descricao as 'Nome', REPLACE(descricao,'y','i') as 'Nomes y <-> i' from produto
order by descricao

--ex9
select  REPLICATE('*',10) + nome + REPLICATE('*',10) as ' **********Nome**********' from cliente
group by nome

--ex10
select descricao as 'Descrição' , DATEDIFF(year, '2019/12/31', '2019/01/01') as 'Número de dias até serem vendidos'  from produto
inner join vendas on produto.id = produto.id
--unfinished

