using Kusys.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kusys.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IStudentService _studentService;
        private ICourseService _courseService;
        public HomeController(IStudentService studentService, ICourseService courseService)
        {
            _studentService = studentService;
            _courseService = courseService;
        }

        public IActionResult Index()
        {

            var x = _studentService.GetAll();

            return View(x);
        }
        public IActionResult SelectCourse(int id)
        {
            var studentId = _studentService.GetById(id);
           ViewBag.course= _courseService.GetAll();
            return View();
        }
        //[HttpPost]
        //public IActionResult SelectCourse()
        //{
        //    _studentService.GetAll();
        //    var course = _courseService.GetAll();
        //    ViewBag.courseSelect = course;
        //    return View();
        //}
    }
}