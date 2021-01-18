using Blog18Ocak2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog18Ocak2021.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();

        public ActionResult Index()
        {
            return View(db.Yazilar.ToList());
        }

        public ActionResult Yazi(int id)
        {
            Yazi yazi = db.Yazilar.Find(id);

            if (yazi == null)
            {
                return HttpNotFound();
            }

            return View(yazi);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}