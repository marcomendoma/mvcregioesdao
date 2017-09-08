using System.Collections.Generic;

namespace RegioesADO.ADO
{
    public interface IGenericDAO<T>
    {
        T addNew(T objeto);
        List<T> findAll();
        T findOne(long id);
        void update(T objeto);
        void delete(long id);
    }
}
