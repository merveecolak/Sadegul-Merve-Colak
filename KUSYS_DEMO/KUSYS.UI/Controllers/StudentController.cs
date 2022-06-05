using Microsoft.AspNetCore.Mvc;

namespace KUSYS.UI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
