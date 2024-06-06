using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using linq_joins_ex.Models;

namespace linq_joins_ex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        PriyankaDBEntities pre = new PriyankaDBEntities();
        public ActionResult Index()
        {
            var v = from t1 in this.pre.emp2
                    join t2 in this.pre.depttable2
                    on t1.deptid equals t2.deptid
                    join t3 in this.pre.cities
                    on t2.cityid equals t3.cityid
                    select new empdept
                    {
                        empid = t1.empid,
                        empname = t1.empname,
                        address = t1.address,
                        emailid = t1.emailid,
                        mobileno = t1.mobileno,
                        salary = t1.salary,
                        deptname = t2.deptname,
                        cityname = t3.cityname
                    };
            return View(v.ToList());

        }
        public ActionResult getjoins()
        {
            //inner join linq-query
            //var v = from t1 in this.pre.atables
            //        join t2 in this.pre.btables
            //        on t1.aid equals t2.aid
            //        select new abclassVM
            //        {
            //            aid=t2.aid,
            //            avalue=t1.avalue,
            //            bid=t2.bid,
            //           bvalue=t2.bvalue                       
            //        };
            //return View(v.ToList());

            //left outer join
            var left = from t1 in this.pre.atables
                       join t2 in this.pre.btables
                       on t1.aid equals t2.aid
                       into g
                       from t2 in g.DefaultIfEmpty()
                       select new abclassVM
                       {
                           aid = t1.aid,
                           avalue = t1.avalue,
                           bid = t2.bid,
                           bvalue = t2.bvalue
                       };
            //return View(left.ToList());

            //right outer join
            var right = from t1 in this.pre.btables
                        join t2 in this.pre.atables
                        on t1.aid equals t2.aid
                        into g
                        from t2 in g.DefaultIfEmpty()
                        select new abclassVM
                        {
                            aid = t2.aid,
                            avalue = t2.avalue,
                            bid = t1.bid,
                            bvalue = t1.bvalue
                        };
            //return View(right.ToList());


            // var v = right.Union(left);
            var v = right.Intersect(left);
            return View(v.ToList());

        }
        public ActionResult getsumary()
        {
            var v = from t1 in this.pre.emp2
                    join t2 in this.pre.depttable2
                    on t1.deptid equals t2.deptid
                    join t3 in this.pre.cities
                    on t2.cityid equals t3.cityid
                    group t1 by t3.cityname
                   into g
                    select new empdept
                    {
                        cityname = g.Key,
                       salary =g.Sum(pre=>pre.salary),

                       
                   };

            return View(v.ToList());

        }

    }
}