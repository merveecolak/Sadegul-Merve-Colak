using BussAppBussines.Abstract;
using BussAppData.Abstract;
using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppBussines.Concrete
{
    public class BusManager : IBusService
    {
        private IBusRepository _busRepository;
        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }
        public void Create(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Bus entity)
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bus GetById(Bus Entity)
        {
            throw new NotImplementedException();
        }

        public Bus Seat(int seat)
        {
          return  _busRepository.Seat(seat);
           
        }

        public void Update(Bus entity)
        {
            throw new NotImplementedException();
        }
    }
}
