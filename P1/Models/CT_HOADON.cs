namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAHOADON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDPHONG { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MATIENICH { get; set; }

        [Column(TypeName = "date")]
        public DateTime TUNGAY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DENNGAY { get; set; }

        public decimal? CHISOCU { get; set; }

        public decimal? CHISOMOI { get; set; }

        public decimal? TONGSO { get; set; }

        public double? TTIEN { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual TIENICH TIENICH { get; set; }
    }
}
