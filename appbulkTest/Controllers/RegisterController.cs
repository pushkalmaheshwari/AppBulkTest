using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace vercodebulktest.Controllers
{
    public class RegisterController : ApiController
    {
        // POST api/values
        public object Post([FromBody]string value)
        {
             var retval = "hello i am post of register";
            return retval;
        }

        // POST api/values
        public object GET()
        {
            var retval = "hello i am get of register";
            return retval;
        }
    }
}
