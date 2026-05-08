use dblojinha;

create table vendas (
[codigo] [int] identity (1,1) not null,
data datetime,
quantidade int,
faturado bit,
codigocliente int,
codigoproduto int,
constraint [pk_vendas] primary key clustered
(
   [codigo]
   ) on [primary], constraint [fk_codigo_cliente] foreign key
   (
   [codigocliente]
   ) references [clientes] ( [codigo]
),
constraint [fk_codigo_produto] foreign key
(
	[codigoproduto]
) references [produtos]  (
	[codigo]

	) 
	)on [primary]
	go

