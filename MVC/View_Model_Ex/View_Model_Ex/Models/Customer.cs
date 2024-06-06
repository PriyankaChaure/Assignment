using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_Model_Ex.Models
{
    public class Customer
    {
        public Int64 customerid { get; set; }
        public string customername { get; set; }
        public string customeremailid { get; set; }
        public string customeraddress { get; set; }
        public string customermobileno { get; set; }
        public decimal customercreditlimit { get; set; }
        public Customer()
        {
            this.customerid = 1;
            this.customername = "prachi";
            this.customeremailid = "prachi@gmail.com";
            this.customeraddress = "kamshet,pune";
            this.customermobileno = "987456321";
            this.customercreditlimit = 50000;
        }
    }
}