using Newtonsoft.Json;

namespace OvulaeShared.Models.API.Payments.Paystack
{
    public class PaystackData
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("customer")]
        public CustomerInfo Customer { get; set; }

        [JsonProperty("authorization")]
        public AuthorizationInfo Authorization { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }


}
