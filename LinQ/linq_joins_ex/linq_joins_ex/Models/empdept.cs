using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using linq_joins_ex.Models;

namespace linq_joins_ex.Models
{
    public class empdept
    {
        public long? empid { get; set; }
        public string empname { get; set; }
        public string address { get; set; }
        public string emailid { get; set; }
        public string mobileno { get; set; }
        public decimal? salary { get; set; }
        public string deptname { get; set; }
        public string cityname { get; set; }
    }
}