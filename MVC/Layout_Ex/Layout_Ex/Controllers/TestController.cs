using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout_Ex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }
        public ActionResult signup()
        {
            return View();
        }
        public ActionResult signin()
        {
            return View();
        }
    }
}