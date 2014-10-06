using System;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class ZoneListResponse
    {
        [SerializeAs(Name = "sub_id")]
        [DeserializeAs(Name = "sub_id")]
        public int SubId { get; set; }

        [SerializeAs(Name = "zone_id")]
        [DeserializeAs(Name = "zone_id")]
        public int ZoneId { get; set; }

        [SerializeAs(Name = "sub_activated_on")]
        [DeserializeAs(Name = "sub_activated_on")]
        public DateTimeOffset SubActivatedOn { get; set; }

        [SerializeAs(Name = "sub_status")]
        [DeserializeAs(Name = "sub_status")]
        public string SubStatus { get; set; }

        [SerializeAs(Name = "sub_expired_on")]
        [DeserializeAs(Name = "sub_expired_on")]
        public DateTimeOffset SubExpiredOn { get; set; }

        [SerializeAs(Name = "sub_label")]
        [DeserializeAs(Name = "sub_label")]
        public string SubLabel { get; set; }

        [SerializeAs(Name = "zone_name")]
        [DeserializeAs(Name = "zone_name")]
        public string ZoneName { get; set; }

        [SerializeAs(Name = "user_email")]
        [DeserializeAs(Name = "user_email")]
        public string UserEmail { get; set; }

        [SerializeAs(Name = "zone_status")]
        [DeserializeAs(Name = "zone_status")]
        public string ZoneStatus { get; set; }
    }
}