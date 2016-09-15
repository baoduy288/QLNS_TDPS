namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [Key]
        [Column(Order = 0)]
        public int MaHopDong { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        public DateTime? NgayKy { get; set; }

        public DateTime? NgayHetHan { get; set; }

        [StringLength(50)]
        public string LoaiHopDong { get; set; }

        [StringLength(30)]
        public string SoHopDong { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
