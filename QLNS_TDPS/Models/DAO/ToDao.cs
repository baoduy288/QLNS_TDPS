using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace QLNS_TDPS.Models.DAO
{
    public class ToDao
    {
        QLNS_DbContext db = null;

        public ToDao()
        {
            db = new QLNS_DbContext();
        }

        public IEnumerable<To> ListAllPaging(int page, int pageSize)
        {
            return db.Toes.OrderBy(x => x.MaTo).ToPagedList(page, pageSize);
        }

        //public IEnumerable<To> ListAllPaging(string searchString, int page, int pageSize)
        //{
        //    IQueryable<To> model = db.Toes;
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        model = model.Where(x => x.TenTo.Contains(searchString));
        //    }
        //    return model.OrderBy(x => x.MaTo).ToPagedList(page, pageSize);
        //}

        public int Insert(To entity)
        {
            db.Toes.Add(entity);
            db.SaveChanges();
            return entity.MaTo;
        }
    }
}