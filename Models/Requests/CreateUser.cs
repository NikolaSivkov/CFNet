using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp.Deserializers;

namespace CFNET.Models
{
    public class CreateUserReqest : CFAction
    {
        /// <summary>
        /// Create a CloudFlare account mapped to your user 
        /// </summary>
        /// <param name="email">The User's e-mail address for the new CloudFlare account</param>
        /// <param name="username">The User's username for the new CloudFlare account. CloudFlare will auto-generate one if it is not specified.</param>
        /// <param name="password">The User's password for the new CloudFlare account. CloudFlare will never store this password in clear text.</param>
        /// <param name="uniqueId">Set a unique string identifying the User. This identifier will serve as an alias to the user's CloudFlare account. Typically you would set this value to the unique ID in your system (e.g., the internal customer number or username stored in your own system). This parameter can be used to retrieve a user_key when it is required. The unique_id must be an ASCII string with a maximum length of 100 characters.</param>
        /// <param name="clobberUniqueId">Any operations that can set a unique_id can be set to automatically "clobber" or unset a previously assigned unique_id.</param>
        public CreateUserReqest(string email, string username, string password, string uniqueId, int clobberUniqueId = 0)
        {
            CloudflareEmail = email;
            CloudflareUsername = username;
            CloudflarePassword = password;
            UniqueId = uniqueId;
            ClobberUniqueId = clobberUniqueId;
        }


        [DeserializeAs(Name = "cloudflare_email")]
        public string CloudflareEmail { get; set; }

        [DeserializeAs(Name = "cloudflare_pass")]
        public string CloudflarePassword { get; set; }

        [DeserializeAs(Name = "cloudflare_username")]
        public string CloudflareUsername { get; set; }

        [DeserializeAs(Name = "unique_id")]
        public string UniqueId { get; set; }

        [DeserializeAs(Name = "clobber_unique_id")]
        public int ClobberUniqueId { get; set; }

        /// <summary>
        /// Represents the action of creating a user.
        /// </summary>
        public override string act { get { return "user_create"; } }
    }
}
