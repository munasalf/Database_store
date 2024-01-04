using Microsoft.EntityFrameworkCore;
using StorDatabase_3_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorDatabase_3_1.ApplicationDbcontexet
{
    internal class ApplicationDBstore : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H0S7VNS\\MSSQLSERVER02;Initial catalog = Stored ;Integrated Security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.UserId).
                IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Store>().Property(w => w.CompanyId).
                IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Company>().Property(z => z.CompanyName).IsRequired().HasMaxLength(50);

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies{ get; set; }
        public DbSet<Store> stores { get; set; }
    }
}

    

