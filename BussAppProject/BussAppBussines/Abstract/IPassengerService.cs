﻿using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppBussines.Abstract
{
    public interface IPassengerService :IRepositoryService<Passenger>
    {
        Passenger GetPassengerById(int id);
        int GetCountByKoltuk(int passengerId);
        public List<int> GetKoltuk(int passengerId);
    }
}
