use dblojinha;
go

create procedure [dbo].[exclui_cliente]
	@codigo int
	as

	delete from clientes where codigo = @codigo

	exec [exclui_cliente] 1

	select * from clientes