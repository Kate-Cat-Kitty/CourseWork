using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class BuyerDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }

        public string FIRST_NAME { get; set; }

        public string MIDDLE_NAME { get; set; }
        public BuyerDTO() { }
        public BuyerDTO(BUYER b)
        {
            ID = b.ID;
            NAME = b.NAME;
            FIRST_NAME = b.FIRST_NAME;
            MIDDLE_NAME = b.MIDDLE_NAME;


        }
    }
}
