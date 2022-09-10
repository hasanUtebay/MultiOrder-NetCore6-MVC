﻿using DAL.Repositories.Interfaces.Abstract;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces.Concrete
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
    }
}
