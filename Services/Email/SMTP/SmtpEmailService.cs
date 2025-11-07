using System.Net.Mail;
using System.Net;
using OvulaeShared.Models.WebApi;

namespace OvulaeShared.Services.Email.SMTP
{
    public class SmtpEmailService : ISmtpEmailService
    {
        private string EmailHost;
        private int EmailPort;
        private string FromEmail;
        private string FromPassword;

        public SmtpEmailService(string FromEmail, string FromPassword, string EmailHost = "smtp.gmail.com", int EmailPort = 587)
        {
            this.FromEmail = FromEmail;
            this.FromPassword = FromPassword;
            this.EmailHost = EmailHost;
            this.EmailPort = EmailPort;
        }

        public void ChangeEmailAndPassword(string email, string password)
        {
            FromEmail = email;
            FromPassword = password;
        }

        public bool IsEmailAddressValid(string email)
        {
            try
            {
                var mail = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<GenericResult> SendEmail(string email, string subject, string emailMessage, string plainText = "", string replyToMail = "", string ccEmail = "")
        {
            var result = new GenericResult();
            try
            {
                MailMessage message = new MailMessage()
                {
                    From = new MailAddress(FromEmail),
                    Subject = subject,
                    Body = emailMessage,
                    IsBodyHtml = true,
                };
                message.To.Add(new MailAddress(email));

                if (!string.IsNullOrEmpty(replyToMail))
                    message.ReplyToList.Add(new MailAddress(replyToMail));

                if (!string.IsNullOrEmpty(ccEmail))
                    message.CC.Add(new MailAddress(ccEmail));

                // Add plain text alternative
                AlternateView plainView = AlternateView.CreateAlternateViewFromString(plainText, null, "text/plain");
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(emailMessage, null, "text/html");

                message.AlternateViews.Add(plainView);
                message.AlternateViews.Add(htmlView);

                var smtpClient = new SmtpClient(EmailHost)
                {
                    Port = EmailPort,
                    Credentials = new NetworkCredential(FromEmail, FromPassword),
                    EnableSsl = EmailHost == "smtp.gmail.com",
                };

                await smtpClient.SendMailAsync(message);

                result.Success = true;
                result.Message = "An email was sent to recepient successfully.";
            }
            catch (Exception ex)
            {
                result.Message = $"Email could not be sent from system email:{FromEmail}, to recepient email:{email}. \n" +
                                 $" Error: {ex.Message}";
            }
            return result;
        }
    }
}
