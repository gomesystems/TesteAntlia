# Basic Project DDD + MVC
Objetivo
O objetivo deste exame é avaliar o conhecimento e as melhores práticas no desenvolvimento web da plataforma .NET utilizando banco de dados SQL Server.

## Rationale
Requisitos
Elaborar uma aplicação em camadas para Inserção e Consulta dos Movimentos Manuais digitados para um determinado mês e ano.
 Essa aplicação deverá ser desenvolvida com base no Modelo Entidade Relacionamento na página 3 e de acordo com os itens discriminados:
1.	Criar todas as tabelas conforme MER e dicionário de dados (Páginas 4 e 5).

2.	Criar uma stored procedure que retorne como saída às colunas Mês, Ano, Código do Produto, 
Descrição do Produto, Numero do Lançamento, Descrição, e Valor, ordenando os mesmos por Mês, Ano e Número do Lançamento utilizando as tabelas PRODUTO e MOVIMENTO_MANUAL. Essa stored procedure deverá ser utilizada no item 3.2. 

3.	Criar uma tela para manutenção na tabela MOVIMENTO_MANUAL.

## Features

* DDD  
* ASP.NET MVC 5
* Entity Framework
* AutoMapper
* IoC com Ninject
* Dapper
* Stored Prodedures
* Tabelas
* DataAnnotations 
* FluentAPI para models
* Migrations

> Faltou fazer: crialção de views e controler para as procedures, inserir os produtos para carregar os combos e exibir no grid para fazer as movimentações.

Carlos Gomes - Software Developer