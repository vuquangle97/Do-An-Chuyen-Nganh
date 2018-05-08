using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanDienThoai.Models;
namespace BanDienThoai.Controllers
{
    public class DienThoaiMoiController : Controller
    {
        // GET: DienThoaiMoi
        WebsiteBanHangEntities db = new WebsiteBanHangEntities();
        public PartialViewResult DienThoaiMoiPartial()
        {
            var listDienThoaiMoi = db.SanPhams.Take(3).ToList();
            return PartialView(listDienThoaiMoi);
        }
    }
}