using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_Model_Ex.Models
{
    public class CustEmpProVM
    {
        public Int64 customerid { get; set; }
        public string customername { get; set; }
        public string customeremailid { get; set; }
        public string customeraddress { get; set; }
        public string customermobileno { get; set; }
        public decimal customercreditlimit { get; set; }


        public Int64 employeeid { get; set; }
        public string employeename { get; set; }
        public string employeedeptname { get; set; }
        public string employeeemailid { get; set; }
        public string employeeaddress { get; set; }
        public string employeemobileno { get; set; }
        public decimal employeesalary { get; set; }


        public Int64 productid { get; set; }
        public string productname { get; set; }
        public string productmfgname { get; set; }
        public decimal productprice { get; set; }


    }
}