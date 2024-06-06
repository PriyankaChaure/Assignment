using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_Model_Ex.Models
{
    public class Employee
    {
        public Int64 employeeid { get; set; }
        public string employeename { get; set; }
        public string employeedeptname { get; set; }
        public string employeeemailid { get; set; }
        public string employeeaddress { get; set; }
        public string employeemobileno { get; set; }
        public decimal employeesalary { get; set; }
        public Employee()
        {
            this.employeeid = 1;
            this.employeename = "priyanka";
            this.employeedeptname = "computer";
            this.employeeemailid = "priya@gmail.com";
            this.employeeaddress = "mangalwar peth,pune";
            this.employeemobileno = "99999999999";
            this.employeesalary = 80000;
        }
    }
}