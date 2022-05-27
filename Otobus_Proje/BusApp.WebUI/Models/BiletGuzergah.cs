using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusApp.WebUI.Models
{
    public class BiletGuzergah
    {
        public List<Guzergah> Guzergahs { get; set; }
        public List<Sehir> Sehirs { get; set; }
    }
}
