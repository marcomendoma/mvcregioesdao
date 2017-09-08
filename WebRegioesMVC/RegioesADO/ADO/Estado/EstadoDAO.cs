using System.Collections.Generic;
using RegioesADO.Model;

namespace RegioesADO.ADO
{
    public class EstadoDAO : IGenericDAO<Estado>
    {
        private Estado estado;
        private List<Estado> estados;

        public EstadoDAO(Estado estado)
        {
            this.estado = estado;
        }

        public Estado addNew(Estado estado)
        {
            string sInsert = new OpEstados(estado).RetornaInsert();
            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sInsert);

            return estado;
        }

        public void delete(long id)
        {
            string sDelete = new OpEstados(estado).RetornaDelete();

            new ExecCommand(new ConectaBanco().RetornaCon()).ExecutaCommando(sDelete);
        }

        public List<Estado> findAll()
        {
            throw new System.NotImplementedException();
        }

        public Estado findOne(long id)
        {
            throw new System.NotImplementedException();
        }

        public void update(Estado objeto)
        {
            throw new System.NotImplementedException();
        }
    }
}
