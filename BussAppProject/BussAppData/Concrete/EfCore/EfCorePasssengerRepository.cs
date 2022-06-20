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

        public int GetCountByKoltuk(int passengerId)
        {
            using (var context = new BussDbContext())
            {
                return context.Passengers
                    .Where(i => i.PassengerId == passengerId)
                    .Select(i => i.SeatNumber)
                    .Count();
            }
        }

        public List<int> GetKoltuk(int passengerId)
        {
            using (var context = new BussDbContext())
            {
                var koltuk = context.Passengers
                    .Where(i => i.PassengerId == passengerId)
                    .Select(i => i.SeatNumber)
                    .ToList();

                return koltuk;
            }
        }
    }
}
