using OvulaeShared.Enums;
using OvulaeShared.Enums.User;
using OvulaeShared.Models.WebApi;
using OvulaeShared.Services.Email.SMTP;
using OvulaeShared.ViewModel.Support;
using OvulaeShared.ViewModel.Transactions;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.Services.Email
{
    public class OvulaeEmailService : IOvulaeEmailService
    {
        private ISmtpEmailService emailServ;

        private Random rand;

        public OvulaeEmailService()
        {
            emailServ = new SmtpEmailService(EmailDirectories.Accounts.Email, EmailDirectories.Accounts.Password, EmailDirectories.EMAIL_HOST, 8889);
            rand = new Random();
        }

        public async Task<GenericResult> SendPasswordResetEmail(string receipientEmail, string firstname, string lastname)
        {
            var result = new GenericResult();
            try
            {
                var resetCode = rand.Next(100000, 999999);

                //Send to client
                emailServ.ChangeEmailAndPassword(EmailDirectories.Accounts.Email, EmailDirectories.Accounts.Password);

                var emailMessage = EmailTemplates.PasswordResetCodeEmail($"{firstname} {lastname}", resetCode);
                var emailMessagePlain = EmailTemplates.PasswordResetCodeEmailPlain($"{firstname} {lastname}", resetCode);

                var emailSendClientStatus = await emailServ.SendEmail(receipientEmail, $"Password Reset Code", emailMessage, emailMessagePlain);

                result.Success = emailSendClientStatus.Success;
                result.Message = result.Success ? $"{resetCode}" : "Failed to send password reset code.";

                return result;
            }
            catch (Exception ex)
            {
                result.Message = $"An error occured: {ex.Message}";
            }
            return result;
        }

        public async Task<bool> SendDepositSuccessInvoiceEmail(AddNewInvoiceViewModel invoiceViewModel)
        {
            //Send to client
            emailServ.ChangeEmailAndPassword(EmailDirectories.Deposits.Email, EmailDirectories.Deposits.Password);
            var emailMessage = EmailTemplates.InvoicePaidEmail(invoiceViewModel.Fullname, invoiceViewModel.Amount, invoiceViewModel.TransactionId);
            var emailSendClientStatus = await emailServ.SendEmail(invoiceViewModel.Email, $"New Payment Invoice #{invoiceViewModel.InvoiceId}", emailMessage);

            //Send to Staff
            emailServ.ChangeEmailAndPassword(EmailDirectories.NoReply.Email, EmailDirectories.NoReply.Password);
            emailMessage = EmailTemplates.InvoicePaidInternalEmail(invoiceViewModel.Email, invoiceViewModel.Fullname, invoiceViewModel.Amount, invoiceViewModel.TransactionId);
            var emailSendStaffStatus = await emailServ.SendEmail(EmailDirectories.Payments.Email, $"New Payment Invoice #{invoiceViewModel.InvoiceId}", emailMessage);

            emailSendStaffStatus = await emailServ.SendEmail(EmailDirectories.GMAIL, $"New Payment Invoice #{invoiceViewModel.InvoiceId}", emailMessage);

            return emailSendClientStatus.Success;
        }

        public async Task<bool> SendPaymentSuccessByServicesFail(SupportPaymentErrorViewModel supportErrorViewModel)
        {
            //Send to client
            emailServ.ChangeEmailAndPassword(EmailDirectories.Deposits.Email, EmailDirectories.Deposits.Password);
            var emailMessage = EmailTemplates.InvoicePaidEmail("Client", supportErrorViewModel.Amount, 0);
            var emailSendClientStatus = await emailServ.SendEmail(supportErrorViewModel.Email, $"New Payment Invoice", emailMessage);

            // Send to Staff
            emailServ.ChangeEmailAndPassword(EmailDirectories.NoReply.Email, EmailDirectories.NoReply.Password);
            emailMessage = EmailTemplates.ClientPaymentSuccessWithErrors(supportErrorViewModel);

            var emailSendStaffStatus = await emailServ.SendEmail(
                                                EmailDirectories.Support.Email,
                                                $"Payment With Errors: {supportErrorViewModel.SupportErrorType.GetDisplayDescription()} ",
                                                emailMessage
                                       );

            emailSendStaffStatus = await emailServ.SendEmail(
                                                EmailDirectories.GMAIL,
                                                $"Payment With Errors: {supportErrorViewModel.SupportErrorType.GetDisplayDescription()} ",
                                                emailMessage
                                       );

            return emailSendStaffStatus.Success;
        }

        public async Task<bool> SendUserApprovedEmail(string fullname, string email, UserRoleType userRole)
        {
            //Send to client
            emailServ.ChangeEmailAndPassword(EmailDirectories.Affiliates.Email, EmailDirectories.Affiliates.Password);
            var emailMessage = EmailTemplates.UserApprovalEmailTemplate(fullname, userRole);
            var emailSendClientStatus = await emailServ.SendEmail(email, $"Affilate Approved", emailMessage);

            // Send to Staff
            emailServ.ChangeEmailAndPassword(EmailDirectories.NoReply.Email, EmailDirectories.NoReply.Password);
            emailMessage = EmailTemplates.InternalUserApprovalNotification(fullname, userRole);

            var emailSendStaffStatus = await emailServ.SendEmail(EmailDirectories.Affiliates.Email, $"New Affiliate-{fullname}",emailMessage);

            return emailSendClientStatus.Success;
        }

        public async Task<bool> SendUserRejectedEmail(string fullname, string email)
        {
            //Send to client
            emailServ.ChangeEmailAndPassword(EmailDirectories.Affiliates.Email, EmailDirectories.Affiliates.Password);
            var emailMessage = EmailTemplates.GetGenericRejectionMessage(fullname);
            var emailSendClientStatus = await emailServ.SendEmail(email, $"Affilate Rejected", emailMessage);

            return emailSendClientStatus.Success;
        }

        public async Task<bool> SendOvulaeAppUserQueryEmail(string fullname, string email, string message)
        {
            //Send to client
            emailServ.ChangeEmailAndPassword(EmailDirectories.Support.Email, EmailDirectories.Support.Password);
            var emailMessage = EmailTemplates.InternalUserQueryNotification(fullname, email, message);
            var emailSendClientStatus = await emailServ.SendEmail(EmailDirectories.Queries.Email, $"App Chat Query-{fullname}", emailMessage);

            return emailSendClientStatus.Success;
        }

        public async Task<bool> SendPartnerSharingEmailToJoin(UserPartnerViewModel partnerDetails)
        {
            emailServ.ChangeEmailAndPassword(EmailDirectories.Accounts.Email, EmailDirectories.Accounts.Password);
            var emailMessage = EmailTemplates.PartnerSharingInvitationEmail(partnerDetails);
            var emailSendClientStatus = await emailServ.SendEmail(partnerDetails.Email, $"You’re Invited to Join Your Partner on Ovulae 💜", emailMessage);

            return emailSendClientStatus.Success;
        }

        public async Task<bool> SendSubscriptionInvoiceEmail(string fullName, string email, double amount, string subscriptionType, string transactionReference, bool isZar = true)
        {
            try
            {
                emailServ.ChangeEmailAndPassword(EmailDirectories.Billing.Email, EmailDirectories.Billing.Password);

                var emailMessage = EmailTemplates.SubscriptionInvoiceEmail(fullName, amount, subscriptionType, DateTime.UtcNow, transactionReference, isZar);

                var emailStatus = await emailServ.SendEmail(email, $"Your Ovulae Payment Receipt - {transactionReference}", emailMessage);

                return emailStatus.Success;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, $"Failed to send invoice email to {email}");
                return false;
            }
        }

        public async Task<bool> SendFailedPaymentEmail(string fullName, string email, string subscriptionType, double amount, bool isZar = true)
        {
            try
            {
                // Use billing or support email credentials (whichever is appropriate)
                emailServ.ChangeEmailAndPassword(EmailDirectories.Billing.Email, EmailDirectories.Billing.Password);
                DateTime nextRetryDate = DateTime.UtcNow.AddDays(3);
                
                var emailMessage = EmailTemplates.FailedPaymentEmail(fullName, subscriptionType, amount, EmailDirectories.Support.Email, nextRetryDate, isZar);

                var emailStatus = await emailServ.SendEmail(email, "Action Required: Ovulae Payment Failed", emailMessage);

                return emailStatus.Success;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, $"Failed to send payment failure email to {email}");
                return false;
            }
        }

        public async Task<bool> SendTestDebugEmail(string message)
        {
            try
            {
                emailServ.ChangeEmailAndPassword(EmailDirectories.NoReply.Email, EmailDirectories.NoReply.Password);
                var emailMessage = EmailTemplates.EmailTemplateCover("Test Debug", message, "NoReply");
                var emailSendClientStatus = await emailServ.SendEmail("test.debug@ovulae.com", $"Test Debug - {DateTime.Now:dd-MM-yy HH:mm}", emailMessage);

                return emailSendClientStatus.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}
