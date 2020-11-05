using AutoManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Data.Configurations
{
    public class BrandingConfiguration: EntityTypeConfiguration<Branding>
    {
        public BrandingConfiguration()
        {
            ToTable("Branding");
            Property(branding => branding.Name)
                .IsRequired()
                .HasMaxLength(80);

            Property(branding => branding.Email)
                .HasMaxLength(80);

            Property(branding => branding.Contact)
                .IsRequired()
                .HasMaxLength(30);

            Property(branding => branding.WebUrl)
                .HasMaxLength(80);
        }
    }
}
