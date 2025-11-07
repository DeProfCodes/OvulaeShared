using Newtonsoft.Json;

namespace OvulaeShared.Models.API.Payments.Paystack
{
    public class PaystackInitializeResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PaystackInitializeData Data { get; set; }
    }

}
