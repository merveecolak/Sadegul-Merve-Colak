using BusApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Data.Concrete.EfCore
{
    public class BusBiletContext : DbContext
    {
        public DbSet<Bilet> Bilets { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AT9VDS3;Database=BusDbApp;Trusted_Connection=true;");
        }
    }
}
