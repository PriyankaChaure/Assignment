using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas_Example.Areas.MarketingArea.Controllers
{
    public class MarketingControController : Controller
    {
        // GET: MarketingArea/MarketingContro
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MarketingIndex()
        {
            return View();
        }
        public ActionResult MarketingAbout()
        {
            return View();
        }


    }
}