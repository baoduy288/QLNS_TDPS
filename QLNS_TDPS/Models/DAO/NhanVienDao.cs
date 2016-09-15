using System.Collections.Generic;
using System.Linq;
using PagedList;
using QLNS_TDPS.Models;
using System;

namespace QLNS_TDPS.Models.DAO
{
    public class NhanVienDao
    {
        QLNS_DbContext db = null;
        public NhanVienDao()
        {
            db = new QLNS_DbContext();
        }

        public int Insert(NhanVien entity)
        {
            db.NhanViens.Add(entity);
            db.SaveChanges();
            return entity.MaNV;
        }

        public bool Update(NhanVien entity)
        {
            try
            {
                var nhanVien = db.NhanViens.Find(entity.MaNV);

                nhanVien.HoLotNV = entity.HoLotNV;
                nhanVien.TenNV = entity.TenNV;
                nhanVien.GioiTinh = entity.GioiTinh;
                nhanVien.NgaySinh = entity.NgaySinh;
                nhanVien.NguyenQuan = entity.NguyenQuan;
                nhanVien.TamTru = entity.TamTru;
                nhanVien.ThuongTru = entity.ThuongTru;
                nhanVien.SoCMND = entity.SoCMND;
                nhanVien.NoiCapCMND = entity.NoiCapCMND;
                nhanVien.NgayCapCMND = entity.NgayCapCMND;
                nhanVien.NoiSinh = entity.NoiSinh;
                nhanVien.QuocTich = entity.QuocTich;
                nhanVien.DienThoai = entity.DienThoai;
                nhanVien.DienThoaiDD = entity.DienThoaiDD;
                nhanVien.TinhTrangHonNhan = entity.TinhTrangHonNhan;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id) 
        {
            try
            {
                var user = db.NhanViens.Find(id);
                db.NhanViens.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<NhanVien> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<NhanVien> model = db.NhanViens;
            if(!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.TenNV.Contains(searchString) || x.HoLotNV.Contains(searchString));
            }
            return model.OrderBy(x => x.MaNV).ToPagedList(page, pageSize);
        }

        public NhanVien ViewDetail(int manv)
        {
            return db.NhanViens.Find(manv);
        }
    }
}