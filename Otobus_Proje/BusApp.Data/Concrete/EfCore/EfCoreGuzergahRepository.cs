﻿
using BusApp.Data.Abstract;
using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Data.Concrete.EfCore
{
    public class EfCoreGuzergahRepository : EfCoreGenericRepository<Guzergah, BusBiletContext>, IGuzergahRepository
    {
       
    }
}
