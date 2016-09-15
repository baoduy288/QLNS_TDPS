namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NhanVien_Ngach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaNgach { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        public DateTime? NgayNgach { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual NgachBac NgachBac { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
