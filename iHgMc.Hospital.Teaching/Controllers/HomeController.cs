using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHgMc.Hospital.Teaching.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var result = 0;
            var x = 1;
            var y = 0;
            result = x / y;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}