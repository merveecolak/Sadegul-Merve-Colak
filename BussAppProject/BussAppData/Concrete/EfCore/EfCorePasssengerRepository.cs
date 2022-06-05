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
        
    }
}
