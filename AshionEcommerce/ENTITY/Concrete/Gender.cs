using CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Concrete
{
    public class Gender : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Product { get; set; }
    }
}
