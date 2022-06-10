using KUSYS.Business.Abstract;
using KUSYS.Data.Abstract;
using KUSYS.Entity;
using Microsoft.AspNetCore.Mvc;

namespace KUSYS.UI.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService=studentService;
        }
       

        public List<Student> IActionResult Index()
        {
            return _studentService.GetAll();
        }


    }
}
