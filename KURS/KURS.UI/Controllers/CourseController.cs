using KURS.BUSSINESS.Abstract;
using KURS.BUSSINESS.Concrete;
using KURS.DATA.Concrete;
using KUSYS_Project.Data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KURS.UI.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            return View(courses);
        }
       
    }
}
