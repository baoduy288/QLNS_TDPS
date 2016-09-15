using QLNS_TDPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLNS_TDPS.Models.DAO
{
    public class PhanQuyenDao
    {
        QLNS_DbContext db = null;
        public PhanQuyenDao()
        {
            db = new QLNS_DbContext();
        }

        //Trả về object gồm các giá trị cần lấy theo username
        public PhanQuyen GetById(string userName)
        {
            return db.PhanQuyens.SingleOrDefault(x => x.UserName == userName);
        }

        public int Login(string userName, string password)
        {
            var result = db.PhanQuyens.SingleOrDefault(x => x.UserName == userName);
            if (result == null) return 0; // Tài khoản không tồn tại.
            else
            {
                if (result.Password == password) return 1; //Đăng nhập thành công
                else return -1; //Sai mật khẩu
            }
        }
    }
}