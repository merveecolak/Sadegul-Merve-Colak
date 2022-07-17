using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Abstarct;
using WebApi.Entity;

namespace WebApi.Data.Concrete
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, WebApiContext>, IProductRepository
    {
        public void Create(Product entity, int[] categoryIds)
        {
            using (var context = new WebApiContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public Product GetByIdWithCategories(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var context = new WebApiContext())
            {
                
                return context.Products.Include(x => x.Category).ToList();
            }
           
        }

        public void Update(Product entity, int[] categoryIds)
        {
            throw new NotImplementedException();
        }
    }
}
