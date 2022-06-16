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
            ViewBag.Expedition = _expeditionService.GetExpenditionById(id);
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
            ViewBag.Seat = _busService.Seat(seat);
            return View();
        }
     
    }
}
