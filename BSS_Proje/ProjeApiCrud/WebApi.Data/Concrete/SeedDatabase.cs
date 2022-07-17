using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace WebApi.Data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new WebApiContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }


        private static Product[] Products =
       {
            new Product {ProductId=1, CategoryId=1, ProductName="Apple 1", ProductPrice=15000, ProductDescription="En iyi telefon.", ProductDateCreate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductId=2, CategoryId=2, ProductName="Apple 2", ProductPrice=10000, ProductDescription="Zamanı Siz Yönetin", ProductDateCreate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductId=3, CategoryId=3, ProductName="Aplle 3", ProductPrice=20000, ProductDescription="Tabletinzle her gün sizin.", ProductDateCreate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Product {ProductId=4, CategoryId=4, ProductName="Apple 4", ProductPrice=30000, ProductDescription="En iyi bilgisayar.", ProductDateCreate=Convert.ToDateTime("2022-06-11 00:00:00")},
        };

        private static Category[] Categories =
       {
            new Category() {CategoryId=1, CategoryName="Telefon",CategoryDescription="En son teknolojiden ilk siz haberdar olun.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Category() {CategoryId=2, CategoryName="Saat",CategoryDescription="En son teknolojiden ilk siz haberdar olun.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Category() {CategoryId=3, CategoryName="Tablet",CategoryDescription="En son teknolojiden ilk siz haberdar olun.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")},
            new Category() {CategoryId=4, CategoryName="Bilgisayar",CategoryDescription="En son teknolojiden ilk siz haberdar olun.",CategoryCreateDate=Convert.ToDateTime("2022-06-11 00:00:00")}

        };    
    }
}
