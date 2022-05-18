using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Entity
{
    public class Guzergah
    {
        public int GuzergahId { get; set; }
        public string Baslangıc { get; set; }
        public string gz1 { get; set; }
        public string gz2 { get; set; }
        public string Bitis { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public int Fiyat { get; set; }

        public List<Bilet> Bilets { get; set; }
    }
}
