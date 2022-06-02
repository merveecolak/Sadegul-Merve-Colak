﻿using System;
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
        public string Tcno { get; set; }
        public int SeatNumber { get; set; }
        public List<Expedition> expeditions { get; set; }
    }
}
