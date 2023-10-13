namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DSKHACHHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDPHONG { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MAKH { get; set; }

        [Required]
        [StringLength(30)]
        public string CHUCVU { get; set; }

        public virtual CT_HOPDONG CT_HOPDONG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
