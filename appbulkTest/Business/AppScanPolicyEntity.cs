using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppScanThirdPartyIntegration
{
    public class AppScanPolicyEntity 
    {
        /// <summary>
        ///     Default constructor
        /// </summary>
        /// 

        public AppScanPolicyEntity()
        {
            id = String.Empty;
            name = String.Empty;
            description = String.Empty;
            affectedApps = new List<AppScanPolicyAppEntity>();
        }
        public string id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public List<AppScanPolicyAppEntity> affectedApps { get; set; }
    }


    public class AppScanPolicyAppEntity
    {
        public string platform { get; set; }

        public int count { get; set; }
    }
}
