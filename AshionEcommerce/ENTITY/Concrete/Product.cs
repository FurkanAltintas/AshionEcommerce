using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        //Brand
        //Reviews
        //Available Color
        //Available Size
        //Promotions
        //Image
        //specification
    }
}
