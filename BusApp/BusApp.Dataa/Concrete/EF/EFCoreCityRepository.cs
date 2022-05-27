using BusApp.Dataa.Abstract;
using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Dataa.Concrete.EF
{
    public class EFCoreCityRepository : EFGenericRepository<City,BusDbContext>,ICityRepository
    {

    }
}
