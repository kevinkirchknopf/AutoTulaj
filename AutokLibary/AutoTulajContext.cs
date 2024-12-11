using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AutokLibary
{
    public class AutoTulajContext : DbContext
    {
        public DbSet<Auto> car { get; set; }
        public DbSet<Tulaj> people { get; set; }
        public DbSet<AutoEsTulaj> peoplecar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = "server=localhost;userid=root;password=;database=peoplecar";
            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoEsTulaj>()
                .HasKey(bc => new { bc.carid, bc.peopleid });




        }
    }
}
