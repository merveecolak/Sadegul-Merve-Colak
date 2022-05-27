using BusApp.Bussines.Abstract;
using BusApp.Dataa.Abstract;
using BusApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusApp.Bussines.Concrete
{
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public void Create(City entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(City Entity)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
