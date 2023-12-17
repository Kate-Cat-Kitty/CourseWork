namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BUYER")]
    public partial class BUYER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BUYER()
        {
            ORDER = new HashSet<ORDER>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [StringLength(50)]
        public string MIDDLE_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDER { get; set; }
    }
}
