using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace linkexample.Models
{
    public class custbillVM
    {
        public Int64 billid { get; set; }
        public DateTime? billdate { get; set; }
        public decimal? billamt { get; set; }
        public string custname { get; set; }
        public Int64 payid { get; set; }
        public decimal? payamout { get; set; }
       
    }
}