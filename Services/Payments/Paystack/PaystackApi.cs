using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Models.API.Payments.Paystack;
using OvulaeShared.Models.WebApi;

namespace OvulaeShared.Services.Payments.Paystack
{
    public class PaystackApi : IPaystackApi
    {
        private readonly HttpClient _httpClient;
        private const string PaystackTestSecretKey = "sk_test_d46f45bd0300ad700a9c2289dedc73b242b26445"; // TODO: move to config
        private const string PaystackLiveSecretKey = "sk_live_25be23174fe95a342ea07d14a2090ab85c5d502f";
        private const string BaseUrl = "https://api.paystack.co";

        public PaystackApi()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", PaystackLiveSecretKey);
        }

        public async Task<PaystackInitializeResponse?> InitializeTransactionAsync(string email, int amountInCents, string callbackUrl)
        {
            try
            {
                var payload = new
                {
                    email = email,
                    amount = amountInCents,
                    currency = "ZAR",
                    callback_url = "https://portal.ovulae.com/Payments/PaystackBridge"
                };

                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("/transaction/initialize", content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return null;

                var result = JsonConvert.DeserializeObject<PaystackInitializeResponse>(responseString);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("InitializeTransactionAsync error: " + ex.Message);
                return null;
            }
        }


        public async Task<GenericResult> CheckPaymentStatusAsync(string reference)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/transaction/verify/{reference}");
                var responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return new GenericResult { Message = "Unable to verify transaction." };

                var doc = JsonDocument.Parse(responseString);
                var status = doc.RootElement.GetProperty("data").GetProperty("status").GetString();

                switch (status)
                {
                    case "success":
                        return new GenericResult { Success = true, Message = "Payment successful." };

                    case "pending":
                        return new GenericResult { Success = false, Message = "Payment is still pending." };

                    case "failed":
                    case "abandoned":
                    case "timeout":
                        return new GenericResult { Success = false, Message = $"Payment failed or incomplete: {status}" };

                    case "reversed":
                        return new GenericResult { Success = false, Message = "Payment was reversed." };

                    default:
                        return new GenericResult { Success = false, Message = $"Unknown payment status: {status}" };
                }

            }
            catch (Exception ex)
            {
                return new GenericResult { Message = $"Error: {ex.Message}" };
            }
        }

        public async Task<string?> GetPaymentJsonAsync(string reference)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/transaction/verify/{reference}");
                var responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return null;

                var doc = JsonDocument.Parse(responseString);
                var data = doc.RootElement.GetProperty("data");

                return data.GetRawText();
            }
            catch
            {
                return null;
            }
        }
    }
}
