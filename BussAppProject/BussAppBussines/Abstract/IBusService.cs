﻿using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppBussines.Abstract
{
    public interface IBusService:IRepositoryService<Bus>
    {
        List<int> DoluKoltuklar(int seat);
    }
}
