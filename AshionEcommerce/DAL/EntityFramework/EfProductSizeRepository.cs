using CORE.DataAccess.EntityFramework;
using DAL.Abstract;
using DAL.Concrete;
using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfProductSizeRepository : EfEntityRepositoryBase<ProductSize,Context>, IProductSizeDal
    {
        public List<ProductSize> Size(int id)
        {
            using (var c = new Context())
            {
                return c.ProductSizes.Include("Size").Where(x => x.ProductId == id).ToList();
            }
        }
    }
}
