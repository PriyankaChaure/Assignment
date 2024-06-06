using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionToView.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //view bag
        public ActionResult Index()
        {
            ViewBag.EmpId = 1;
            ViewBag.EmpName = "prachi";
            ViewBag.DeptName = "computer";
            ViewBag.Salary = 15000;
            //  return View(); 
            return RedirectToAction("gotoviewbag");
        }
        public ActionResult gotoviewbag()
        {
            return View();
        }
        //view data
        public ActionResult getviewdata()
        {
            ViewData["proid"]=1;
            ViewData["proname"] = "abc";
            ViewData["cityname"] = "pune";
            ViewData["budget"] = 10000;
            //return View();
            return RedirectToAction("gotoviewdata");
        }
        public ActionResult gotoviewdata()
        {
            return View();
        }
        //temp data
        public ActionResult gettempdata()
        {
            TempData["custid"] = 1;
             TempData["custname"] = "priya";
            TempData["address"] = "pune";
            TempData["emailid"] = "priya@gmail.com";
            TempData["mobileno"] = "5675854613";
            TempData["creditlimit"] = 60000;
           // return View();
            return RedirectToAction("gototempdata");
        }
        public ActionResult gototempdata()
        {
            return View();
        }
    }
}