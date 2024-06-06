using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace view_action_return_type.Controllers
{
    public class ABCController : Controller
    {
        // GET: ABC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getcommon()
        {
            return View("_commonview");  
        }
    }
}