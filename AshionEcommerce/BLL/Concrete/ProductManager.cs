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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product p)
        {
            _productDal.Add(p);
        }

        public void Delete(Product p)
        {
            _productDal.Delete(p);
        }

        public void Delete(int id)
        {
            _productDal.Delete(id);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ?
                _productDal.Get() :
                _productDal.Get(filter);
        }

        public Product Get(int id)
        {
            return _productDal.Get(id);
        }

        public List<Product> List(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ?
                _productDal.List() :
                _productDal.List(filter);
        }

        public void Update(Product p)
        {
            _productDal.Update(p);
        }
    }
}
