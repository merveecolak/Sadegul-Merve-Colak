using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppEntity
{
    public class Expedition
    {
        public int ExpeditionId { get; set; }
        public string ExpeditionStart { get; set; }
        public string ExpeditionStation { get; set; }
        public string ExpeditionFinish { get; set; }
        public string ExpeditionDate { get; set; }
        public string ExpeditionHour { get; set; }
        public decimal ExpeditionPrice { get; set; }

        public int BusId { get; set; }
        // ilişki
        public Bus Bus { get; set; }
        public List<Passenger> passenger { get; set; }
    }
}
