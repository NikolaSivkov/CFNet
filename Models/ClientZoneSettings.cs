using Newtonsoft.Json;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace CFNET.Models
{
   
    public class ClientZoneSettings
    {

        [JsonProperty("userSecuritySetting")]
        public string UserSecuritySetting { get; set; }

        /// <summary>
        ///  Development Mode status.
        /// A zero response indicates off. 
        /// A non-zero response indicates on. 
        /// The numerical value of a non-zero response indicates when Development Mode will expire.
        /// </summary>
        [JsonProperty("dev_mode")]
        public long DevMode { get; set; }

        /// <summary>
        /// IPV6, Values are [0 = off, 3 = Full]
        /// </summary>
        [JsonProperty("ipv46")]
        public int Ipv46 { get; set; }

        /// <summary>
        /// Always Online status; Values are [0 = off; 1 = on].
        /// </summary>
        [JsonProperty("ob")]
        public int Ob { get; set; }

        /// <summary>
        /// Caching Level. Values are: [agg = aggressive, iqs = simplified, basic]
        /// </summary>
        [JsonProperty("cache_lvl")]
        public string CacheLvl { get; set; }

        [JsonProperty("outboundLinks")]
        public string OutboundLinks { get; set; }

        /// <summary>
        /// Rocket Loader. Values are: [0 = off, a = automatic, m = manual.]
        /// </summary>
        [JsonProperty("async")]
        public string Async { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Challenge TTL, in seconds.
        /// </summary>
        [JsonProperty("chl_ttl")]
        public string ChlTtl { get; set; }

        /// <summary>
        /// Expire TTL (for CloudFlare-cached items), in seconds
        /// </summary>
        [JsonProperty("exp_ttl")]
        public string ExpTtl { get; set; }

        [JsonProperty("fpurge_ts")]
        public string FpurgeTs { get; set; }

        [JsonProperty("hotlink")]
        public string Hotlink { get; set; }

        /// <summary>
        ///  [PRO/BUSINESS/ENTERPRISE] Mirage: Auto-resize, Polish settings
        ///0 = Off
        ///1 = Auto-resize on
        ///200 = Polish: Basic
        ///201 = Polish: Basic, Mirage: Auto-resize on
        ///170 = Polish: Basic + JPEG
        ///171 = Polish: Basic + JPEG, Mirage: Auto-resize on
        /// </summary>
        [JsonProperty("img")]
        public string Img { get; set; }

        /// <summary>
        /// [PRO/BUSINESS/ENTERPRISE] Mirage: Lazy Load. Values are [0 = off, 1 = on]
        /// </summary>
        [JsonProperty("lazy")]
        public string Lazy { get; set; }

        /// <summary>
        /// Minification
        ///0 = off
        ///1 = JavaScript only
        ///2 = CSS only
        ///3 = JavaScript and CSS
        ///4 = HTML only
        ///5 = JavaScript and HTML
        ///6 = CSS and HTML
        ///7 = CSS, JavaScript, and HTML
        /// </summary>
        [JsonProperty("minify")]
        public string Minify { get; set; }
        
        [JsonProperty("outlink")]
        public string Outlink { get; set; }

        /// <summary>
        /// [PRO/BUSINESS/ENTERPRISE] Preloader. Values are [0 = off, 1 = on]
        /// </summary>
        [JsonProperty("preload")]
        public string Preload { get; set; }

        [JsonProperty("s404")]
        public string S404 { get; set; }

        /// <summary>
        /// Basic Security Level. Values are [eoff (Essentially Off), low, med, high, help (I'm Under Attack!)]
        /// </summary>
        [JsonProperty("sec_lvl")]
        public string SecLvl { get; set; }

        /// <summary>
        /// [PRO/BUSINESS/ENTERPRISE] SPDY. Values are [0 = off, 1 = on]
        /// </summary>
        [JsonProperty("spdy")]
        public string Spdy { get; set; }

        /// <summary>
        /// [PRO/BUSINESS/ENTERPRISE] SSL Status. Values are [0 = off, 1 = Flexible, 2 = Full, 3 = Full (Strict)]
        /// </summary>
        [JsonProperty("ssl")]
        public string Ssl { get; set; }

        /// <summary>
        ///  [PRO/BUSINESS/ENTERPRISE] WAF setting. Values are [high, low, off]
        /// </summary>
        [JsonProperty("waf_profile")]
        public string WafProfile { get; set; }
    }
}
