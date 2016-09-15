namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiNhanThan")]
    public partial class LoaiNhanThan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiNhanThan()
        {
            NhanThans = new HashSet<NhanThan>();
        }

        [Key]
        public int MaLoaiNhanThan { get; set; }

        [StringLength(100)]
        public string TenLoaiNhanThan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanThan> NhanThans { get; set; }
    }
}
