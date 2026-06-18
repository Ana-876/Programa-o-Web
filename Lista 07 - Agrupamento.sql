-- colocar em uso a tabela Empresa

use Empresa

/* 1. Exiba o cargo e a quantidade de funcionários por cargo em ordem crescente de quantidade.*/

select cargo, count(nome) as qtde_cargo from Funcionarios group by cargo order by qtde_cargo

/* 2. Exiba o cargo e a quantidade de funcionários por país.*/

select cargo, count(nome) as qtde_país from Funcionarios group by pais order by qtde_país

/* 3. Apresente o cargo e a média dos salários (denominando de "Media_
Salarios _Cargo") dos funcionários por cargo.*/

/* 4. Exiba o cargo e a soma dos salários dos funcionários por cargo maiores
que 3000,00.*/

/* 5. Apresente o país e a quantidade de clientes por país.*/

/* 6. Exiba a cidade e quantidade de clientes do Brasil*/

/* 7. Mostre o cargo, a soma e a média dos salários dos funcionários por cargo, cuja soma seja menor que 5000.

/* 8. Exiba a cidade, o cargo, a soma e a média dos salários dos funcionários por cidade e cargo.*/

/* 9. Liste os códigos dos clientes que possuem pedidos com um valor total (soma de Frete) superior a 500. Utilize GROUP BY e HAVING para agrupar por cliente e filtrar aqueles que atendem ao critério.*/

/* 10. Liste os códigos das categorias que possuem menos de 5 produtos associados. Utilize GROUP BY para agrupar por categoria e HAVING para aplicar o filtro de quantidade mínima.*/

/* 11. Liste os códigos dos fornecedores que possuem uma média de preço dos produtos menor que 50. Use GROUP BY para agrupar por fornecedor e HAVING para aplicar o filtro na média de preços.*/

/* 12. Liste os códigos dos produtos que foram vendidos em uma quantidade total superior a 1000 unidades. Use GROUP BY para agrupar por produto e HAVING para aplicar o filtro na quantidade total. */