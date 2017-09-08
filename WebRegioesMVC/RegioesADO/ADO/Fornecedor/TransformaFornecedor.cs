using System;
using System.Data.SqlClient;

using RegioesADO.Model;
using System.Collections.Generic;

namespace RegioesADO.ADO
{
    public class TransformaFornecedor
    {
        private SqlDataReader rd;
        private Fornecedor fornecedor = new Fornecedor();
        private List<Fornecedor> fornecedores = new List<Fornecedor>();

        public TransformaFornecedor(SqlDataReader sqlDataReader)
        {
            this.rd = sqlDataReader;
        }

        public Fornecedor RetornaFornecedor()
        {
            try
            {
                fornecedor.idFornecedor = long.Parse(rd["idFornecedor"].ToString());
                fornecedor.Nome = rd["nome"].ToString();
                fornecedor.Cnpj = rd["cnpj"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return fornecedor;
        }

        public List<Fornecedor> listaFornecedores()
        {
            try
            {
                fornecedor = new Fornecedor();

                foreach (var item in rd)
                {
                    fornecedor.idFornecedor = long.Parse(rd["idFornecedor"].ToString());
                    fornecedor.Nome = rd["nome"].ToString();
                    fornecedor.Cnpj = rd["cnpj"].ToString();

                    fornecedores.Add(fornecedor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return fornecedores;
        }
    }
}
