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
                regiao.Ativo = rd["situacao"].ToString() == "0" ? "Ativo" : "Inativo";

                Estado estado = new Estado();
                estado.idEstado = long.Parse(rd["idestado"].ToString());
                estado.UF = rd["uf"].ToString();

                regiao.Estado = estado;
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
                    regiao.Ativo = rd["situacao"].ToString() == "0" ? "Ativo" : "Inativo";

                    Estado estado = new Estado();
                    estado.idEstado = long.Parse(rd["idestado"].ToString());
                    estado.UF = rd["uf"].ToString();

                    regiao.Estado = estado;

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
