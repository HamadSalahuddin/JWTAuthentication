using AutoManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Data.Configurations
{
    class CustomerConfigration: EntityTypeConfiguration<Customer>
    {
        public CustomerConfigration()
        {
            ToTable("Customer");
            Property(customer => customer.FirstName)
                .HasMaxLength(80)
                .IsRequired();

            Property(customer => customer.LastName)
                .HasMaxLength(80)
                .IsRequired();

            Property(customer => customer.EmailAddress)
                .HasMaxLength(100);

            Property(customer => customer.PhoneContact)
                .HasMaxLength(20);
        }
    }
}
