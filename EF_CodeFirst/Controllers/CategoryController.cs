using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Context;
using Models.Entities;
using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    public class CategoryController
    {
        private readonly LibraryContext _context;
        public CategoryController(LibraryContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {          
            var categories = _context.Categories
                .Where(x => x.IsDeleted==false)
                .ToList();
               return View(categories);        
        }
        public IActionResult GetDeletedCategories()
        {
            var categories = _context.Categories
                .Where(x => x.IsDeleted==true)
                .ToList();
            return View("Index",categories);
        }
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Categories.Find(id);
            category.IsDeleted=true;
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}