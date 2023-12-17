using DAL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class Pizza_IngredientDTO
    {
        public int PIZZA_ID { get; set; }
        public int INGREDIENT_ID { get; set; }
        public int AMOUNT { get; set; }


        public Pizza_IngredientDTO() { }
        public Pizza_IngredientDTO(PIZZA_INGREDIENT pi)
        {
            PIZZA_ID = pi.PIZZA_ID;
            INGREDIENT_ID = pi.INGREDIENT_ID;
            AMOUNT = pi.AMOUNT;


        }
    }
}
