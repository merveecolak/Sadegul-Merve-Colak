using BusApp.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Otobus_Proje.Controllers
{
    public class BiletSayfasıController : Controller
    {
        private IGuzergahService _guzergahService;
        public IActionResult Index()
        {
            return View(_guzergahService.GetAll());
        }
    }
}
