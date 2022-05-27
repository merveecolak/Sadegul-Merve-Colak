using BusApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Dataa.Concrete.EF
{
    public class BusDbContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AT9VDS3;Database=MerveBusApp;Trusted_Connection=true;");
        }
    }
}
