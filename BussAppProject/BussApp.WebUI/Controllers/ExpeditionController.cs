using BussApp.WebUI.Models;
using BussAppBussines.Abstract;
using BussAppEntity;
using Microsoft.AspNetCore.Mvc;
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
            var sefer = _expeditionService.GetExpenditionById(id);
            var dolukoltuklar = _busService.DoluKoltuklar(id);
            
            var koltuklar = new List<int>();
            for (int i = 1; i < 41; i++)
            {
                koltuklar.Add(i);
            }
            foreach (var item in dolukoltuklar)
            {
                koltuklar.Remove(item);
            }
            ViewBag.Seat.BusSeatNumber();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Passenger passenger)
        {
                   
            _passengerService.Create(passenger);
            return View(passenger);
        }
       
        public IActionResult Seat(int seat)
        {
            ViewBag.Seat = _busService.DoluKoltuklar(seat);
            return View();
        }
     
    }
}
