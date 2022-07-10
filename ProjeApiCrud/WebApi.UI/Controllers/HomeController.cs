using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Business.Abstract;
using WebApi.Entity;
using WebApi.UI.Models;

namespace WebApi.UI.Controllers
{
    public class HomeController : Controller
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


        public IActionResult Index()
        {
            return View(_productService.GetProducts());
        }

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
            return ViewBag( _categoryService.GetAll());
        }

        //Product silmek için 
        // delete
        public IActionResult ProductDelete(int productId)
        {
            var product = _productService.GetById(productId);
            _productService.Delete(product);
            return RedirectToAction("Index");
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

        // Edit

        public IActionResult Edit(int id)
        {
            var product = _productService.GetById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");
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
