using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Business.Abstract;
using WebApi.Data.Abstarct;
using WebApi.Data.Concrete;
using WebApi.Entity;

namespace WebApi.Business.Concrete
{
    public class ProductManager : IProductService

    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Create(Product entity)
        {
            return _productRepository.Create(entity);
        }

        public void Create(Product entity, int[] categoryIds)
        {
            _productRepository.Create(entity, categoryIds);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public Product GetById(int productId)
        {
            return _productRepository.GetById(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public Product Update(Product entity)
        {
            return _productRepository.Update(entity);
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _productRepository.Update(entity, categoryIds);
        }
    }
}
