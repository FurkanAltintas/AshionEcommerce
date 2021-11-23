using CORE.DataAccess.EntityFramework;
using DAL.Abstract;
using DAL.Concrete;
using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfProductRepository : EfEntityRepositoryBase<Product, Context>, IProductDal
    {
        public List<Product> ListBrand()
        {
            using (var c = new Context())
            {
                var list = c.Products.Include(x => x.Brand).ToList();
                return list;
            }
        }

        public List<Product> ListGender()
        {
            using (var c = new Context())
            {
                return c.Products.Include("Gender").OrderByDescending(x => x.Id).Take(8).ToList();
            }
        }

        public Product GetBrand(int id)
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Brand).FirstOrDefault(x => x.Id == id);
            }
        }

        public Product RelatedProducts(int id)
        {
            using (var context = new Context())
            {
                return context.Products.Include(x => x.Brand)
                                       .Include(x => x.Gender)
                                       .Include(x => x.Kind).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
