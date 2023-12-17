using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO
{
    public class IngredientDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int COST { get; set; }


        public IngredientDTO() { }
        public IngredientDTO(INGREDIENT ing)
        {
            ID = ing.ID;
            NAME = ing.NAME;
            COST = ing.COST;


        }
    }
}
