using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Business.Abstract
{
    public interface ISehirService
    {
        List<Sehir> GetAll();

    }
}
