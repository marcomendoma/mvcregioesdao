using System.Text;

using RegioesADO.Model;

namespace RegioesADO.ADO
{
    public class OpFornecedor
    {
        private StringBuilder strBuilder = new StringBuilder();
        private Fornecedor fornecedor;

        public OpFornecedor(Fornecedor fornec)
        {
            this.fornecedor = fornec;
        }

        public string RetornaInsert()
        {
            strBuilder.Append("Insert into fornecedor (cnpj, nome) values ('");
            strBuilder.Append(fornecedor.Cnpj + "',");
            strBuilder.Append(fornecedor.Nome + "')");

            return strBuilder.ToString();
        }

        public string RetornaDelete()
        {
            strBuilder.Append("delete from fornecedor where idfornecedor=");
            strBuilder.Append(fornecedor.idFornecedor);

            return strBuilder.ToString();
        }

        public string RetornaUpdade()
        {
            strBuilder.Append("update fornecedor set cnpj='");
            strBuilder.Append(fornecedor.Cnpj);
            strBuilder.Append("', nome='");
            strBuilder.Append(fornecedor.Nome + "'");
            strBuilder.Append(" where idfornecedor=");
            strBuilder.Append(fornecedor.idFornecedor);

            return strBuilder.ToString();
        }
    }
}
