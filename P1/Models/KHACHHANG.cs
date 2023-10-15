namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            CT_KHACHHANG = new HashSet<CT_KHACHHANG>();
        }

        [Key]
        [StringLength(10)]
        public string MAKH { get; set; }

        [StringLength(100)]
        public string HOTENKH { get; set; }

        [StringLength(20)]
        public string CCCD { get; set; }

        [StringLength(20)]
        public string DIENTHOAI { get; set; }

        [StringLength(50)]
        public string QUEQUAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KHACHHANG> CT_KHACHHANG { get; set; }
    }
}
