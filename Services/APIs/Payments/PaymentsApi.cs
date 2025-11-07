using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Helpers.API;
using OvulaeShared.Models.Affiliate;
using OvulaeShared.Models.WebApi;
using OvulaeShared.Services.APIs.Messaging;
using OvulaeShared.ViewModel.IOS;

namespace OvulaeShared.Services.APIs.Payments
{
    public class PaymentsApi : BaseApiService, IPaymentsApi
    {
        public PaymentsApi()
        {
            
        }

        public async Task<GenericResult> RetrySubscriptionPaySuccess(string paymentReference)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    Sensitive1 = paymentReference
                };

                var retrySubscriptionPay = await _webAPI.PostData(OvulaeApiEndPoints.PAYMENTS.RETRY_SUBSCRIPTION_ACTIVATION, dto);

                return retrySubscriptionPay;
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to udpate retry subscription activation. error: {ex.Message}"
                };
            }
        }

        public async Task<GenericResult> SubscriptionPaySuccessIOS(PaymentSubscription paymentSubscription)
        {
            try
            {
                var subscriptionPayment = await _webAPI.PostData(OvulaeApiEndPoints.PAYMENTS.SUBSCRIPTION_ACTIVATION_IOS, paymentSubscription);

                return subscriptionPayment;
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to udpate activate subscription. error: {ex.Message}"
                };
            }
        }
    }
}
