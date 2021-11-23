using CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Concrete
{
    public class Stock : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int Total { get; set; }

        public List<Product> Product { get; set; }
    }
}
