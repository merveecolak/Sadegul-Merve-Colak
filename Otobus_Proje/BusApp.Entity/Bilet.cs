using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Entity
{
    public class Bilet
    {
        public int BiletId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public int KoltukNo { get; set; }
        public int Fiyat { get; set; }

        public List<Guzergah> Guzergahs { get; set; }
    }
}
