-----------------------------------------------------------------------------------------------------------------
-- Programador...: Marco Antonio Mendonça
-- Data..........: 07/09/2017
-- Nome..........: sp_se_regioes
-- Parametros....: @id_fornecedor  
-- Objetivo......: Retorna os dados : uf, região, situação que irão compor o grid da tela de regiões.
--				   Se for passado 0 como parametro irá trazer todos os campos da queria e atende a primeira
--				   tela que é a Cadastro de Regioes.
--				   caso passa um valor maior que zero representando o id do fornecedor ela irá referenciar
--				   a segunda tela que é a de Cadastro de regioes por fornecedor 	
-----------------------------------------------------------------------------------------------------------------
use teste
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

if exists (select * from sysobjects where id = OBJECT_ID(N'[dbo].[sp_se_regioes]') and OBJECTPROPERTY(id, N'isProcedure') = 1)
	drop procedure [dbo].[sp_se_regioes]

go

create procedure sp_se_regioes 
	@id_fornecedor int  
as
declare @cSql varchar(1000)

set @cSql = ' select 
					rg.idregiao,
					rg.idestado,
					uf.descricao uf,
					rg.descricao regiao '
					
if (@id_fornecedor = 0) 
	set @cSql = @cSql + ', rg.ativo  situacao '

set @cSql = @cSql + ' from 
							estado uf
								join regiao rg
									on rg.idestado = uf.idestado 
								join FornecedorRegiao fr
									on rg.IdRegiao = fr.IdRegiao
								join Fornecedor fn
									on fn.IdFornecedor = fn.IdFornecedor'	

if (@id_fornecedor > 0)
	set @cSql = @cSql + ' where ' +
		' fn.IdFornecedor = ' + convert(varchar, @id_fornecedor)

set @cSql = @cSql +
	' order by ' +
	'	uf.descricao, '	+
	'	rg.descricao '	

--print @cSql

execute(@cSql)

-- exec sp_se_regioes 0
-- exec sp_se_regioes 1
-- exec sp_se_regioes 2

-----------------------------------------------------------------------------------------------------------------

