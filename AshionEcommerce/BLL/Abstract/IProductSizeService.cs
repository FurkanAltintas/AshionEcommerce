using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IProductSizeService : IGenericService<ProductSize>
    {
        List<ProductSize> Size(int id);
    }
}
