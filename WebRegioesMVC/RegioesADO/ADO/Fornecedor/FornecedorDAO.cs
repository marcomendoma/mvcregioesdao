using System.Collections.Generic;
using System.Data.SqlClient;

using RegioesADO.Model;

namespace RegioesADO.ADO
{
    public class FornecedorDAO : IGenericDAO<Fornecedor>
    {
        private Fornecedor fornecedor;
        private List<Fornecedor> fornecedores;
        
        private SqlDataReader rd;

        public Fornecedor addNew(Fornecedor objeto)
        {
            string sInsert = new OpFornecedor(objeto).RetornaInsert();
            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sInsert);

            return objeto;
        }

        public void delete(long id)
        {
            string sDelete = new OpFornecedor(fornecedor).RetornaDelete();

            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sDelete);
        }

        public List<Fornecedor> findAll()
        {
            rd = new ExecCommand(new ConectaBanco().RetornaCon()).ExecProcedure("sp_se_regioes", 0);
            fornecedor = new TransformaFornecedor(rd).RetornaFornecedor();

            return fornecedores;
        }

        public Fornecedor findOne(long id)
        {
            rd = new ExecCommand(new ConectaBanco().RetornaCon()).ExecProcedure("sp_se_regioes", id);
            fornecedores = new TransformaFornecedor(rd).listaFornecedores();

            return fornecedor;
        }

        public void update(Fornecedor objeto)
        {
            string sUpdate = new OpFornecedor(objeto).RetornaUpdade();

            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sUpdate);
        }
    }
}
