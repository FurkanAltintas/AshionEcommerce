using CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Concrete
{
    public class ProductSize : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public int SizeId { get; set; }
        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; }
    }
}
