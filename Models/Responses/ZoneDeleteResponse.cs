using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class ZoneDeleteResponse
    {

        [SerializeAs(Name = "zone_name")]
        [DeserializeAs(Name = "zone_name")]
        public string ZoneName { get; set; }

        [SerializeAs(Name = "zone_deleted")]
        [DeserializeAs(Name = "zone_deleted")]
        public bool ZoneDeleted { get; set; }
    }
}