using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Business.Abstract;
using WebApi.Entity;

namespace WebApiProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }


        // ürüleri kategorilriyle listeler

        //[HttpGet("GetProducts")]
        //public IEnumerable<Product> GetProducts()
        //{
        //    return _productService.GetAll();
        //}

        // ürünleri listeler
        [HttpGet("GetProducts")]
        public IEnumerable<Product> AllProducts()
        {
            return _productService.GetProducts();
        }

        // kategorileri listeler
        [HttpGet("GetCategories")]
        public IEnumerable<Category> GetCategories()
        {
            return _categoryService.GetAll();
        }

        //Product silmek için 
        [HttpDelete("product/{productId}")]
        public void DeleteProduct(int productId)
        {
            _productService.Delete(_productService.GetById(productId));
        }

        // category silmek için
        [HttpDelete("category/{categoryId}")]
        public void DeleteCategory(int categoryId)
        {
            _categoryService.Delete(_categoryService.GetById(categoryId));
        }

        //product oluşturma

        [HttpPost("SetProduct")]
        public Product SetProduct([FromBody] Product product)
        {
            Product product1 = new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice,
                ProductDateCreate = product.ProductDateCreate,
                CategoryId = product.CategoryId
            };
            return _productService.Create(product1);
        }

        //product güncelleme

        [HttpPut("UpdateProduct")]
        public Product UpdateProduct([FromBody] Product product)
        {
            Product product1 = new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice,
                ProductDateCreate = product.ProductDateCreate,
                CategoryId = product.CategoryId
            };
            return _productService.Update(product1);
        }

        //category oluşturma
        [HttpPost("SetCategory")]
        public Category SetCategory([FromBody] Category category)
        {
            return _categoryService.Create(category);
        }

        // category update(güncelleme) etme
        [HttpPut("UpdateCategory")]
        public Category UpdateCategory([FromBody] Category category)
        {
            return _categoryService.Update(category);

        }


    }    
}
