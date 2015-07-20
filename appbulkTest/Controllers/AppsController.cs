using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using vercodebulktest.Business;
using vercodebulktest.Models;

namespace vercodebulktest.Controllers
{
    public class AppsController : ApiController
    {

        public string Get()
        {
              string s = "apps will come here ";
            return s;
        }


        public object Post([FromBody] AppsRequestModel request)
        {
            try
            {
             //   var jsonSerializer = new JavaScriptSerializer();
               // var request = (AppsRequestModel)jsonSerializer.Deserialize(requestString, typeof(AppsRequestModel));
                var biz = new AppBusiness();
                var result = biz.GetAppScanResult(request);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return  Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        
        }
    }
}
