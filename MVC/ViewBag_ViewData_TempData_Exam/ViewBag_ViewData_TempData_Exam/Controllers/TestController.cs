using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_ViewData_TempData_Exam.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            

            ViewBag.CourseId = 1;
            ViewBag.CourseName = "C#";
            ViewBag.Duration = 5;
            ViewBag.Fees = 45000;
        
    
            TempData["BookId"] = 1;
            TempData["BookName"] = "Inside Object";
            TempData["AuthorName"] = "Scott Allen";
            TempData["Price"] = 450;

            ViewData["DeviceId"] = 1;
            ViewData["DeviceName"] = "Printer";
            ViewData["MfgName"] = "Canon";
            ViewData["Price"] = 45000;
         
            return View();
        }
    }
}