using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Model_Ex.Models;

namespace View_Model_Ex.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Employee e = new Employee();
            Product p = new Product();
            Customer c=new Customer();
            CustEmpProVM vm=new CustEmpProVM();
            vm.customerid = c.customerid;
            vm.customername = c.customername;
            vm.customeremailid = c.customeremailid;
            vm.customeraddress = c.customeraddress;
            vm.customermobileno = c.customermobileno;
            vm.customercreditlimit = c.customercreditlimit;

            vm.employeeid = e.employeeid;
            vm.employeename = e.employeename;
            vm.employeedeptname = e.employeedeptname;
            vm.employeeemailid = e.employeeemailid;
            vm.employeeaddress = e.employeeaddress;
            vm.employeemobileno = e.employeemobileno;
            vm.employeesalary = e.employeesalary;

            vm.productid = p.productid;
            vm.productname = p.productname;
            vm.productmfgname = p.productmfgname;
            vm.productprice = p.productprice;

            return View(vm);
        }
    }
}