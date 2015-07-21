using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppScanThirdPartyIntegration;
using vercodebulktest.Business;

namespace vercodebulktest.Controllers
{
    public class PoliciesController : ApiController
    {

        public object Get()
        {
            var biz = new PolicyBusines();
            return biz.GetAllPolicies();
        } 
        
        public object Post([FromBody]string value)
        {
            var biz = new PolicyBusines();
            return  biz.GetAllPolicies();
        }

    }
}
