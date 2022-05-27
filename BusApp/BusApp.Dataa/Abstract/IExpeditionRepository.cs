using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Dataa.Abstract
{
    public interface IExpeditionRepository : IRepository<Expedition>
    {
        List<Expedition> SelectedExpedition(string nereden, string nereye, string tarih);
    }
}
