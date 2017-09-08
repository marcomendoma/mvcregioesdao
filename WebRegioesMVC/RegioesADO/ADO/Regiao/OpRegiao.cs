using System.Text;

using RegioesADO.Model;

namespace RegioesADO.ADO
{
    public class OpRegiao
    {
        private StringBuilder strBuilder = new StringBuilder();
        private Regiao regiao;

        public OpRegiao(Regiao regiao)
        {
            this.regiao = regiao;
        }

        public string RetornaInsert()
        {
            strBuilder.Append("Insert into regiao (idestado, descricao, ativo) values (");
            strBuilder.Append(regiao.Estado.idEstado + ",'");
            strBuilder.Append(regiao.Descricao + "',");
            strBuilder.Append(regiao.Ativo + ")");

            return strBuilder.ToString();
        }

        public string RetornaDelete()
        {
            strBuilder.Append("delete from reegiao where idregiao=");
            strBuilder.Append(regiao.idRegiao);

            return strBuilder.ToString();
        }

        public string RetornaUpdade()
        {
            strBuilder.Append("update regiao set idestado=");
            strBuilder.Append(regiao.Estado.idEstado);
            strBuilder.Append(", descricao='");
            strBuilder.Append(regiao.Descricao + "',");
            strBuilder.Append(" ativo=");
            strBuilder.Append(regiao.Ativo + ")");
            strBuilder.Append(" where idestado=");
            strBuilder.Append(regiao.idRegiao);

            return strBuilder.ToString();
        }
    }
}
