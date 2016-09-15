namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KyLuat")]
    public partial class KyLuat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Key]
        [Column(Order = 1)]
        public int MaKyLuat { get; set; }

        public DateTime? NgayKyLuat { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
