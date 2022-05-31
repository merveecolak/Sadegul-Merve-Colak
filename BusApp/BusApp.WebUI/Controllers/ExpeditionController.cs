using BusApp.Bussines.Abstract;
using BusApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusApp.WebUI.Controllers
{
    public class ExpeditionController : Controller
    {
        private IExpeditionService _expeditionService;
        public ExpeditionController(IExpeditionService expeditionService)
        {
            _expeditionService = expeditionService;
        }

        public IActionResult Index(NewExpedition newExpedition)
        {
            var selectedExpedition = _expeditionService.SelectedExpedition(newExpedition.Nereden, newExpedition.Nereye, newExpedition.Tarih);
            return View(selectedExpedition);
        }
    }
}


//Dokuz Eylül Üniversitesi  İstatistik (İngilizce) bölümünden onur öğrencisi olarak mezun oldum.
//Lisans eğitimim boyunca iki farklı şirkette yazılım geliştirme ekibinde aktif olarak rol aldım. Bu süreçte kullandığım teknolojiler :
//*C# , .NET , R , RStudio , Python

//Üniversiteden mezun olduktan sonra WİSSEN AKADEMİE-BAHÇEŞEHİR ÜNİVERSİTESİ İŞKUR destekli programında Web ve Mobil Yazılım Geliştirme Uzmanı programına 8000 başvuru arasından 5 farklı sınav ve teknik mülakat aşamalarından geçerek ilk 28 öğrencisi arasına girmeye hak kazandım. Bu süreçte kullandığım teknolojiler;
//*C# , .NET , Entity Framework , Linq , MVC, ASP.NET CORE, ASP.NET WEB API, Generic Repository Design Pattern, Katmanlı Mimari
//* CSS, HTML, React.js, Javascript, Bootstrap, Jquery
// * Sql Server, Sqlite
//*Github, Github Desktop
