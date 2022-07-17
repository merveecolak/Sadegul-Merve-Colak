using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace WebApi.Data.Concrete
{
    public class WebApiContext :DbContext
    {
        // gerekli paketleri data katmanına yükledikten sonra  tablolarımızı veri tabanında görmek için 
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebApiDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
