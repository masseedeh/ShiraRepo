using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShiraApplication.Controllers
{
    public class HomeController : ShiraController
    {
        ShiraEntities db = new ShiraEntities();
        public ActionResult Index()
        {
            var x = db.Company.ToList();
            //var user=GetLoggedInUser();            
            return View();
        }

        public ActionResult About()
        {         
            ViewBag.Message = " application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}