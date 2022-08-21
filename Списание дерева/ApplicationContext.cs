using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Списание_дерева.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Списание_дерева
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Semimanufactures> semimanufactures { get; set; } = null!;
        public DbSet<SizeSemimanufactures> sizeSemimanufactures { get; set; } = null!;
      
      public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hell.db");
        }
    }
}
