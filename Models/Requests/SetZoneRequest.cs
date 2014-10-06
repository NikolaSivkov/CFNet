using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
   public class SetZoneRequest: CFAction
    {
        /// <summary>
        ///  Setup a User's zone for CNAME hosting 
        /// </summary>
        /// <param name="userKey">The unique 32 hex character auth string, identifying the user's CloudFlare Account. Generated from a CreateUser</param>
        /// <param name="zoneName">The zone you'd like to run CNAMES through CloudFlare for, e.g. "example.com".</param>
        /// <param name="resolveTo">The CNAME that CloudFlare should ultimately resolve web connections to after they have been filtered, e.g. "resolve-to-cloudflare.example.com". This record should ultimately resolve to the one or more IP addresses of the hosts for the particular website for all the specified subdomains. Note: it CANNOT be the naked zone name, in this case example.com</param>
        /// <param name="subDomains">A comma-separated string of subdomain(s) that CloudFlare should host, e.g. "www,blog,forums" or "www.example.com,blog.example.com,forums.example.com".</param>
        public SetZoneRequest(string userKey,string zoneName, string resolveTo,string subDomains)
        {
            //todo: consider switching from string to a list or array for the resolveto and subdomains
            //and functions to concatanete them on get
            UserKey = userKey;
            ZoneName = zoneName;
            ResolveTo = resolveTo;
            Subdomains = subDomains;
        }

        [SerializeAs(Name = "user_key")]
        [DeserializeAs(Name = "user_key")]
        public string UserKey { get; set; }

        [SerializeAs(Name = "zone_name")]
        [DeserializeAs(Name = "zone_name")]
        public string ZoneName { get; set; }

        [SerializeAs(Name = "resolve_to")]
        [DeserializeAs(Name = "resolve_to")]
        public string ResolveTo { get; set; }

        [SerializeAs(Name = "subdomains")]
        [DeserializeAs(Name = "subdomains")]
        public string Subdomains { get; set; }

        public override string act { get { return "zone_set"; } }
    }
}
