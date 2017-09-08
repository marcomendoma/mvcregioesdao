using System;
using System.Data.SqlClient;

using RegioesADO.Model;
using System.Collections.Generic;

namespace RegioesADO.ADO
{
    public class TransformaRegiao
    {
        private SqlDataReader rd;
        private Regiao regiao = new Regiao();
        private List<Regiao> regioes = new List<Regiao>();

        public TransformaRegiao(SqlDataReader sqlDataReader)
        {
            this.rd = sqlDataReader;
        }

        public Regiao RetornaRegiao()
        {
            try
            {
                regiao.idRegiao = long.Parse(rd["idregiao"].ToString());
                regiao.Descricao = rd["regiao"].ToString();
                regiao.Ativo = bool.Parse(rd["situacao"].ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return regiao;
        }

        public List<Regiao> listaRegioes()
        {
            try
            {
                foreach (var item in rd)
                {
                    regiao.idRegiao = long.Parse(rd["idregiao"].ToString());
                    regiao.Descricao = rd["regiao"].ToString();
                    regiao.Ativo = bool.Parse(rd["situacao"].ToString());

                    regioes.Add(regiao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return regioes;
        }
    }
}
