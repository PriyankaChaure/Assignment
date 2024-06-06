using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstapplication_demo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string SayHello()
        {
            return "say hello called!!!";
        }
        public string Saybye()
        {
            return "say bye called!!!";
        }
        public string foo()
        {
            return "foo called!!!";
        }
    }
}