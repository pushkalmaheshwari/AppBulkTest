using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vercodebulktest.Models;

namespace vercodebulktest.Business
{
    public class AppBusiness
    {
        public object GetAppScanResult(AppsRequestModel request)
        {
            var appResponse = new AppsResponseModel();

            {
                foreach (var appnode in request.apps)
                {
                    var appModel = new ThirdPartyAppResponse
                    {
                        applicationId = appnode.applicationId,
                        buildVersion = appnode.buildVersion,
                        version = appnode.version,
                        platform = appnode.platform,
                        versionCode = appnode.versionCode
                    };
                    appResponse.apps.Add(appModel);
                }
                return appResponse;
            }
        }

    }
}

