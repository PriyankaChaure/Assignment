using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Templated_Helpers.Models;

namespace Templated_Helpers.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult templatedhelpers()
        {
            customer ch = new customer() { customerid = "1", customername = "priya", customermobileno = "9874563210" };
            return View(ch);
        }
    }
}