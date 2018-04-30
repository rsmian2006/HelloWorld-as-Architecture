using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorld
{
    public class HelloWorldController : ApiController
    {
        //GET api/HelloWord
        public string Get()
        {
            return "Hello World";
        }
    }
}