namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanThan")]
    public partial class NhanThan
    {
        [Key]
        [Column(Order = 0)]
        public int MaNhanThan { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [StringLength(30)]
        public string TenNhanThan { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(30)]
        public string QueQuan { get; set; }

        public int? MaLoaiNhanThan { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SoDT { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual LoaiNhanThan LoaiNhanThan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
