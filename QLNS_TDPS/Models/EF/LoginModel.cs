using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLNS_TDPS.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập Tên Đăng Nhập")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Mật Khẩu")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}