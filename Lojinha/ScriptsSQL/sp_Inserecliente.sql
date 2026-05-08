use dblojinha;
go

--if exists(select name from sysobjects
--	where name = 'insere_clientes' and type = 'p')
--drop procedure insert_cliente;


create procedure [dbo].[insere_clientes]
	@codigo int output,
	@nome varchar(100),
	@email varchar(100),
	@telefone varchar(20)
	as 
	 insert into clientes(nome, email, telefone)
	 values(@nome, @email, @telefone)
	 set @codigo = (select @@identity)
