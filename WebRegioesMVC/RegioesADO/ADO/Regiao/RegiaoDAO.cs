using System.Collections.Generic;
using RegioesADO.Model;
using System.Data.SqlClient;

namespace RegioesADO.ADO
{
    public class RegiaoDAO : IGenericDAO<Regiao>
    {
        private Regiao regiao;
        private List<Regiao> regioes;

        private SqlDataReader rd;

        public Regiao addNew(Regiao regiao)
        {
            string sInsert = new OpRegiao(regiao).RetornaInsert();
            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sInsert);

            return regiao;
        }

        public void delete(long id)
        {
            string sDelete = new OpRegiao(regiao).RetornaDelete();

            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sDelete);
        }

        public List<Regiao> findAll()
        {
            rd = new ExecCommand(new ConectaBanco().RetornaCon()).ExecProcedure("[dbo].[sp_se_regioes]", 0);
            regioes = new TransformaRegiao(rd).listaRegioes();

            return regioes;
        }

        public Regiao findOne(long id)
        {
            rd = new ExecCommand(new ConectaBanco().RetornaCon()).ExecProcedure("[dbo].[sp_se_regioes]", id);
            regiao = new TransformaRegiao(rd).RetornaRegiao();

            return regiao;
        }

        public void update(Regiao regiao)
        {
            string sUpdate = new OpRegiao(regiao).RetornaUpdade();

            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sUpdate);
        }
    }
}
