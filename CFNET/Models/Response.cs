using System.Collections.Generic;
// ReSharper disable InconsistentNaming
namespace CFNET.Models
{
    public class CFResponse
    {
        public Request request { get; set; }
        public Response response { get; set; }
        public string result { get; set; }
        public string msg { get; set; }
    }

    public class Response
    {

        public string zone_name { get; set; }

        public string resolving_to { get; set; }
        public Dictionary<string, string> hosted_cnames { get; set; }
        public Dictionary<string, string> forward_tos { get; set; }
        public string cloudflare_email { get; set; }
        public string cloudflare_username { get; set; }
        public string user_key { get; set; }
        public string unique_id { get; set; }
        public bool user_exists { get; set; }
        public bool user_authed { get; set; }
        public bool zone_exists { get; set; }
        public bool zone_hosted { get; set; }
        public bool zone_deleted { get; set; }
        public string ssl_status { get; set; }
        public string ssl_meta_tag { get; set; }
        public string sub_label { get; set; }
        public string sub_status { get; set; }
        public List<string> hosted_zones { get; set; }
    }

}
// ReSharper restore InconsistentNaming
