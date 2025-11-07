using OvulaeShared.Models.API.Payments.Paystack;
using OvulaeShared.Models.WebApi;

namespace OvulaeShared.Services.Payments.Paystack
{
    public interface IPaystackApi
    {
        Task<PaystackInitializeResponse> InitializeTransactionAsync(string email, int amountInCents, string callbackUrl);

        Task<GenericResult> CheckPaymentStatusAsync(string reference);

        Task<string?> GetPaymentJsonAsync(string reference);
    }
}
