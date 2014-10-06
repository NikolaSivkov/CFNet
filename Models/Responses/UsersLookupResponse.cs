using System.Collections.Generic;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class UsersLookupResponse
    {
        [SerializeAs(Name = "user_exists")]
        [DeserializeAs(Name = "user_exists")]
        public bool UserExists { get; set; }

        [SerializeAs(Name = "cloudflare_email")]
        [DeserializeAs(Name = "cloudflare_email")]
        public string CloudflareEmail { get; set; }

        [SerializeAs(Name = "user_authed")]
        [DeserializeAs(Name = "user_authed")]
        public bool UserAuthenticated { get; set; }

        [SerializeAs(Name = "user_key")]
        [DeserializeAs(Name = "user_key")]
        public string UserKey { get; set; }

        [SerializeAs(Name = "unique_id")]
        [DeserializeAs(Name = "unique_id")]
        public string UniqueId { get; set; }

        [SerializeAs(Name = "hosted_zones")]
        [DeserializeAs(Name = "hosted_zones")]
        public List<string> HostedZones { get; set; }
    }
}