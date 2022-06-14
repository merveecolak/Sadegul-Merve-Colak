﻿using BussAppBussines.Abstract;
using BussAppData.Abstract;
using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppBussines.Concrete
{
    public class PassengerManager : IPassengerService
    {
        private IPassengerRepository _passengerRepository;
        public PassengerManager(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }
        public void Create(Passenger entity)
        {
            _passengerRepository.Create(entity);
        }

        public void Delete(Passenger entity)
        {
            throw new NotImplementedException();
        }

        public List<Passenger> GetAll()
        {
            throw new NotImplementedException();
        }

        public Passenger GetById(Passenger Entity)
        {
            throw new NotImplementedException();
        }

       

        public void Update(Passenger entity)
        {
            throw new NotImplementedException();
        }
    }
}
