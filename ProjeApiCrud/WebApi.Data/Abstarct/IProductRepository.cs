using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace WebApi.Data.Abstarct
{
    public interface IProductRepository : IRepository<Product>
    {
        void Create(Product entity, int[] categoryIds);
        void Update(Product entity, int[] categoryIds);
        Product GetByIdWithCategories(int id);
        IEnumerable<Product> GetProducts();
    }
}
