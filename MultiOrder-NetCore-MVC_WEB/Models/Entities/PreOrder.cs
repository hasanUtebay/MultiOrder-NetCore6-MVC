using System.ComponentModel.DataAnnotations.Schema;

namespace MultiOrder_NetCore_MVC_WEB.Models.Entities
{
    public class PreOrder
    {
        public string ProductionName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        [NotMapped]
        public double TotalPrice
        {
            get { return Quantity * UnitPrice; }
        }
    }
}
