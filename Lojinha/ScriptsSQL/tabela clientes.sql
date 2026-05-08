use dblojinha;


create table Clientes (
[codigo] [int] identity (1,1) not null,
	nome varchar(100),
	email varchar(100),
	telefone varchar(20),
constraint [pk_clientes] primary key clustered
(
   [codigo]
   ) on [primary]
)on [primary]
go

insert into clientes( nome, email, telefone)
values ('Joao vitor ', 'joao@gmail.com', '6999378-5896')
select * from clientes

insert into clientes( nome, email, telefone)
values ('cristiano ronaldo ', 'goat@gmail.com', '6999378-5896')

select * from clientes
