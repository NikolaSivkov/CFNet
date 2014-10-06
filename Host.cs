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
using RestSharp.Deserializers;

namespace CFNET
{
    /// <summary>
    /// 
    /// </summary>
    public class Host
    {
        private RestClient _client;

        /// <summary>
        /// Class to help interact with cloudflare
        /// </summary>
        /// <param name="hostKey">Provided to you by cloudflare</param>
        public Host(string hostKey)
        {
            HostKey = hostKey;
            _client = new RestClient(ApiUri);
        }

        #region properties

        public static string ApiUri = "https://api.cloudflare.com/host-gw.html";

        public string HostKey { get; set; }

        #endregion

        #region Actions

        public RequestResult<CreateUserResponse> CreateUser(CreateUserReqest user)
        {
            var request = new RestRequest(Method.POST);

            foreach (var param in user.ToParams())
            {
                request.AddParameter(param.Key, param.Value);
            }

            return Execute<RequestResult<CreateUserResponse>>(request);
        }

        public RequestResult<UsersLookupResponse> UserLookup(string uniqueId)
        {
            const string act = "user_lookup";
            var request = new RestRequest(Method.POST);

            request.AddParameter("act", act);
            request.AddParameter("unique_id", uniqueId);

            return Execute<RequestResult<UsersLookupResponse>>(request);
        }

        public RequestResult<SetZoneResponse> SetZone(SetZoneRequest zone)
        {
            var request = new RestRequest(Method.POST);

            foreach (var param in zone.ToParams())
            {
                request.AddParameter(param.Key, param.Value);
            }

            return Execute<RequestResult<SetZoneResponse>>(request);
        }

        public RequestResult<ZoneDeleteResponse> DeleteZone(string zone, string userKey)
        {
            var request = new RestRequest(Method.POST);


            request.AddParameter("act", "zone_delete");
            request.AddParameter("zone_name", zone);
            request.AddParameter("user_key", userKey);
            return Execute<RequestResult<ZoneDeleteResponse>>(request);
        }

        public RequestResult<List<ZoneListResponse>> ZoneList()
        {
            var request = new RestRequest(Method.POST);

            request.AddParameter("act", "zone_list");

            return Execute<RequestResult<List<ZoneListResponse>>>(request);
        }

        public RequestResult<List<ZoneLookupResponse>> ZoneLookUp(string zone, string userKey)
        {
            var request = new RestRequest(Method.POST);
            request.AddParameter("zone_name", zone);
            request.AddParameter("user_key", userKey);
            request.AddParameter("act", "zone_lookup");
            return Execute<RequestResult<List<ZoneLookupResponse>>>(request);
        }
        
        #endregion

        private T Execute<T>(RestRequest request) where T : new()
        {

            request.AddParameter("host_key", HostKey); // used on every request
            var response = _client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

    }
}
