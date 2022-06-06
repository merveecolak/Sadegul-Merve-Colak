using KURS.BUSSINESS.Abstract;
using KURS.BUSSINESS.Concrete;
using KURS.DATA.Concrete;
using KURS.ENTITY;
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

        // list
        public IActionResult Index()
        {
            var courses = _courseService.GetAll();
            return View(courses); 
        }      

        // delete
        public IActionResult CourseDelete(int courseId)
        {
           var entity = _courseService.GetById(courseId);    
            _courseService.Delete(entity);
            return RedirectToAction("Index");
        }
         
        // Edit

        public IActionResult Edit(int id)
        {
            var course = _courseService.GetById(id);
            return View(course);
        }
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            _courseService.Update(course);
            return RedirectToAction("Index");
        }
        // create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            _courseService.Create(course);
            return RedirectToAction("Index");
        }


    }
}
