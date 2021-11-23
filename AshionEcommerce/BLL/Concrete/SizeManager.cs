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
    public class SizeManager : ISizeService
    {
        ISizeDal _sizeDal;

        public SizeManager(ISizeDal sizeDal)
        {
            _sizeDal = sizeDal;
        }

        public void Add(Size p)
        {
            _sizeDal.Add(p);
        }

        public void Delete(Size p)
        {
            _sizeDal.Delete(p);
        }

        public void Delete(int id)
        {
            _sizeDal.Delete(null, id);
        }

        public Size Get(Expression<Func<Size, bool>> filter = null)
        {
            return filter == null ?
                _sizeDal.Get() :
                _sizeDal.Get(filter);
        }

        public Size Get(int id)
        {
            return _sizeDal.Get(id);
        }

        public List<Size> List(Expression<Func<Size, bool>> filter = null)
        {
            return filter == null ?
                _sizeDal.List() :
                _sizeDal.List(filter);
        }

        public void Update(Size p)
        {
            _sizeDal.Update(p);
        }
    }
}
