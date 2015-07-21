using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace vercodebulktest.Models
{
    public class AppsResponseModel
    {
        public List<ThirdPartyAppResponse> apps;
        public AppsResponseModel()
        {
             apps = new List<ThirdPartyAppResponse>();
        }

    }

    public class AppsRequestModel
    {
        public List<ThirdPartyAppRequest> apps;
        public string callbackUri;

        public AppsRequestModel()
        {
           apps = new List<ThirdPartyAppRequest>();
        }
    }

    public class ThirdPartyAppRequest
    {

        #region Properties


        public string applicationId { get; set; }

        public string platform { get; set; }

        public string version { get; set; }

        public string versionCode { get; set; }

        public string buildVersion { get; set; }

        public ThirdPartyAppRequest()
        {
            applicationId = string.Empty;
            platform = string.Empty;
            version = string.Empty;
            versionCode = string.Empty;
            buildVersion = string.Empty;
        }

        #endregion

    }

    public class ThirdPartyAppResponse : ThirdPartyAppRequest
    {
        public ThirdPartyAppResponse():base()
        {
            blacklist = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" ,"10","11"};
            scanned = true;
        }

        public string[] blacklist { get; set; }

        public string[] whitelist { get; set; }

        public bool scanned { get; set; }

    }
}