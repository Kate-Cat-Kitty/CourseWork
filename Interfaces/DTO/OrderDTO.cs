using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public string DELIVERY_ADDRESS { get; set; }

        public int SUM { get; set; }

        public DateTime DATE { get; set; }
        public int BUYER_ID { get; set; }
        public int STATUS_ID { get; set; }
        public int? PROMO_CODE_ID { get; set; }
        public int? ADMIN_ID { get; set; }
        public OrderDTO() { }
        public OrderDTO(ORDER o)
        {
            ID = o.ID;
            DELIVERY_ADDRESS = o.DELIVERY_ADDRESS;
            SUM = o.SUM;
            DATE = o.DATE;
            BUYER_ID = o.BUYER_ID;
            STATUS_ID = o.STATUS_ID;
            PROMO_CODE_ID = o.PROMO_CODE_ID;
            ADMIN_ID = o.ADMIN_ID;


        }
    }
}
