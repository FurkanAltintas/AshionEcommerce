using CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Concrete
{
    public class Discount : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Percent { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
