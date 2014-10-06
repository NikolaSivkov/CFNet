using System.Collections.Generic;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class SetZoneResponse
    {
        [SerializeAs(Name = "zone_name")]
        [DeserializeAs(Name = "zone_name")]
        public string zone_name { get; set; }

        [SerializeAs(Name = "resolving_to")]
        [DeserializeAs(Name = "resolving_to")]
        public string resolving_to { get; set; }

        [SerializeAs(Name = "hosted_cnames")]
        [DeserializeAs(Name = "hosted_cnames")]
        public Dictionary<string, string> hosted_cnames { get; set; }

        [SerializeAs(Name = "forward_tos")]
        [DeserializeAs(Name = "forward_tos")]
        public Dictionary<string, string> forward_tos { get; set; }
    }
}