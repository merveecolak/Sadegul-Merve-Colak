
using Ders_Secim_App.Models.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ders_Secim_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext _context;
        public HomeController(StudentDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var OgrenciGetir = _context.Students.ToList();
            return View(OgrenciGetir);
        }

        public IActionResult DersSec()
        {
            var DersSec = _context.Courses.ToList();
            return View(DersSec);
        }

        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

    }
}
