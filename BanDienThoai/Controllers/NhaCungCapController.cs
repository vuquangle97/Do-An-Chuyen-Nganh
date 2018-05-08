using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanDienThoai.Models;

namespace BanDienThoai.Controllers
{
    public class NhaCungCapController : Controller
    {
        WebsiteBanHangEntities db = new WebsiteBanHangEntities();
        // GET: NhaCungCap
        public ActionResult NhaCungCapPartial()
        {
            return PartialView(db.NhaCungCaps.Take(5).ToList());
        }
    }
}