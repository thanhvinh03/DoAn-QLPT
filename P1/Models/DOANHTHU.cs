namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOANHTHU")]
    public partial class DOANHTHU
    {
        [Key]
        [StringLength(10)]
        public string STT { get; set; }

        [Required]
        [StringLength(5)]
        public string MAKV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? START { get; set; }

        [Column(TypeName = "date")]
        public DateTime? END { get; set; }

        [Column("DOANHTHU")]
        public double? DOANHTHU1 { get; set; }

        public double? CHIPHI { get; set; }

        public double? LOINHHUAN { get; set; }

        public virtual KHUCVUC KHUCVUC { get; set; }
    }
}
