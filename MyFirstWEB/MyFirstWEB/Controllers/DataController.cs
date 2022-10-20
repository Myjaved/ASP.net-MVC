using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWEB.Controllers
{
    public class DataController : ApiController
    {
        public string[] MyEmployee = { "Adil", "Asad", "Ali", "Zain" };
        [HttpGet]
        public string[] GetEmployee()
        {
            return MyEmployee;
        }
    }
}
