using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> List(Expression<Func<T, bool>> filter = null);

        void Add(T p);
        void Update(T p);
        void Delete(T p);
        void Delete(int id);

        T Get(Expression<Func<T, bool>> filter = null);
        T Get(int id);
    }
}
