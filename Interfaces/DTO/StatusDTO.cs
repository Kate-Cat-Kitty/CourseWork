using DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class StatusDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }


        public StatusDTO() { }
        public StatusDTO(STATUS st)
        {
            ID = st.ID;
            NAME = st.NAME;


        }
    }
}
