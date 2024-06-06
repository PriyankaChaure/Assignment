using linkexample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using linkexample.Models;

namespace linkexample.Controllers
{
    public class TestController : Controller
    {
        PriyankaDBEntities pe = new PriyankaDBEntities();
        // GET: Test
        public ActionResult Index()
        {
            // var v = from t in this.pe.bills
            //        select t;
            //return View(v.ToList());



            //var v = from t1 in this.pe.bills
            //        join t2 in this.pe.custtables
            //        on t1.custid equals t2.custid
            //        select new custbillVM
            //        { 
            //           billid= t1.billid,
            //            billdate =t1.billdate,
            //           billamt= t1.billamt,
            //            custname= t2.custname
            //        };
            //    return View(v.ToList());

            var v = from t1 in this.pe.bills
                   join t2 in this.pe.custtables
                    on t1.custid equals t2.custid
                    join t3 in this.pe.payments
                    on t1.billid equals t3.billid
                    select new custbillVM
                    { 
                       billid= t1.billid,
                        billdate =t1.billdate,
                       billamt= t1.billamt,
                        custname= t2.custname,
                        payid=t3.payid,
                        payamout=t3.payamout
                    };
            return View(v.ToList());
        }
    }
}