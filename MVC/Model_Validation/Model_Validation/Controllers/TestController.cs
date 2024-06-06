using Model_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model_Validation.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Customer rec)
        {
            if (ModelState.IsValid)
            {
                //if(rec.creditlimit%2!=0)
                //{
                //    ModelState.AddModelError("creditlimit", "limit should be even");
                //    return View(rec);
                //}
                return View("create");
            }
            else
            {
                return View(rec);
            }
        }
    }
}