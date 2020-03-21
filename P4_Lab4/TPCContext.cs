using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Lab4
{
    public class TPCContext:DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PC>().Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("Pecety");
            });

            modelBuilder.Entity<Laptop>().Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("Laptopy");
            });

        }

    }
}
