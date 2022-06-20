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
        private IPassengerRepository _passengerRepository;

        public BusManager(IBusRepository busRepository, IPassengerRepository passengerRepository)
        {
            _busRepository = busRepository;
            _passengerRepository = passengerRepository;
        }

        public void Create(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Bus entity)
        {
            throw new NotImplementedException();
        }

        public List<int> DoluKoltuklar(int seat)
        {
            return _passengerRepository.GetKoltuk(seat);
        }

        public List<Bus> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bus GetById(Bus Entity)
        {
            throw new NotImplementedException();
        }

       

        public void Update(Bus entity)
        {
            throw new NotImplementedException();
        }
    }
}
