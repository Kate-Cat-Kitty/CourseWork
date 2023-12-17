using DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class PizzaDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int COST { get; set; }
        public string DESCRIPTION { get; set; }
        public int ORDER_ID { get; set; }


        public PizzaDTO() { }
        public PizzaDTO(PIZZA p)
        {
            ID = p.ID;
            NAME = p.NAME;
            COST = p.COST;
            DESCRIPTION = p.DESCRIPTION;
            ORDER_ID = p.ORDER_ID;

        }
    }
}
