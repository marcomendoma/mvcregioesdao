using System;
using System.Data.SqlClient;

using RegioesADO.Model;
using System.Collections.Generic;

namespace RegioesADO.ADO
{
    public class TransformaEstado
    {
        private SqlDataReader rd;
        private Estado estado = new Estado();
        private List<Estado> estados = new List<Estado>();

        public TransformaEstado(SqlDataReader sqlDataReader)
        {
            this.rd = sqlDataReader;
        }

        public Estado RetornaFornecedor()
        {
            try
            {
                RetornaEstado();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return estado;
        }

        private void RetornaEstado()
        {
            estado.idEstado = long.Parse(rd["idestado"].ToString());
            estado.UF = rd["descricao"].ToString();
        }

        public List<Estado> listaEstatos()
        {
            try
            {
                foreach (var item in rd)
                {
                    estado.idEstado = long.Parse(rd["idestado"].ToString());
                    estado.UF = rd["descricao"].ToString();

                    estados.Add(estado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

            return estados;
        }
    }
}
