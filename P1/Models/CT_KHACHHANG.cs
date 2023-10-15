namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_KHACHHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDPHONG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAKH { get; set; }

        [StringLength(20)]
        public string CHUCVU { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
