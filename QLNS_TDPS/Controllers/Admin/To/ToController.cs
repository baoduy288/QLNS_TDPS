using QLNS_TDPS.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNS_TDPS.Controllers.Admin.To
{
    public class ToController : Controller
    {
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            var dao = new ToDao();
            var model = dao.ListAllPaging(page, pageSize);

            return View(model);
        }
        // GET: To
        //public ActionResult Index(string searchString, int page = 1, int pageSize = 5) 
        //{
        //    var dao = new ToDao();
        //    var model = dao.ListAllPaging(searchString, page, pageSize);
        //    ViewBag.SearchString = searchString;
        //    return View(model);
        //}

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.To to)
        {
            if (ModelState.IsValid)
            {
                var dao = new ToDao();
                int maTo = dao.Insert(to);
                if (maTo > 0)
                {
                    return RedirectToAction("Index", "To");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm tổ không thành công!");
                }
            }
            return View("Index");
        }
    }
}