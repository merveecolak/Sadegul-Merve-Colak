using Kusys.Business.Abstract;
using Kusys.Entity;
using Kusys.WebUI.Models;
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
        public IActionResult SelectCourse(int studentId)
        {
            var student = _studentService.GetById(studentId);
            var course = _courseService.GetAll();
            var studentModel = new StudentModel()
            {
                StudentId = student.StudentId,
                StudentBirthday = student.StudentBirthday,
                StudentLastname = student.StudentLastname,
                StudentName = student.StudentName,
                Courses = course
            };
            return View(studentModel);
        }


        [HttpPost]
        public IActionResult SelectedCourse(StudentModel model)
        {
            var studentId = _studentService.GetById(model.StudentId);

            
            _studentService.Update(studentId);

         return RedirectToAction("SelectCourse");
        }
    }
}