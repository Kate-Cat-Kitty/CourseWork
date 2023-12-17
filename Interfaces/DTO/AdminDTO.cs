using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces.DTO
{
    public class AdminDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }

        public string FIRST_NAME { get; set; }

        public string MIDDLE_NAME { get; set; }
        public AdminDTO() { }
        public AdminDTO(ADMIN a)
        {
            ID = a.ID;
            NAME = a.NAME;
            FIRST_NAME = a.FIRST_NAME;
            MIDDLE_NAME = a.MIDDLE_NAME;


        }
    }
}
