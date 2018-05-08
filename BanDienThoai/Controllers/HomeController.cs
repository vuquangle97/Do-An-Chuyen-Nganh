using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanDienThoai.Models;
namespace BanDienThoai.Controllers
{
    public class HomeController : Controller
    {
        WebsiteBanHangEntities db = new WebsiteBanHangEntities();
        public ActionResult Index()
        {
            return View(db.SanPhams.Where(e=>e.Moi==1).ToList());
        }
    }
}