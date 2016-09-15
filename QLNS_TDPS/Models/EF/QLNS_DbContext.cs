namespace QLNS_TDPS.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLNS_DbContext : DbContext
    {
        public QLNS_DbContext()
            : base("name=QLNS_TDPS")
        {
        }

        public virtual DbSet<ChuyenMon> ChuyenMons { get; set; }
        public virtual DbSet<DanToc> DanTocs { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhenThuong> KhenThuongs { get; set; }
        public virtual DbSet<KyLuat> KyLuats { get; set; }
        public virtual DbSet<LoaiNhanThan> LoaiNhanThans { get; set; }
        public virtual DbSet<NgachBac> NgachBacs { get; set; }
        public virtual DbSet<NhanThan> NhanThans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhanVien_ChuyenMon> NhanVien_ChuyenMon { get; set; }
        public virtual DbSet<NhanVien_Ngach> NhanVien_Ngach { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<To> Toes { get; set; }
        public virtual DbSet<TonGiao> TonGiaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuyenMon>()
                .HasMany(e => e.NhanVien_ChuyenMon)
                .WithRequired(e => e.ChuyenMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NgachBac>()
                .Property(e => e.MaNgach)
                .IsUnicode(false);

            modelBuilder.Entity<NgachBac>()
                .HasMany(e => e.NhanVien_Ngach)
                .WithRequired(e => e.NgachBac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DienThoaiDD)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoCMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNgach)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HopDongs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.KhenThuongs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.KyLuats)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.NhanThans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.NhanVien_ChuyenMon)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.NhanVien_Ngach)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.PhanQuyen)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<NhanVien_Ngach>()
                .Property(e => e.MaNgach)
                .IsUnicode(false);

            modelBuilder.Entity<PhanQuyen>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<PhanQuyen>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<To>()
                .Property(e => e.SoDT)
                .IsUnicode(false);

            modelBuilder.Entity<To>()
                .Property(e => e.GhiChu)
                .IsFixedLength();
        }
    }
}
