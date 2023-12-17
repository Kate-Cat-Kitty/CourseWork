namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PIZZA_INGREDIENT
    {
        public int AMOUNT { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PIZZA_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int INGREDIENT_ID { get; set; }

        public virtual INGREDIENT INGREDIENT { get; set; }

        public virtual PIZZA PIZZA { get; set; }
    }
}
