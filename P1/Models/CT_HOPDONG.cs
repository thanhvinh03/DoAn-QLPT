namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOPDONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDPHONG { get; set; }

        public DateTime? NGAYBATDAU { get; set; }

        public DateTime? NGAY_DUKIENKT { get; set; }

        public double? TIENDV { get; set; }

        public double? TIENTN { get; set; }

        public double? TIENPHONG { get; set; }

        public double? TONGTIENTHUE { get; set; }

        public double? TIENCOC { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
