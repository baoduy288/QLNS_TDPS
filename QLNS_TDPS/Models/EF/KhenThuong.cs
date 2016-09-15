namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhenThuong")]
    public partial class KhenThuong
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Key]
        [Column(Order = 1)]
        public int MaKhenThuong { get; set; }

        public DateTime? NgayKhenThuong { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
