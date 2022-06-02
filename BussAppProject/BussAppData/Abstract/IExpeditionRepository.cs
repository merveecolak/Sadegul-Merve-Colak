using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppData.Abstract
{
    public interface IExpeditionRepository : IRepository<Expedition>
    {
        Expedition GetExpenditionById(int id);
        List<Expedition> SelectedExpedition(string nereden, string nereye, string tarih);
    }
}
