using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.IOS;

namespace OvulaeShared.Services.APIs.Payments
{
    public interface IPaymentsApi
    {
        public Task<GenericResult> RetrySubscriptionPaySuccess(string paymentReference);

        public Task<GenericResult> SubscriptionPaySuccessIOS(PaymentSubscription paymentSubscription);
    }
}
