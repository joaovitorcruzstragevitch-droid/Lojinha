create procedure [dbo].[altera_cliente]
	@codigo int output,
	@nome varchar(100),
	@email varchar(100),
	@telefone varchar(20)
	as 
	 update clientes set nome = @nome,  email = @email, telefone =  @telefone
	 where codigo = @codigo


	