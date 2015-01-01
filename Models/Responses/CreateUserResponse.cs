using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class CreateUserResponse
    {
        [SerializeAs(Name = "cloudflare_email")]
        [DeserializeAs(Name = "cloudflare_email")]
        public string CloudFlareEmail { get; set; }

        [SerializeAs(Name = "user_key")]
        [DeserializeAs(Name = "user_key")]
        public string UserKey { get; set; }

        [SerializeAs(Name = "user_api_key")]
        [DeserializeAs(Name = "user_api_key")]
        public string UserApiKey { get; set; }

        [SerializeAs(Name = "unique_id")]
        [DeserializeAs(Name = "unique_id")]
        public string UniqueId { get; set; }

        [SerializeAs(Name = "cloudflare_username")]
        [DeserializeAs(Name = "cloudflare_username")]
        public string CloudFlareusername { get; set; }
    }
}