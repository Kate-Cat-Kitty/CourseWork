namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INGREDIENT")]
    public partial class INGREDIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INGREDIENT()
        {
            PIZZA_INGREDIENT = new HashSet<PIZZA_INGREDIENT>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public int COST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PIZZA_INGREDIENT> PIZZA_INGREDIENT { get; set; }
    }
}
