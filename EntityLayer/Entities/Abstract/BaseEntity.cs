using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? RemovedDate { get; set; }

        private Boolean _statu = true;

        public Boolean Statu
        {
            get { return _statu; }
            set { _statu = value; }
        }
    }
}
