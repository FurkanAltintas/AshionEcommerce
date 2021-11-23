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
    public class GenderManager : IGenderService
    {
        IGenderDal _genderDal;

        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }

        public void Add(Gender p)
        {
            _genderDal.Add(p);
        }

        public void Delete(Gender p)
        {
            _genderDal.Delete(p);
        }

        public void Delete(int id)
        {
            _genderDal.Delete(null, id);
        }

        public Gender Get(Expression<Func<Gender, bool>> filter = null)
        {
            return filter == null ?
                _genderDal.Get() :
                _genderDal.Get(filter);
        }

        public Gender Get(int id)
        {
            return _genderDal.Get(id);
        }

        public List<Gender> List(Expression<Func<Gender, bool>> filter = null)
        {
            return filter == null ?
                _genderDal.List() :
                _genderDal.List(filter);
        }

        public void Update(Gender p)
        {
            _genderDal.Update(p);
        }
    }
}
