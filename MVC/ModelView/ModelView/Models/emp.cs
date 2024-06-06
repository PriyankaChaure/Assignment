using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelView.Models
{
    public class emp
    {
        public Int64 empid { get; set; }
        public string empname { get; set; }
        public string empdept { get; set; }
        public string empmobile { get; set; }
        public Int64 empsalary { get; set; }
        public emp()
        {
            this.empid = 1;
            this.empname = "priyanka";
            this.empdept = "computer";
            this.empmobile = "9874563210";
            this.empsalary = 50000;
        }
        public  static List<emp>getemp()
        {
            List<emp> lst = new List<emp>();
            lst.Add(new emp { empid = 1, empname = "priyanka", empdept = "computer", empmobile = "934354656733", empsalary = 50000 });
            lst.Add(new emp { empid = 2, empname = "prachi", empdept = "IT", empmobile = "986354615733", empsalary = 55000 });
            lst.Add(new emp { empid = 3, empname = "sweety", empdept = "sales", empmobile = "321354656733", empsalary = 60000 });
            lst.Add(new emp { empid = 4, empname = "guddi", empdept = "purchase", empmobile = "7344564656733", empsalary = 65000 });
            lst.Add(new emp { empid = 5, empname = "vishakha", empdept = "entc", empmobile = "963354656733", empsalary = 70000 });
            lst.Add(new emp { empid = 6, empname = "nishu", empdept = "civil", empmobile = "129754656733", empsalary = 75000 });
            lst.Add(new emp { empid = 7, empname = "sonali", empdept = "mechanical", empmobile = "912354656733", empsalary = 80000 });
            lst.Add(new emp { empid = 8, empname = "shweta", empdept = "electric", empmobile = "904354656733", empsalary = 85000 });
            lst.Add(new emp { empid = 9, empname = "shital", empdept = "chemical", empmobile = "944354656733", empsalary = 90000 });
            lst.Add(new emp { empid = 10, empname = "neha", empdept = "musical", empmobile = "994354656733", empsalary = 95000 });
            return lst; 
        }
    }
}