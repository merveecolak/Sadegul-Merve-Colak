using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppEntity
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SeatNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public string Hour { get; set; }
        public string Date { get; set; }

        public int ExpeditionId { get; set; }
        public Expedition Expedition { get; set; }

    }
}
