using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_Binding_Ex.Models;

namespace Model_Binding_Ex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create([Bind(Exclude="CustomerCreditLimit,CustomerAddress")]Customer rec)
        {
            return View();
        }
    }
}