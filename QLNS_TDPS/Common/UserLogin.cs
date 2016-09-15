using System;

namespace QLNS_MVC.Common
{
    [Serializable]
    public class UserLogin
    {
        public int MaNV { get; set; }
        public string UserName { get; set; }
    }
}