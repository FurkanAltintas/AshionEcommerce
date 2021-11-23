using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            ToTable(@"Brands", @"dbo");
            HasKey(x => x.Id);
            HasRequired(x => x.Name);
        }
    }
}
