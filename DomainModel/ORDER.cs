namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDER")]
    public partial class ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER()
        {
            PIZZA = new HashSet<PIZZA>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DELIVERY_ADDRESS { get; set; }

        public int SUM { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        public int BUYER_ID { get; set; }

        public int STATUS_ID { get; set; }

        public int? PROMO_CODE_ID { get; set; }

        public int? ADMIN_ID { get; set; }

        public DateTime DATE { get; set; }

        public virtual ADMIN ADMIN { get; set; }

        public virtual BUYER BUYER { get; set; }

        public virtual PROMO_CODE PROMO_CODE { get; set; }

        public virtual STATUS STATUS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PIZZA> PIZZA { get; set; }
    }
}
