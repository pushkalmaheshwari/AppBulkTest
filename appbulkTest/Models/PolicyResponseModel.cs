using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppScanThirdPartyIntegration;

namespace vercodebulktest.Models
{
    public class PolicyResponseModel
    {
        public PolicyResponseModel()
        {
            LastSyncIdentifier = 0;
            policies = new List<AppScanPolicyEntity>();
        }

        public long LastSyncIdentifier { get; set; }

        public List<AppScanPolicyEntity> policies { get; set; }
    }
}