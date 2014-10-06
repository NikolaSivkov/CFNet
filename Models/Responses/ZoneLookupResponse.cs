using System.Collections.Generic;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class ZoneLookupResponse
    {
        [SerializeAs(Name = "zone_name")]
        [DeserializeAs(Name = "zone_name")]
        public string ZoneName { get; set; }

        [SerializeAs(Name = "zone_exists")]
        [DeserializeAs(Name = "zone_exists")]
        public bool ZoneExists { get; set; }

        [SerializeAs(Name = "zone_hosted")]
        [DeserializeAs(Name = "zone_hosted")]
        public bool ZoneHosted { get; set; }

        [SerializeAs(Name = "hosted_cnames")]
        [DeserializeAs(Name = "hosted_cnames")]
        public Dictionary<string, string> HostedCnames { get; set; }

        [SerializeAs(Name = "forward_tos")]
        [DeserializeAs(Name = "forward_tos")]
        public Dictionary<string, string> ForwardTos { get; set; }

        [SerializeAs(Name = "ssl_status")]
        [DeserializeAs(Name = "ssl_status")]
        public string SslStatus { get; set; }

        [SerializeAs(Name = "ssl_meta_tag")]
        [DeserializeAs(Name = "ssl_meta_tag")]
        public string SslMetaTag { get; set; }

        [SerializeAs(Name = "sub_label")]
        [DeserializeAs(Name = "sub_label")]
        public string SubLabel { get; set; }

        [SerializeAs(Name = "sub_status")]
        [DeserializeAs(Name = "sub_status")]
        public string SubStatus { get; set; }
    }
}