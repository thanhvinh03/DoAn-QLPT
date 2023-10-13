namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIENNGHI")]
    public partial class TIENNGHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIENNGHI()
        {
            CT_TIENNGHI = new HashSet<CT_TIENNGHI>();
        }

        [Key]
        [StringLength(10)]
        public string MATIENNGHI { get; set; }

        [Required]
        [StringLength(10)]
        public string MALOAITIENNGHI { get; set; }

        [StringLength(50)]
        public string TENTIENNGHI { get; set; }

        public int? TONKHO { get; set; }

        public double? GIAMUA { get; set; }

        public double? GIATHUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_TIENNGHI> CT_TIENNGHI { get; set; }

        public virtual LOAITIENNGHI LOAITIENNGHI { get; set; }
    }
}
