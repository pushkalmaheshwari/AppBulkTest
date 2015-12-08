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

                if (request.apps.Count > 1)
                {
                    var app = request.apps[0];

                    var appModel = new ThirdPartyAppResponse
                    {
                        applicationId = app.applicationId,
                        buildVersion = app.buildVersion,
                        version = app.version,
                        platform = app.platform,
                        versionCode = app.versionCode
                    };
                    appResponse.apps.Add(appModel);
                    
                }

                return appResponse;
            }
        }

    }
}

