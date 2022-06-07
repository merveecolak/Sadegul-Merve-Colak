using KURS.BUSSINESS.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KURS.UI.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly IStudentCourseService _studentCourseService;
        public StudentCourseController(IStudentCourseService studentCourseService)
        {
            _studentCourseService = studentCourseService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SelectCourse()
        {
            ViewBag.StudentCource = _studentCourseService.GetAll();
            return View();
        }
        //[HttpPost]
        //public IActionResult SelectCourse(  )
        //{
        //    ViewBag.StudentCource = _studentCourseService.GetAll();
        //    return View();
        //}
    }
}
