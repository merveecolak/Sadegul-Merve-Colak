using BussAppData.Abstract;
using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppData.Concrete.EfCore
{
    public class EfCoreExpeditionRepository : EfCoreGenericRepository<Expedition, BussDbContext>, IExpeditionRepository
    {
        public Expedition GetExpenditionById(int id)
        {
            using (var context = new BussDbContext())
            {
                return context.Expeditions.Where(i => i.ExpeditionId == id).FirstOrDefault();
            }
        }

        public List<Expedition> SelectedExpedition(string nereden, string nereye, string tarih)
        {
            using (var context = new BussDbContext())
            {

                return context.Expeditions.Where(x => x.ExpeditionStart == nereden && x.ExpeditionFinish == nereye && x.ExpeditionDate == tarih).ToList();
            }
        }
    }
}
