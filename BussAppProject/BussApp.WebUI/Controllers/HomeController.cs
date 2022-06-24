
using BussApp.WebUI.Models;
using BussAppBussines.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BussApp.WebUI.Controllers
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
            cityAndExpeditionModel.Cities = _cityService.GetAll();
            return View(cityAndExpeditionModel);
            
        }


    }
}
