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
    public class EfCorePasssengerRepository : EfCoreGenericRepository<Passenger, BussDbContext>, IPassengerRepository
    {
        public List<int> DoluKoltuklar(int seat)
        {
            using (var context =new BussDbContext())
            {
                var dolukoltuklar = context.Passengers.Where(i => i.ExpeditionId == seat).Select(i => i.SeatNumber).ToList();
                
                return dolukoltuklar;   
            }
        }
    }
}
