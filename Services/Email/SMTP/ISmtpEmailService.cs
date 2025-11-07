using OvulaeShared.Models.WebApi;

namespace OvulaeShared.Services.Email.SMTP
{
    /// <summary>
    /// Email Services
    /// </summary>
    public interface ISmtpEmailService
    {
        /// <summary>
        /// Change credentials of EmailSender
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void ChangeEmailAndPassword(string email, string password);

        public bool IsEmailAddressValid(string email);

        /// <summary>
        /// Send email from Configured system email to recipient email
        /// </summary>
        /// <param name="email">Recepient email</param>
        /// <param name="subject">Email subject</param>
        /// <param name="emailMessage">Email body (can be html format)</param>
        /// <returns>Generic result indicating success or failure, and corresponding message</returns>
        public Task<GenericResult> SendEmail(string email, string subject, string emailMessage, string plainText = "", string replyToMail = "", string ccEmail = "");
    }
}
