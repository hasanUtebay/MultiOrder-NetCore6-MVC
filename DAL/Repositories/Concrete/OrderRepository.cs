using DAL.Context;
using DAL.Repositories.Abstract;
using DAL.Repositories.Interfaces.Concrete;
using EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class OrderRepository : BaseRepository<Order>,IOrderRepository
    {
        public OrderRepository(ProjectContext context) : base(context)
        {
        }
    }
}
