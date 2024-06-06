using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas_Example.Areas.PurchaseArea.Controllers
{
    public class PurchaseControController : Controller
    {
        // GET: PurchaseArea/PurchaseContro
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PurchaseIndex()
        {
            return View();
        }
    }
}