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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color p)
        {
            _colorDal.Add(p);
        }

        public void Delete(Color p)
        {
            _colorDal.Delete(p);
        }

        public void Delete(int id)
        {
            _colorDal.Delete(null, id);
        }

        public Color Get(Expression<Func<Color, bool>> filter = null)
        {
            return filter == null ?
                _colorDal.Get() :
                _colorDal.Get(filter);
        }

        public Color Get(int id)
        {
            return _colorDal.Get(id);
        }

        public List<Color> List(Expression<Func<Color, bool>> filter = null)
        {
            return filter == null ?
                _colorDal.List() :
                _colorDal.List(filter);
        }

        public void Update(Color p)
        {
            _colorDal.Update(p);
        }
    }
}
