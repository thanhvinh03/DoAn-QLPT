namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
            CT_HOPDONG = new HashSet<CT_HOPDONG>();
            CT_KHACHHANG = new HashSet<CT_KHACHHANG>();
        }

        [Key]
        [StringLength(10)]
        public string IDPHONG { get; set; }

        [Required]
        [StringLength(5)]
        public string MAKV { get; set; }

        [StringLength(20)]
        public string TENPHONG { get; set; }

        public int? SOLUONGNGUOI { get; set; }

        [StringLength(50)]
        public string TRANGTHAI { get; set; }

        [StringLength(200)]
        public string GHICHU { get; set; }

        [Required]
        [StringLength(10)]
        public string IDLOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOPDONG> CT_HOPDONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_KHACHHANG> CT_KHACHHANG { get; set; }

        public virtual KHUCVUC KHUCVUC { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }
    }
}
