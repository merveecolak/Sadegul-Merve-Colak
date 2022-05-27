using BusApp.Bussines.Abstract;
using BusApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICityService _cityService;

        public HomeController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public IActionResult Index()
        {
            CityAndExpeditionModel cityAndExpeditionModel = new CityAndExpeditionModel();
            cityAndExpeditionModel.Cities= _cityService.GetAll();
            return View(cityAndExpeditionModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
