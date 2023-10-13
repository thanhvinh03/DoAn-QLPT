namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_HOPDONG()
        {
            CT_DSKHACHHANG = new HashSet<CT_DSKHACHHANG>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDPHONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYBATDAU { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_DUKIENKT { get; set; }

        public double? TIENDV { get; set; }

        public double? TIENTN { get; set; }

        public double? TIENPHONG { get; set; }

        public double? TONGTIENTHUE { get; set; }

        public double? TIENCOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DSKHACHHANG> CT_DSKHACHHANG { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
