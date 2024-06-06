using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelView.Models;

namespace ModelView.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult showmodel()
        {
            emp e = new emp();
            return View(e);
        }
        public ActionResult getmultipleemp()
        {
            var v = emp.getemp();
            return View(v);
        }
    }
}