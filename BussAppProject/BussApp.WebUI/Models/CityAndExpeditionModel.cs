using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussApp.WebUI.Models
{

    public class CityAndExpeditionModel
    {
        public NewExpedition NewExpedition { get; set; }
        public List<City> Cities { get; set; }
    }
    public class NewExpedition
    {
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public string Tarih { get; set; }
    }
      
}