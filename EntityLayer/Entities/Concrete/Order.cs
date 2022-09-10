using EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public string CompanyName { get; set; }
        public string ProductionName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

       [NotMapped]
        public double TotalPrice
        {
            get { return Quantity*UnitPrice; }
        }

    }
}
