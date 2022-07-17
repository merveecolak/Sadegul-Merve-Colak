using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace WebApi.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int productId);
        List<Product> GetAll();

        Product Create(Product entity);
        void Delete(Product entity);
        Product Update(Product entity);
        void Create(Product entity, int[] categoryIds);
        void Update(Product entity, int[] categoryIds);
        IEnumerable<Product> GetProducts();
    }
}
