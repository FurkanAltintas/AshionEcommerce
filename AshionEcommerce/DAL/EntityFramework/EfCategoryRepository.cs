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
    public class EfCategoryRepository : EfEntityRepositoryBase<Category,Context>, ICategoryDal
    {
    }
}
