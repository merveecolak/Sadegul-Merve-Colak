using KURS.BUSSINESS.Abstract;
using KURS.DATA.Concrete;
using KURS.ENTITY;
using Microsoft.AspNetCore.Mvc;

namespace KURS.UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;
        //ctor
        public StudentController(IStudentService studentService, ICourseService courseService)
        {
            _studentService=studentService;
            _courseService=courseService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }

        // delete
        public IActionResult Delete(int studentid)
        {
            var student = _studentService.GetById(studentid);
            _studentService.Delete(student);
            return RedirectToAction("Index");
        }


        // Edit

        public IActionResult Edit(int id)
        {
            var student = _studentService.GetById(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            
            _studentService.Update(student);
            return RedirectToAction("Index");
        }
        //create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentService.Create(student);
            return RedirectToAction("Index");
        }
        public IActionResult SelectCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SelectCourse(Student student)
        {
            var x = _courseService.GetAll();
            ViewBag.selectCourse = x;
            return View(student);
        }

    }
}
