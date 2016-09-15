using QLNS_TDPS.Models.DAO;
using System.Web.Mvc;

namespace QLNS_TDPS.Controllers.Admin.NhanVien
{
    public class NhanVienController : BaseController
    {
        
        // GET: NhanVien
        public ActionResult Index(string searchString, int page = 1, int pageSize = 5)
        {
            var dao = new NhanVienDao();
            var model = dao.ListAllPaging(searchString, page, pageSize);

            ViewBag.SearchString = searchString;
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var nv = new NhanVienDao().ViewDetail(id);
            return View(nv);
        }

        [HttpPost]
        public ActionResult Create(Models.NhanVien nv)
        {
            if(ModelState.IsValid)
            {
                var dao = new NhanVienDao();
                int manv = dao.Insert(nv);
                if (manv > 0)
                {
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm nhân viên không thành công!");
                }
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult Edit(Models.NhanVien nv)
        {
            if(ModelState.IsValid)
            {
                var dao = new NhanVienDao();
                bool result = dao.Update(nv);
                if(result)
                {
                    //var model = dao.ListAllPaging(page, pageSize);
                    //return View("Index", model);
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật nhân viên không thành công!");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new NhanVienDao().Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult DetailNhanVien(int id)
        {
            var nv = new NhanVienDao().ViewDetail(id);
            return View(nv);
        }
    }
}