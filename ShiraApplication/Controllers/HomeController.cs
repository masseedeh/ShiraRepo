using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShiraApplication.Controllers
{
    public class HomeController : Controller
    {
        ShiraEntities db = new ShiraEntities();
        public ActionResult Index()
        {
            var x = db.LanguageDictionary.Count();
            return View();
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
    }
}