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
    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public int KindId { get; set; }
        [ForeignKey("KindId")]
        public virtual Kind Kind { get; set; }

        public int? GenderId { get; set; }
        [ForeignKey("GenderId")]
        public virtual Gender Gender { get; set; }

        public int? StockId { get; set; }
        [ForeignKey("StockId")]
        public virtual Stock Stock { get; set; }

        public int? ColorId { get; set; }
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public string Url { get; set; }
        public double Price { get; set; }
        public double CampaignDiscount { get; set; }
        public DateTime CreateDate { get; set; }

        public List<Comment> Comment { get; set; }

        //Brand
        //Reviews
        //Available Color
        //Available Size
        //Promotions
        //Image
        //specification
    }
}
