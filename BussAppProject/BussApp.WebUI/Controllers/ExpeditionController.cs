using BussApp.WebUI.Models;
using BussAppBussines.Abstract;
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
        public ExpeditionController(IExpeditionService expeditionService, IPassengerService passengerService)
        {
            _expeditionService = expeditionService;
            _passengerService = passengerService;
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

        
    }
}
