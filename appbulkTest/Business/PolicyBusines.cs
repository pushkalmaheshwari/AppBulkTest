﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppScanThirdPartyIntegration;
using vercodebulktest.Models;

namespace vercodebulktest.Business
{
    public class PolicyBusines
    {
        const int Vendorid = 2;
        public object GetAllPolicies()
        {
            
            var listOfPolicies = new  PolicyResponseModel();
            listOfPolicies.LastSyncIdentifier = DateTime.UtcNow.Ticks;

            for(int count =1;count<=10;count++)
            {

                var policyentity = new AppScanPolicyEntity();
                policyentity.name = count.ToString();
                policyentity.id = count.ToString(); ;
                policyentity.description = "Test Policy " + count;

                var affectedApps = new AppScanPolicyAppEntity();
                affectedApps.platform = "ios";
                affectedApps.count = 10;
                
                policyentity.affectedApps.Add(affectedApps);

                listOfPolicies.policies.Add(policyentity);
            }

            return listOfPolicies;
        }
    }
}