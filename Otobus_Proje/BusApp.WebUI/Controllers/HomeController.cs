using BusApp.Business;
using BusApp.Business.Abstract;
using BusApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Otobus_Proje.Controllers
{
    public class HomeController : Controller
    {
        private ISehirService _sehirService;
        private IGuzergahService _guzergahService;

        public IActionResult Index(string nereden,string nereye)
        {
            if (nereden==null || nereye==null || nereden==nereye)
            {
                var SehirModel = new BiletGuzergah()
                {
                    Sehirs = _sehirService.GetAll(),
                    Guzergahs = null
                };
                ViewBag.Sehirler = new SelectList(SehirModel.Sehirs, "Sehirıd", "SehirAd");
                return View(SehirModel);

            }
            return View();
        }
    }
}
