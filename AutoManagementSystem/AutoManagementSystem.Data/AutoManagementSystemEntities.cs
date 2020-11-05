using AutoManagementSystem.Data.Configurations;
using AutoManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Data
{
    public class AutoManagementSystemEntities : DbContext
    {
        public AutoManagementSystemEntities() : base("name=AutoManagementEntities")
        {
            Configuration.ProxyCreationEnabled = false;
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Branding> Brandings { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrandingConfiguration());
        }
    }
}
