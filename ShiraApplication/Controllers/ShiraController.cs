using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShiraApplication.Controllers
{
    public class ShiraController : Controller
    {
        [NonAction]
        public static string GetLoggedInUser()
        {
            return "Manager User";
        }
    }
}