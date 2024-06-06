using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas_Example.Areas.SalesArea.Controllers
{
    public class SalesControController : Controller
    {
        // GET: SalesArea/SalesContro
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SalesIndex()
        {
            return View();
        }
    }
}