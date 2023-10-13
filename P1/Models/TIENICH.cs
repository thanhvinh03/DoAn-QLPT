namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIENICH")]
    public partial class TIENICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIENICH()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
        }

        [Key]
        [StringLength(10)]
        public string MATIENICH { get; set; }

        [StringLength(50)]
        public string TENTIENICH { get; set; }

        [StringLength(20)]
        public string DVT { get; set; }

        public double? GIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }
    }
}
