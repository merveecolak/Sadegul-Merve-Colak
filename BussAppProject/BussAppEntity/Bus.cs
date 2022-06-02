using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppEntity
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusDriverName { get; set; }
        public string BusPlaque { get; set; }
        public int BusSeatNumber { get; set; }

        // ilişki
        public List<Expedition> Expeditions { get; set; }
    }
}
