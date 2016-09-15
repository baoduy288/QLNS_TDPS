namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NgachBac")]
    public partial class NgachBac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NgachBac()
        {
            NhanVien_Ngach = new HashSet<NhanVien_Ngach>();
        }

        [Key]
        [StringLength(10)]
        public string MaNgach { get; set; }

        [StringLength(50)]
        public string TenNgach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien_Ngach> NhanVien_Ngach { get; set; }
    }
}
