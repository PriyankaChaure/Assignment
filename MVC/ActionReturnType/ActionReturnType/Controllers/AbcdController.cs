using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionReturnType.Controllers
{
    public class AbcdController : Controller
    {
        // GET: Abcd
        public ActionResult Index()
        {
            return View();
        }
        //redirect to route result
        public string sayhello()
        {
            return "say hello of abcd controller callled!!!";
        }
        [HttpGet]
        public string sayhello( string id)
        {
            return "say hello 2 of abcd controller called!!!";
        }
    }
}