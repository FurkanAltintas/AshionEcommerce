using CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CORE.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> List(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity, int id = 0);
    }
}
