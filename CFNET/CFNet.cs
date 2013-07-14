using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CFNET.Models;
using Newtonsoft;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using RestSharp;

namespace CFNET
{
    public class CFNet
    {
        private RestClient _CFC;

        public CFNet(string hostKey)
        {
            HostKey = hostKey;
            _CFC = new RestClient(ApiUri);
        }

        #region properties

        public static string ApiUri = "https://api.cloudflare.com/host-gw.html";

        public string HostKey { get; set; }

        #endregion

        #region Actions

        public CFResponse CreateUser(CFUser user)
        {
            var request = new RestRequest(Method.POST);

            foreach (var param in user.ToParams())
            {
                request.AddParameter(param.Key, param.Value);
            }

            return Execute<CFResponse>(request);
        }

        public CFResponse UserLookup(string unique_id)
        {
            const string act = "user_lookup";
            var request = new RestRequest(Method.POST);

            request.AddParameter("act", act);
            request.AddParameter("unique_id", unique_id);

            return Execute<CFResponse>(request);
        }

        public CFResponse SetZone(CFZone zone)
        {
            var request = new RestRequest(Method.POST);

            foreach (var param in zone.ToParams())
            {
                request.AddParameter(param.Key, param.Value);
            }

            return Execute<CFResponse>(request);
        }

        public CFResponse ZoneList()
        {
            var request = new RestRequest(Method.POST);


            request.AddParameter("act", "zone_list");


            return Execute<CFResponse>(request);
        }


        #endregion

        private T Execute<T>(RestRequest request) where T : new()
        {

            request.AddParameter("host_key", HostKey); // used on every request
            var response = _CFC.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

    }

}
