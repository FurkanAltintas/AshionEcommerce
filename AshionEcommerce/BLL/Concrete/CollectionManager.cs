using BLL.Abstract;
using DAL.Abstract;
using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class CollectionManager : ICollectionService
    {
        ICollectionDal _collectionDal;

        public CollectionManager(ICollectionDal collectionDal)
        {
            _collectionDal = collectionDal;
        }

        public void Add(Collection p)
        {
            _collectionDal.Add(p);
        }

        public void Delete(Collection p)
        {
            _collectionDal.Delete(p);
        }

        public void Delete(int id)
        {
            _collectionDal.Delete(null, id);
        }

        public Collection Get(Expression<Func<Collection, bool>> filter = null)
        {
            return filter == null ?
                _collectionDal.Get() :
                _collectionDal.Get(filter);
        }

        public Collection Get(int id)
        {
            return _collectionDal.Get(id);
        }

        public List<Collection> List(Expression<Func<Collection, bool>> filter = null)
        {
            return filter == null ?
                _collectionDal.List() :
                _collectionDal.List(filter);
        }

        public void Update(Collection p)
        {
            _collectionDal.Update(p);
        }
    }
}
