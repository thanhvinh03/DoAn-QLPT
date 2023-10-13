namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DICHVU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MADICHVU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAHD { get; set; }

        public int? SOLUONGDV { get; set; }

        public double? THANHTIENDV { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }
    }
}
