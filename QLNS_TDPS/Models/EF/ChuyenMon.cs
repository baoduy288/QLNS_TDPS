namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenMon")]
    public partial class ChuyenMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenMon()
        {
            NhanVien_ChuyenMon = new HashSet<NhanVien_ChuyenMon>();
        }

        [Key]
        public int MaChuyenMon { get; set; }

        [StringLength(50)]
        public string TenChuyenMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien_ChuyenMon> NhanVien_ChuyenMon { get; set; }
    }
}
