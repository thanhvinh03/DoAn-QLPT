namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_TIENNGHI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MATIENNGHI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAHD { get; set; }

        public int? SOLUONGTN { get; set; }

        public double? THANHTIENTN { get; set; }

        public virtual HOPDONG HOPDONG { get; set; }

        public virtual TIENNGHI TIENNGHI { get; set; }
    }
}
