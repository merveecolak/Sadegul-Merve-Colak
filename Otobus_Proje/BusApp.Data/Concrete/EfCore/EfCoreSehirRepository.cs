using BusApp.Data.Abstract;
using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Data.Concrete.EfCore
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Guzergah, BusBiletContext>, ISehirRepository
    {
        public void Create(Sehir entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sehir entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Sehir entity)
        {
            throw new NotImplementedException();
        }

        List<Sehir> IRepository<Sehir>.GetAll()
        {
            throw new NotImplementedException();
        }

        Sehir IRepository<Sehir>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
