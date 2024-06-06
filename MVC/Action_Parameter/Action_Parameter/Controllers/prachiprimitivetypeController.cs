using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_Parameter.Controllers
{
    public class prachiprimitivetypeController : Controller
    {
        // GET: prachiprimitivetype
        public string SayHello(String id)
        {
            return "value of id is:"+id ;
        }

        public string saybye(int id=10)
        {
            return "value of id is:" + id;
        }
        public string foo(string id,string str)
        {
            return "value of id is:" + id + "value of str is:" + str;
        }
        public int dodivision(int a,int b)
        {
            return a / b;
        }

    }
}