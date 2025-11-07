using Newtonsoft.Json;

namespace OvulaeShared.Models.API.Payments.Paystack
{
    public class AuthorizationInfo
    {
        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }
    }

}
