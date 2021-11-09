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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand p)
        {
            _brandDal.Add(p);
        }

        public void Delete(Brand p)
        {
            _brandDal.Delete(p);
        }

        public void Delete(int id)
        {
            _brandDal.Delete(id);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            return filter == null ?
                _brandDal.Get() :
                _brandDal.Get(filter);
        }

        public Brand Get(int id)
        {
            return _brandDal.Get(id);
        }

        public List<Brand> List(Expression<Func<Brand, bool>> filter = null)
        {
            return filter == null ?
                _brandDal.List() :
                _brandDal.List(filter);
        }

        public void Update(Brand p)
        {
            _brandDal.Update(p);
        }
    }
}
