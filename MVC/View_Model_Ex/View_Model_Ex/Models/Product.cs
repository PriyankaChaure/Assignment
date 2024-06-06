using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View_Model_Ex.Models
{
    public class Product
    {
        public Int64 productid { get; set; }
        public string productname { get; set; }
        public string productmfgname { get; set; }
        public decimal productprice { get; set; }
        public Product()
        {
            this.productid = 1;
            this.productname = "mouse";
            this.productmfgname = "intex";
            this.productprice = 500;
        }
    }
}