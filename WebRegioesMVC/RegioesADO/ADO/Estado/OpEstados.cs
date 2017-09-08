using System.Text;

using RegioesADO.Model;

namespace RegioesADO.ADO
{
    public class OpEstados
    {
        private StringBuilder strBuilder = new StringBuilder();
        private Estado estado;

        public OpEstados(Estado estado)
        {
            this.estado = estado;
        }

        public string RetornaInsert()
        {
            strBuilder.Append("Insert into estado (descricao values ('");
            strBuilder.Append(estado.UF+ "')");

            return strBuilder.ToString();
        }

        public string RetornaDelete()
        {
            strBuilder.Append("delete from estado where idestado=");
            strBuilder.Append(estado.idEstado);

            return strBuilder.ToString();
        }

        public string RetornaUpdade()
        {
            strBuilder.Append("update estado set descricao='");
            strBuilder.Append(estado.UF);
            strBuilder.Append(" where idestado=");
            strBuilder.Append(estado.idEstado);

            return strBuilder.ToString();
        }
    }
}
