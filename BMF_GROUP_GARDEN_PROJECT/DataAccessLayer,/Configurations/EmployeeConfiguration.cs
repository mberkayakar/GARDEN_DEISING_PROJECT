using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_.Configurations
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(e => e.ID);
            Property(e => e.Name).HasMaxLength(100);
            Property(e => e.Name).IsRequired();
            ToTable("Employees");


        }
    }
}
