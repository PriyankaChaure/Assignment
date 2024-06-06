using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using view_model_bookex.Models;

namespace view_model_bookex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult getmultiplebook()
        {
            var v = book.getmultiplebook();
            return View(v);
        }
    }
}