namespace QLNS_TDPS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HopDongs = new HashSet<HopDong>();
            KhenThuongs = new HashSet<KhenThuong>();
            KyLuats = new HashSet<KyLuat>();
            NhanThans = new HashSet<NhanThan>();
            NhanVien_ChuyenMon = new HashSet<NhanVien_ChuyenMon>();
            NhanVien_Ngach = new HashSet<NhanVien_Ngach>();
        }

        [Key]
        public int MaNV { get; set; }

        [StringLength(50)]
        public string HoLotNV { get; set; }

        [StringLength(20)]
        public string TenNV { get; set; }

        public bool GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string NoiSinh { get; set; }

        [StringLength(255)]
        public string ThuongTru { get; set; }

        [StringLength(255)]
        public string TamTru { get; set; }

        [StringLength(15)]
        public string DienThoai { get; set; }

        [StringLength(15)]
        public string DienThoaiDD { get; set; }

        [StringLength(9)]
        public string SoCMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapCMND { get; set; }

        [StringLength(30)]
        public string NoiCapCMND { get; set; }

        [StringLength(50)]
        public string NguyenQuan { get; set; }

        [StringLength(20)]
        public string TinhTrangHonNhan { get; set; }

        [StringLength(50)]
        public string QuocTich { get; set; }

        public int? MaDanToc { get; set; }

        public int? MaTonGiao { get; set; }

        public int? MaTo { get; set; }

        [StringLength(10)]
        public string MaNgach { get; set; }

        public virtual DanToc DanToc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhenThuong> KhenThuongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KyLuat> KyLuats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanThan> NhanThans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien_ChuyenMon> NhanVien_ChuyenMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien_Ngach> NhanVien_Ngach { get; set; }

        public virtual To To { get; set; }

        public virtual TonGiao TonGiao { get; set; }

        public virtual PhanQuyen PhanQuyen { get; set; }

        //Hàm này nhiệm vụ là cắt phần thời gian chỉ còn để lại phần ngày tháng năm.
        //Giá trị được trả về kiểu string
        public string TimeSetting(DateTime? date)
        {
            if (date != null)
            {
                var _NewDate = date.Value.ToShortDateString();
                return _NewDate;
            }
            return "";
        }
    }
}
