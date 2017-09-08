-----------------------------------------------------------------------------------------------------------------
-- Programador...: Marco Antonio Mendonça
-- Data..........: 07/09/2017
-- Nome..........: sp_se_regioes
-- Parametros....: @id_fornecedor  
-- Objetivo......: Retorna os dados : uf, região, situação que irão compor o grid da tela de regiões.
--				   referende ao id do fornecedor passado como parametro.
-----------------------------------------------------------------------------------------------------------------
use teste
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

if exists (select * from sysobjects where id = OBJECT_ID(N'[dbo].[sp_se_regioes_id]') and OBJECTPROPERTY(id, N'isProcedure') = 1)
	drop procedure [dbo].[sp_se_regioes_id]

go

create procedure sp_se_regioes_id 
	@id_fornecedor int  
as
declare @cSql varchar(1000)

set @cSql = ' select 
					uf.descricao uf,
					rg.descricao regiao, 
					rg.ativo  situacao 
			  from 
					estado uf
						join regiao rg
							on rg.idestado = uf.idestado 
						join FornecedorRegiao fr
							on rg.IdRegiao = fr.IdRegiao
						join Fornecedor fn
							on fn.IdFornecedor = fn.IdFornecedor

			 where 
					fn.IdFornecedor = ' + convert(varchar, @id_fornecedor)

set @cSql = @cSql +
	' order by ' +
	'	uf.descricao, '	+
	'	rg.descricao '	

execute(@cSql)

-- print @cSql

-- exec sp_se_regioes_id 0
-- exec sp_se_regioes_id 1
-- exec sp_se_regioes_id

-----------------------------------------------------------------------------------------------------------------

