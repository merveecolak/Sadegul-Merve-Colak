using BussApp.WebUI.Models;
using BussAppBussines.Abstract;
using BussAppEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussApp.WebUI.Controllers
{
    public class ExpeditionController : Controller
    {
        private IExpeditionService _expeditionService;
        private IPassengerService _passengerService;
        private IBusService _busService;
        public ExpeditionController(IExpeditionService expeditionService, IPassengerService passengerService,IBusService busService)
        {
            _expeditionService = expeditionService;
            _passengerService = passengerService;
            _busService = busService;
    }

        public IActionResult Index(NewExpedition newExpedition)
        {
            var selectedExpedition = _expeditionService.SelectedExpedition(newExpedition.Nereden, newExpedition.Nereye, newExpedition.Tarih);
            
                return View(selectedExpedition);
            
            
        }

        public IActionResult CreateTicket(int id)
        {
            int guzergahKoltukSayisi = _passengerService.GetCountByKoltuk(id);
            List<int> dolukoltuklar = _passengerService.GetKoltuk(id);
            var koltuklar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (var item in dolukoltuklar)
            {
                koltuklar.Remove(item);
            }
            ViewBag.Expedition= _expeditionService.GetExpenditionById(id);
            ViewBag.Koltuklar = new SelectList(koltuklar);
            return View();
        }

        [HttpPost]
        public IActionResult Create(Passenger passenger)
        {
                   
            _passengerService.Create(passenger);
            return View(passenger);
        }
       
        //public IActionResult Seat(int seat)
        //{
        //    ViewBag.Seat = _busService.DoluKoltuklar(seat);
        //    return View();
        //}
     
    }
}
