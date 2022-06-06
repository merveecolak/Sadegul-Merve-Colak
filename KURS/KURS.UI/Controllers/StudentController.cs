using KURS.BUSSINESS.Abstract;
using KURS.DATA.Concrete;
using KURS.ENTITY;
using Microsoft.AspNetCore.Mvc;

namespace KURS.UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        //ctor
        public StudentController(IStudentService studentService)
        {
            _studentService=studentService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }

        // delete
        public IActionResult Delete(int id)
        {
            var student = _studentService.GetById(id);
            _studentService.Delete(student);
            return RedirectToAction("Index");
        }


        // Edit

        public IActionResult Edit(int id)
        {
            var course = _studentService.GetById(id);
            return View(course);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _studentService.Update(student);
            return RedirectToAction("Index");
        }

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








        //public IActionResult Details(int id)
        //{
        //    var student = _context.Students.Find(id);
        //    return View(student);
        //}
        //public IActionResult Edit(int id)
        //{
        //    var student = _context.Students.Find(id);
        //    return View(student);
        //}

        //[HttpPost]
        //public IActionResult Edit(Student student)
        //{
        //    _context.Students.Update(student);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //public IActionResult Delete(int id)
        //{
        //    var author = _studentService.Find(id);
        //    return View(author);
        //}


        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var student = _context.Students.Find(id);
        //    _context.Students.Update(student);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(Student student)
        //{
        //    _context.Add(student);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");

        //}
    }
}
