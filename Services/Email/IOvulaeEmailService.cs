using OvulaeShared.Enums.User;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Support;
using OvulaeShared.ViewModel.Transactions;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.Services.Email
{
    public interface IOvulaeEmailService
    {
        public Task<bool> SendDepositSuccessInvoiceEmail(AddNewInvoiceViewModel invoiceViewModel);

        public Task<bool> SendPaymentSuccessByServicesFail(SupportPaymentErrorViewModel supportErrorViewModel);

        public Task<GenericResult> SendPasswordResetEmail(string receipientEmail, string firstname, string lastname);

        public Task<bool> SendUserApprovedEmail(string fullname, string email, UserRoleType userRole);

        public Task<bool> SendUserRejectedEmail(string fullname, string email);

        public Task<bool> SendOvulaeAppUserQueryEmail(string fullname, string email, string message);

        public Task<bool> SendPartnerSharingEmailToJoin(UserPartnerViewModel partnerDetails);

        public Task<bool> SendSubscriptionInvoiceEmail(string fullName, string email, double amount, string subscriptionType, string transactionReference, bool isZar = true);

        public Task<bool> SendFailedPaymentEmail(string fullName, string email, string subscriptionType, double amount, bool isZar = true);

        public Task<bool> SendTestDebugEmail(string message);
    }
}
