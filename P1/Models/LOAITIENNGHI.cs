namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAITIENNGHI")]
    public partial class LOAITIENNGHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAITIENNGHI()
        {
            TIENNGHI = new HashSet<TIENNGHI>();
        }

        [Key]
        [StringLength(10)]
        public string MALOAITIENNGHI { get; set; }

        [StringLength(50)]
        public string TENLOAITIENNGHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIENNGHI> TIENNGHI { get; set; }
    }
}
