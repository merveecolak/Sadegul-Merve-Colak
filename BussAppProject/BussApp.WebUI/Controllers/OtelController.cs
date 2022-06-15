using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussApp.WebUI.Controllers
{
    public class OtelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
