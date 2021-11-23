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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category p)
        {
            _categoryDal.Add(p);
        }

        public void Delete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(null, id);
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                _categoryDal.Get() :
                _categoryDal.Get(filter);
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(id);
        }

        public List<Category> List(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                _categoryDal.List() :
                _categoryDal.List(filter);
        }

        public void Update(Category p)
        {
            _categoryDal.Update(p);
        }
    }
}
