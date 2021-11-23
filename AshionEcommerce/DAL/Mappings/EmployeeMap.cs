using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable(@"Employees", @"dbo");
            HasKey(x => x.Id);
            HasRequired(x => x.Name);
            HasRequired(x => x.SurName);
            HasRequired(x => x.Email);
            HasRequired(x => x.Password);
        }
    }
}
