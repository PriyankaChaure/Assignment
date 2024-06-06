using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB_First.Models;

namespace DB_First.Controllers
{
    public class TestController : Controller
    {
        PriyankaDBEntities pe = new PriyankaDBEntities();
        // GET: Test
        public ActionResult Index()
        {
            
            //return View(pe.bills.ToList());
            var v= from t in pe.bills
                   where t.billamt>=15000
                   select t;
            return View(v.ToList());
        }
    }
}