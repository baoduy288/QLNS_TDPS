namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NhanVien_ChuyenMon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChuyenMon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        public DateTime? Ngay { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual ChuyenMon ChuyenMon { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
