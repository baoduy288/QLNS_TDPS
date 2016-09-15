using QLNS_MVC.Common;
using QLNS_TDPS.Common;
using QLNS_TDPS.Models;
using QLNS_TDPS.Models.DAO;
using System.Web.Mvc;

namespace QLNS_TDPS.Controllers.Admin
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new PhanQuyenDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.MaNV = user.MaNV;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Admin");
                }
                else if (result == 0)
                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                else
                    ModelState.AddModelError("", "Mật khẩu không đúng.");
            }
            return View("Index");
        }
    }
}