using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class Request
    {
        [SerializeAs(Name = "act")]
        [DeserializeAs(Name = "act")]
        public string Act { get; set; }
    }
}