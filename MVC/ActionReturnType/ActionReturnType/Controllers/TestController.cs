using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionReturnType.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        //redirect return type
        public RedirectResult gotoritech()
        {
            return Redirect( "http://www.ritechpune.com");
        }
        //redirect to route result
        public string sayhello()
        {
            return "say hello of test controller called!!!";
        }
        public RedirectToRouteResult gotosayhello()
        {
            // return RedirectToAction("sayhello");
            // return RedirectToAction("sayhello", "Abcd");
            return RedirectToAction("sayhello", "Abcd", 15);
        }
        
        //content result
        public ContentResult getcontent()
        {
             string str = "<script type='text/javascript'>alert('hello');</script>";
             return Content(str, "text/javascript", System.Text.Encoding.ASCII);
        }
        //empty result
        public EmptyResult getempty()
        {
            // return null;
            return new EmptyResult();
        }
        //file result
        public FileResult getfile()
        {
            return File("~/Content/Site.css", "text/css");
        }
        //json result
        public JsonResult getjson()
        {
            var v = new { productid = 1, productname = "mouse", productmfg = "dell", productprice = 5000 };
            return Json(v,JsonRequestBehavior.AllowGet);
        }

    }
}