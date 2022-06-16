using BussAppData.Abstract;
using BussAppEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppData.Concrete.EfCore
{
    public class EfCoreBusRepository : EfCoreGenericRepository<Bus, BussDbContext>, IBusRepository
    {
        public Bus Seat(int seat)
        {
            using (var context=new BussDbContext())
            {
                return context
                     .Buses
                     .Where(i => i.BusSeatNumber == seat)
                     .Include(i => i.Expeditions)
                     .FirstOrDefault();               
            }
          
        }
    }
}
