using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Curd_operations.Models;

namespace Curd_operations.Controllers
{
    public class TestController : Controller
    {
        PriyankaDBEntities pr = new PriyankaDBEntities();
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.deptid = new SelectList(this.pr.depttable2.ToList(), "deptid", "deptname");
            var v = this.pr.emp2.ToList();
           
            return View(v.ToList());
        }
        public ActionResult searchbyname(string empname)
        {
            ViewBag.deptid = new SelectList(this.pr.depttable2.ToList(), "deptid", "deptname");
            if (empname=="")
            {
                return View("Index",this.pr.emp2.ToList());
            }
           else
            {
                var v = from t in this.pr.emp2
                        where t.empname.StartsWith(empname)
                        select t;
                return View("Index", v.ToList());
            }
        }
        public ActionResult searchbydept(Int64 deptid=0)
        {
            ViewBag.deptid = new SelectList(this.pr.depttable2.ToList(), "deptid", "deptname");
            if (deptid==0)
            {
                return View("Index", this.pr.emp2.ToList());
            }
            else
            {
                var rec = this.pr.emp2.Where(p => p.deptid == deptid);
                return View("Index",rec.ToList());
            }
        }
        [HttpGet]
        public ActionResult create()
        {
            ViewBag.deptid = new SelectList(this.pr.depttable2.ToList(), "deptid", "deptname");
            return View();
        }
        [HttpPost]
        public ActionResult create(emp2 record)
        {
            //ViewBag.depts = new SelectList(this.pr.depttable2.ToList(), "deptid", "deptname");
            this.pr.emp2.Add(record);
            this.pr.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult editdata(Int64 id)
        {
            var rec = this.pr.emp2.SingleOrDefault(p => p.empid == id);
            ViewBag.deptid = new SelectList(this.pr.depttable2.ToList(), "deptid", "deptname",rec.deptid);
            return View(rec);
        }
        [HttpPost]
        public ActionResult editdata(emp2 rec)
        {
            var oldrec = this.pr.emp2.SingleOrDefault(p => p.empid == rec.empid);
            ViewBag.deptid = new SelectList(this.pr.depttable2.ToList(), "deptid", "deptname", rec.deptid);
            oldrec.empname = rec.empname;
            oldrec.emailid = rec.emailid;
            oldrec.address = rec.address;
            oldrec.mobileno = rec.mobileno;
            oldrec.salary = rec.salary;
            oldrec.deptid = rec.deptid;
            this.pr.SaveChanges();
            return RedirectToAction("Index");
            //this.pr.Entry(rec).State = System.Data.Entity.EntityState.Modified;
        }
        [HttpGet]
        public ActionResult delete(int id)
        {
            var rec=this.pr.emp2.Find(id);
            this.pr.emp2.Remove(rec);
            this.pr.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}