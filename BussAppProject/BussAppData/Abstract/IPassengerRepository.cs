using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppData.Abstract
{
    public interface IPassengerRepository : IRepository<Passenger>
    {
        int GetCountByKoltuk(int passengerId);
        List<int> GetKoltuk(int passengerId);
    }
}
