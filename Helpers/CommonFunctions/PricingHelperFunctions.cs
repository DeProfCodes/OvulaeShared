using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OvulaeShared.Enums;
using OvulaeShared.Enums.User;
using OvulaeShared.Helpers.Constants;
using OvulaeShared.Services.Email;

namespace OvulaeShared.Helpers.CommonFunctions
{
    public class PricingHelperFunctions
    {
        public static double GetAmountFromSubscriptionType(SubscriptionType subscriptionType, bool isZAR = true)
        {
            switch (subscriptionType)
            {
                case SubscriptionType.PremiumMonthly: return isZAR ? OvulaeConstants.MONTHLY_PREMIUM_SUBSCRIPTION : OvulaeConstants.MONTHLY_PREMIUM_SUBSCRIPTION_USD;
                case SubscriptionType.PremiumYearly: return isZAR ? OvulaeConstants.YEARLY_PREMIUM_SUBSCRIPTION : OvulaeConstants.YEARLY_PREMIUM_SUBSCRIPTION_USD;
                default: return 0;
            }
        }

        public async static Task<double> GetAmountFromSubscriptionTypeInZar(SubscriptionType subscriptionType, bool isZAR = true)
        {
            double rate = 1.0;
            if (!isZAR)
            {
                rate = (await GetUsdZarRateAsync()).Value;
            }
            switch (subscriptionType)
            {
                case SubscriptionType.PremiumMonthly: return isZAR ? rate * OvulaeConstants.MONTHLY_PREMIUM_SUBSCRIPTION : rate * OvulaeConstants.MONTHLY_PREMIUM_SUBSCRIPTION_USD;
                case SubscriptionType.PremiumYearly: return isZAR ? rate * OvulaeConstants.YEARLY_PREMIUM_SUBSCRIPTION : rate * OvulaeConstants.YEARLY_PREMIUM_SUBSCRIPTION_USD;
                default: return 0;
            }
        }

        public static async Task<double> GetAffiliateCommisionFromSubscriptionType(SubscriptionType subscriptionType, CurrencyType currencyType)
        {
            var exchangeRate = currencyType == CurrencyType.Dollar ? await GetUsdZarRateAsync() : 1;

            var subscriptionAmount = GetAmountFromSubscriptionType(subscriptionType);

            return (subscriptionAmount * OvulaeConstants.AFFILIATE_COMMISSION_RATE);
        }

        public static async Task<double?> GetUsdZarRateAsync()
        {
            return await GetExchangeRateAsync("USD","ZAR");
        }

        public static async Task<double?> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetFromJsonAsync<JsonElement>("https://open.er-api.com/v6/latest/" + fromCurrency);

                if (response.GetProperty("result").GetString() == "success")
                {
                    return response.GetProperty("rates").GetProperty(toCurrency).GetDouble();
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
