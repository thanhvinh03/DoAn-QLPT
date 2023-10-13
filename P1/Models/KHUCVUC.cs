namespace P1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUCVUC")]
    public partial class KHUCVUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUCVUC()
        {
            PHONG = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MAKV { get; set; }

        [StringLength(20)]
        public string TENKHUVUC { get; set; }

        [StringLength(200)]
        public string DIACHIKV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONG { get; set; }
    }
}
