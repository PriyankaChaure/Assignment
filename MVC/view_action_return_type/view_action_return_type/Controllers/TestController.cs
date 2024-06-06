using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace view_action_return_type.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show()
        {
            return View("demo");
        }
        public ActionResult showcommon() 
        {
            return View("_commonview");
        }
    }
}