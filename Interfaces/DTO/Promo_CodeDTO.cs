﻿using DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class Promo_CodeDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }

        public int DISCOUNT { get; set; }

        public Promo_CodeDTO() { }
        public Promo_CodeDTO(PROMO_CODE pr)
        {
            ID = pr.ID;
            NAME = pr.NAME;
            DISCOUNT = pr.DISCOUNT;


        }
    }
}
