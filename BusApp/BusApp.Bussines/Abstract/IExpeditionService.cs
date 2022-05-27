using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Bussines.Abstract
{
    public interface IExpeditionService : IRepositoryService<Expedition>
    {
        List<Expedition> SelectedExpedition(string nereden, string nereye, string tarih);

    }
}
