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
    public class ProductSizeManager : IProductSizeService
    {
        IProductSizeDal _productSizeDal;

        public ProductSizeManager(IProductSizeDal productSizeDal)
        {
            _productSizeDal = productSizeDal;
        }

        public void Add(ProductSize p)
        {
            _productSizeDal.Add(p);
        }

        public void Delete(ProductSize p)
        {
            _productSizeDal.Delete(p);
        }

        public void Delete(int id)
        {
            _productSizeDal.Delete(null, id);
        }

        public ProductSize Get(Expression<Func<ProductSize, bool>> filter = null)
        {
            return filter == null ?
                _productSizeDal.Get() :
                _productSizeDal.Get(filter);
        }

        public ProductSize Get(int id)
        {
            return _productSizeDal.Get(id);
        }

        public List<ProductSize> List(Expression<Func<ProductSize, bool>> filter = null)
        {
            return filter == null ?
                _productSizeDal.List() :
                _productSizeDal.List(filter);
        }

        public List<ProductSize> Size(int id)
        {
            return _productSizeDal.Size(id);
        }

        public void Update(ProductSize p)
        {
            _productSizeDal.Update(p);
        }
    }
}
