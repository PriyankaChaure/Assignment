using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Binding_Ex.Models
{
    public class Customer
    {
        public Int64 CustomerId{ get;set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmailId { get; set; }
        public string CustomerMobileNo { get; set; }
        public decimal CustomerCreditLimit{ get; set; }
    }
}