using CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.DataAccess
{
    public interface IQueryable<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
