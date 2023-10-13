namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            CT_DICHVU = new HashSet<CT_DICHVU>();
        }

        [Key]
        [StringLength(10)]
        public string MADICHVU { get; set; }

        [StringLength(50)]
        public string TENDICHVU { get; set; }

        [StringLength(10)]
        public string DONVITINH { get; set; }

        public double? GIATIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DICHVU> CT_DICHVU { get; set; }
    }
}
