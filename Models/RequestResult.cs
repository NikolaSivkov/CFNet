using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
    public class RequestResult<T>
    {
        [SerializeAs(Name = "response")]
        [DeserializeAs(Name = "response")]
        public T Response { get; set; }

        [SerializeAs(Name = "request")]
        [DeserializeAs(Name = "request")]
        public Request Request { get; set; }

        [SerializeAs(Name = "result")]
        [DeserializeAs(Name = "result")]
        public string Result { get; set; }

        [SerializeAs(Name = "msg")]
        [DeserializeAs(Name = "msg")]
        public string Message { get; set; }

        [SerializeAs(Name = "limit")]
        [DeserializeAs(Name = "limit")]
        public string Limit { get; set; }

        [SerializeAs(Name = "offset")]
        [DeserializeAs(Name = "offset")]
        public string Offset { get; set; }
         
    }
  
}