using Newtonsoft.Json;

namespace OvulaeShared.Models.API.Payments.Paystack
{
    public class CustomerInfo
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

}
