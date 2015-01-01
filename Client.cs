using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFNET.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CFNET
{
    public class Client
    {
        private RestClient _client;

        #region properties

        public static string ApiUri = "https://www.cloudflare.com/api_json.html";
        public string ClientApiKey { get; set; }
        public string ClientEmail { get; set; }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientApiKey">This is the API key made available on your Account page.</param>
        /// <param name="clientEmail">The e-mail address associated with the API key</param>
        public Client(string clientApiKey, string clientEmail)
        {
            ClientApiKey = clientApiKey;
            ClientEmail = clientEmail;
            _client = new RestClient(ApiUri);
        }

        /// <summary>
        /// This function will purge CloudFlare of any cached files. It may take up to 48 hours for the cache to rebuild and optimum performance to be achieved so this function should be used sparingly.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        public dynamic ClearAllCache(string zone)
        {
            var request = new RestRequest(Method.POST);

            request.AddParameter("v", "1");
            request.AddParameter("a", "fpurge_ts");
            request.AddParameter("z", zone);

            return Execute<ExpandoObject>(request);
        }
        
        /// <summary>
        /// Retrieves all current settings for a given domain.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        public ClientZoneSettings GetZoneSettings(string zone)
        {
            var request = new RestRequest(Method.POST);

            request.AddParameter("z", zone);
            request.AddParameter("a", "zone_settings");
            dynamic response = Execute<ExpandoObject>(request);

            if (response.result != "success")
            {
                throw new Exception(response.msg);
            }

            var serializedObj = JsonConvert.SerializeObject(response.response.result.objs[0]);
            return JsonConvert.DeserializeObject<ClientZoneSettings>(serializedObj);
        }

        /// <summary>
        /// This function allows you to toggle Development Mode on or off for a particular domain. When Development Mode is on the cache is bypassed. Development mode remains on for 3 hours or until when it is toggled back off.
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        public bool ToggleDevMode(string zone)
        {
            var zoneSettings = GetZoneSettings(zone);

            var request = new RestRequest(Method.POST);
            request.AddParameter("a", "devmode");
            request.AddParameter("z", zone);
            request.AddParameter("v", zoneSettings.DevMode == 0 ? "1" : "0");

            dynamic requestResilt = Execute<ExpandoObject>(request);
            if (requestResilt.result != "success")
            {
                throw new Exception(requestResilt.msg);
            }

            return true;
        }

        private T Execute<T>(RestRequest request) where T : new()
        {
            // used on every request
            request.AddParameter("tkn", ClientApiKey);
            request.AddParameter("email", ClientEmail);

            var response = _client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
