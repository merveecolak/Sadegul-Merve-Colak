using BusApp.Dataa.Abstract;
using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Dataa.Concrete.EF
{
    public class EfCoreExpeditionRepository : EFGenericRepository<Expedition, BusDbContext>, IExpeditionRepository
    {
        public List<Expedition> SelectedExpedition(string nereden, string nereye, string tarih)
        {
            using (var context = new BusDbContext())
            {
                return context.Expeditions.Where(x => x.ExpeditionStart == nereden && x.ExpeditionFinish == nereye && x.ExpeditionDate == tarih).ToList();
            }
        }
    }
}
