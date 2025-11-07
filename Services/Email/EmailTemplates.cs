using OvulaeShared.Enums;
using OvulaeShared.Enums.User;
using OvulaeShared.ViewModel.Support;
using OvulaeShared.ViewModel.Transactions;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.Services.Email
{
    public class EmailTemplates
    {
        public static string SupportEmailTemplateInternal(string fname, string subject, string email, string message)
        {
            var supportMessage = "<div>" +
                               "A new mail from client that needs your immediate attention." +
                               "<br>" +
                               "<br>" +
                               "<p style=\"font-size:16px; font-weight:bold\"> Enquiry Details: </span>" +
                               "<table>" +
                                    "<tr>" +
                                       "<td><span style=\"font-weight:bold\">From Name</span></td>" +
                                       $"<td>: {fname}</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                       "<td><span style=\"font-weight:bold\">Subject</span></td>" +
                                       $"<td>: {subject}</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td><span style=\"font-weight:bold\">Email</span></td>" +
                                       $"<td>: {email}</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Message</td>" +
                                       $"<td>: {message}</td>" +
                                    "</tr>" +
                               "</table>" +
                            "</div>";

            return "";
        }

        public static string SupportEmailTemplatePlainInternal(string fname, string subject, string email, string message)
        {
            var supportMessage = "<div>" +
                               "A new mail from client that needs your immediate attention." +
                               "<br>" +
                               "<br>" +
                               "<p style=\"font-size:16px; font-weight:bold\"> Enquiry Details: </span>" +
                               "<table>" +
                                    "<tr>" +
                                       "<td><span style=\"font-weight:bold\">From Name</span></td>" +
                                       $"<td>: {fname}</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                       "<td><span style=\"font-weight:bold\">Subject</span></td>" +
                                       $"<td>: {subject}</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td><span style=\"font-weight:bold\">Email</span></td>" +
                                       $"<td>: {email}</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Message</td>" +
                                       $"<td>: {message}</td>" +
                                    "</tr>" +
                               "</table>" +
                            "</div>";

            return "";
        }

        public static string PasswordResetCodeEmail(string fullName, int code)
        {
            var message = $@"<p>Your Ovulae App Password Reset Code is:<br>
                             <p style='font-size: 24px; letter-spacing: 10px; font-weight: bold; color: #333;'>{code}</p>";

            return EmailTemplateCover(fullName, message, "Accounts");
        }

        public static string AccountActivationEmailTemplate(string callBackurl, string recipientName)
        {
            var messageBody = "Thank you for Ovulae App. " +
                              "<br>" +
                              "<br>" +
                              "Please click the button below to verify your email address:" + "<br>" +
                              $"<a class='btn' href='{callBackurl}'>Verify Email</a> <br>";

            return EmailTemplateCover(
                    recipientName,
                    messageBody,
                    "Accounts Department"
                );
        }

        public static string UserApprovalEmailTemplate(string recipientName, UserRoleType userRole)
        {
            var message = "";
            var callBackUrl = "https://portal.ovulae.com";
            if (userRole == UserRoleType.Affiliate)
            {
                message = 
                    "🎉 <strong>Welcome to the Ovulae Affiliate Program!</strong>" +
                    "<br><br>" +
                    "We’re excited to let you know that your application has been approved. You’re now part of a growing movement focused on empowering women with smarter health solutions. 🌸" +
                    "<br><br>" +
                    "Start sharing Ovulae with your network and earn while making a difference. We're here to support you every step of the way! 🚀" +
                    "<br><br>" +
                    $"<a class='btn' href='{callBackUrl}'>Access Your Dashboard</a>" +
                    $"<br><br>" +
                    "Let’s grow together 💜";
            }
            else if (userRole == UserRoleType.Doctor)
            {
                message =
                    "<strong>Welcome to Ovulae, Doctor.</strong>" +
                    "<br><br>" +
                    "We’re pleased to inform you that your account has been reviewed and approved. You now have full access to our platform to support women’s health with the professionalism and care it deserves." +
                    "<br><br>" +
                    "Please click below to log in and begin accessing your tools and insights." +
                    "<br><br>" +
                    $"<a class='btn' href='{callBackUrl}'>Access Your Dashboard</a>" +
                    $"<br><br>" +
                    "We’re honored to have you on board.";
            }
            else
            {
                message =
                    "<strong>Welcome to Ovulae!</strong>" +
                    "<br><br>" +
                    "Your account has been approved, and you're ready to begin using the Ovulae platform." +
                    "<br><br>" +
                    $"<a class='btn' href='{callBackUrl}'>Access Your Dashboard</a><br>";
            }

            return EmailTemplateCover(
                    recipientName,
                    message,
                    "Affiliates Department"
                );
        }

        public static string InternalUserApprovalNotification(string recipientName, UserRoleType userRole)
        {
            var message = $@"
                        <strong style='color:#B5A4DE'>Approval Notification</strong><br><br>
                        A new {userRole.GetDisplayName()} has been approved on the Ovulae platform.<br><br>
                        
                        <table cellpadding='6' cellspacing='0' style='border:1px solid #ccc; border-collapse:collapse; font-family:sans-serif; font-size:14px;'>
                            <tr style='background:#f7f7f7;'>
                                <td style='border:1px solid #ccc; font-weight:bold;'>Full Name</td>
                                <td style='border:1px solid #ccc;'>{recipientName}</td>
                            </tr>
                            <tr>
                                <td style='border:1px solid #ccc; font-weight:bold;'>User Role</td>
                                <td style='border:1px solid #ccc;'>{userRole.GetDisplayName()}</td>
                            </tr>
                            <tr>
                                <td style='border:1px solid #ccc; font-weight:bold;'>Approval Date</td>
                                <td style='border:1px solid #ccc;'>{DateTime.Now:yyyy-MM-dd HH:mm}</td>
                            </tr>
                        </table>
                        
                        <br>
                        Please ensure their profile is fully configured and any onboarding materials are sent out where necessary.
                        ";

            return EmailTemplateCover(
                    "Affiliates",
                    message,
                    "Accounts Department"
                );
        }

        public static string GetGenericRejectionMessage(string recipientName)
        {
            var message = 
                "❌ <strong>Application Review Outcome</strong>" +
                "<br><br>" +
                "Thank you for taking the time to apply to Ovulae. After careful consideration, your application was not approved at this stage. 🙁" +
                "<br><br>" +
                "This may be due to incomplete information, eligibility criteria, or other internal requirements." +
                "<br><br>" +
                "We appreciate your interest and encourage you to reapply in the future if circumstances change. 💜";

            return EmailTemplateCover(
                    recipientName,
                    message,
                    "Affiliates Department"
                );
        }

        public static string InternalUserQueryNotification(string fullname, string email, string message)
        {
            var emailContent = $@"
                <strong style='color:#B5A4DE'>New User Query Received</strong><br><br>
                A new query has been submitted on the Ovulae App Chat.<br><br>

                <table cellpadding='6' cellspacing='0' style='border:1px solid #ccc; border-collapse:collapse; font-family:sans-serif; font-size:14px;'>
                    <tr style='background:#f7f7f7;'>
                        <td style='border:1px solid #ccc; font-weight:bold;'>Full Name</td>
                        <td style='border:1px solid #ccc;'>{fullname}</td>
                    </tr>
                    <tr>
                        <td style='border:1px solid #ccc; font-weight:bold;'>Email</td>
                        <td style='border:1px solid #ccc;'>{email}</td>
                    </tr>
                    <tr>
                        <td style='border:1px solid #ccc; font-weight:bold;'>Date Submitted</td>
                        <td style='border:1px solid #ccc;'>{DateTime.Now:yyyy-MM-dd HH:mm}</td>
                    </tr>
                </table>

                <br>
                <strong>Message:</strong><br>
                <div style='background:#f9f9f9; border:1px solid #ccc; padding:10px; font-family:sans-serif; font-size:14px;'>
                    {System.Net.WebUtility.HtmlEncode(message).Replace("\n", "<br>")}
                </div>

                <br>
                Please attend to this query as soon as possible.
            ";

             return EmailTemplateCover(
                 $"Queries",
                 emailContent,
                 "Ovulae Support Team"
             );
        }

        public static string InvoicePaidEmail(string recipientName, double amount, int transactionId)
        {
            var orderBody = "<div>" +
                               "Thank you for Payment." +
                               "<br>" +
                               "<br>" +
                               "Your deposit for Investment has been successful and should be reflecting on your portal. " +
                               "<br>" +
                               "<br>" +
                               "<p style=\"font-size:16px; font-weight:bold\"> PAID INVOICE Details: </span>" +
                               "<table>" +
                                    "<tr>" +
                                        "<td>Payment Date</td>" +
                                        $"<td>: <span style=\"font-weight:bold\">{DateTime.UtcNow.ToString("dd MMMM yyyy")}</span></td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Amount</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">R{amount}.00</span>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Transaction ID</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">{transactionId}</span>" +
                                        "</td>" +
                                    "</tr>" +
                               "</table>" +
                            "</div>";

            return EmailTemplateCover(
                    recipientName,
                    orderBody,
                    "Accounting Department"
            );
        }

        public static string InvoicePaidInternalEmail(string email, string recipientName, double amount, int transactionId)
        {
            var orderBody = "<div>" +
                               "A User has made a payment with details below." +
                               "<br>" +
                               "<br>" +
                               "Check the details of the client who has made payment. " +
                               "<br>" +
                               "<br>" +
                               "<p style=\"font-size:16px; font-weight:bold\">PAID INVOICE Details: </span>" +
                               "<table>" +
                                    "<tr>" +
                                        "<td>Email</td>" +
                                        $"<td>: <span style=\"font-weight:bold\">{email}</span></td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Fullname</td>" +
                                        $"<td>: <span style=\"font-weight:bold\">{recipientName}</span></td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Payment Date</td>" +
                                        $"<td>: <span style=\"font-weight:bold\">{DateTime.UtcNow.ToString("dd MMMM yyyy HH:mm")}</span></td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Amount</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">R{amount}.00</span>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Transaction ID</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">{transactionId}</span>" +
                                        "</td>" +
                                    "</tr>" +
                               "</table>" +
                            "</div>";

            return EmailTemplateCover(
                    "Payments",
                    orderBody,
                    "Accounting Department"
            );
        }

        public static string ClientPaymentSuccessWithErrors(SupportPaymentErrorViewModel suppportErrorVM)
        {
            var orderBody = "<div>" +
                               "A Payment was made but there not all services were successful, See below:" +
                               "<br>" +
                               "<br>" +
                               "Check the details of the client who has made payment. " +
                               "<br>" +
                               "<br>" +
                               "<p style=\"font-size:16px; font-weight:bold\">PAID INVOICE Details: </span>" +
                               "<table>" +
                                    "<tr>" +
                                        "<td>Email</td>" +
                                        $"<td>: <span style=\"font-weight:bold\">{suppportErrorVM.Email}</span></td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Fullname</td>" +
                                        $"<td>: <span style=\"font-weight:bold\">{suppportErrorVM.Fullname}</span></td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Payment Date</td>" +
                                        $"<td>: <span style=\"font-weight:bold\">{DateTime.UtcNow.ToString("dd MMMM yyyy")}</span></td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Amount</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">R{suppportErrorVM.Amount}.00</span>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Transaction ID</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">{suppportErrorVM.TransactionId}</span>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>Transaction Type</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">{suppportErrorVM.TransactionType.GetDisplayName()}</span>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>ERROR TYPE</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">{suppportErrorVM.SupportErrorType.GetDisplayDescription()}</span>" +
                                        "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td>ERROR MESSAGE</td>" +
                                        "<td>: " +
                                           $"<span style=\"font-weight:bold\">{suppportErrorVM.ErrorMessage}</span>" +
                                        "</td>" +
                                    "</tr>" +
                               "</table>" +
                            "</div>";

            return EmailTemplateCover(
                    "Payments",
                    orderBody,
                    "Accounting Department"
            );
        }

        public static string PasswordResetCodeEmailPlain(string fullName, int code)
        {
            var message = $"Your Ovulae App Password Reset Code is: {code}";

            return EmailTemplateCoverPlainText(fullName, message, "Accounts");
        }

        public static string PartnerSharingInvitationEmail(UserPartnerViewModel partnerDetails)
        {
            var message = $@"
                <strong style='color:#B5A4DE'>You've Been Invited to Join {partnerDetails.MainUserFullname}'s Journey on Ovulae 💜</strong><br><br>

                {partnerDetails.MainUserFullname} has invited you to join them on their {partnerDetails.Journey} journey using the Ovulae app. This will allow you to stay informed, connected, and supportive throughout this meaningful time.<br><br>

                <table cellpadding='6' cellspacing='0' style='border:1px solid #ccc; border-collapse:collapse; font-family:sans-serif; font-size:14px;'>
                    <tr style='background:#f7f7f7;'>
                        <td style='border:1px solid #ccc; font-weight:bold;'>Your Name</td>
                        <td style='border:1px solid #ccc;'>{partnerDetails.Firstname} {partnerDetails.Lastname}</td>
                    </tr>
                    <tr>
                        <td style='border:1px solid #ccc; font-weight:bold;'>Journey</td>
                        <td style='border:1px solid #ccc;'>{partnerDetails.Journey}</td>
                    </tr>
                    <tr>
                        <td style='border:1px solid #ccc; font-weight:bold;'>Login Email</td>
                        <td style='border:1px solid #ccc;'>{partnerDetails.Email}</td>
                    </tr>
                    <tr>
                        <td style='border:1px solid #ccc; font-weight:bold;'>Temporary Password</td>
                        <td style='border:1px solid #ccc;'>{partnerDetails.TempPassword}</td>
                    </tr>
                </table>
                <br>

                <strong>How to get started:</strong><br>
                1️⃣ Download the Ovulae app:<br>
                • <a href='https://play.google.com/store/apps/details?id=com.ovulae.app' style='color:#B5A4DE;'>Download from Google Play Store</a><br>
                • <a href='https://apps.apple.com/app/idYOUR_APP_ID' style='color:#B5A4DE;'>Download from Apple App Store</a><br><br>

                2️⃣ Open the app and log in using the email and temporary password provided above.<br>
                3️⃣ For your security, you can change your password anytime under Settings once logged in, or click 'Forgot Password' on the login screen to set your preferred password before logging in.<br><br>

                <strong>Why join?</strong><br>
                • Stay connected and informed on your partner's journey.<br>
                • Receive milestone updates, insights, and supportive content.<br>
                • Enhance emotional connection during this important time.<br><br>

                If you did not expect this invitation, you can safely ignore this email.<br><br>

                We are excited to have you join your partner on Ovulae 💜.
            ";

            return EmailTemplateCover(
                $"{partnerDetails.Firstname} {partnerDetails.Lastname}",
                message,
                "Ovulae Team"
            );
        }

        public static string SubscriptionInvoiceEmail(string fullName, double amount, string subscriptionType, DateTime paymentDate, string transactionReference, bool isZar = true)
        {
            var amountStr = isZar ? "R95.00" : $"$5.99 (ZAR{amount})"; 
            var message = $@"
                                <strong style='color:#B5A4DE'>Your Ovulae Subscription Payment Receipt</strong><br><br>
                                
                                Thank you for your continued trust in Ovulae. Here's your payment confirmation:<br><br>
                                
                                <table cellpadding='6' cellspacing='0' style='border:1px solid #ccc; border-collapse:collapse; font-family:sans-serif; font-size:14px;'>
                                    <tr style='background:#f7f7f7;'>
                                        <td style='border:1px solid #ccc; font-weight:bold;'>Subscription Type</td>
                                        <td style='border:1px solid #ccc;'>{subscriptionType}</td>
                                    </tr>
                                    <tr>
                                        <td style='border:1px solid #ccc; font-weight:bold;'>Amount Paid</td>
                                        <td style='border:1px solid #ccc;'>{amountStr}</td>
                                    </tr>
                                    <tr>
                                        <td style='border:1px solid #ccc; font-weight:bold;'>Payment Date</td>
                                        <td style='border:1px solid #ccc;'>{paymentDate:dd MMMM yyyy}</td>
                                    </tr>
                                    <tr>
                                        <td style='border:1px solid #ccc; font-weight:bold;'>Transaction Reference</td>
                                        <td style='border:1px solid #ccc;'>{transactionReference}</td>
                                    </tr>
                                    <tr>
                                        <td style='border:1px solid #ccc; font-weight:bold;'>Next Billing Date</td>
                                        <td style='border:1px solid #ccc;'>{paymentDate.AddMonths(1):dd MMMM yyyy}</td>
                                    </tr>
                                </table>
                                <br>
                                
                                <strong>Premium Features You're Enjoying:</strong><br>
                                • Full access to all cycle tracking tools<br>
                                • OB-GYN approved health insights<br>
                                • Partner sharing capabilities<br>
                                • Ad-free experience<br><br>
                                
                                <strong>Need Help?</strong><br>
                                Contact our support team at <a href='mailto:support@ovulae.com' style='color:#B5A4DE;'>support@ovulae.com</a> for any questions about your subscription.<br><br>
                                
                                We appreciate you being part of the Ovulae community!
                            ";

            return EmailTemplateCover(
                fullName,
                message,
                "Ovulae Billing Team"
            );
        }

        public static string FailedPaymentEmail(string fullName, string subscriptionType, double amount, string supportEmail, DateTime nextRetryDate, bool isZar = true)
        {
            var amountStr = isZar ? "R95.00" : $"$5.99 (ZAR{amount})";

            var message = $@"
                <div style='color:#d9534f; font-weight:bold; border-left:4px solid #d9534f; padding-left:12px; margin-bottom:20px;'>
                    ⚠️ Your Ovulae premium access has been temporarily suspended
                </div>

                <strong style='color:#B5A4DE'>Payment Details:</strong>
                <table cellpadding='6' cellspacing='0' style='border:1px solid #eee; border-collapse:collapse; margin:10px 0; font-size:14px; width:100%;'>
                    <tr style='background:#f9f9f9;'>
                        <td style='border:1px solid #eee; padding:8px; width:40%;'><strong>Subscription</strong></td>
                        <td style='border:1px solid #eee; padding:8px;'>{subscriptionType}</td>
                    </tr>
                    <tr>
                        <td style='border:1px solid #eee; padding:8px;'><strong>Amount</strong></td>
                        <td style='border:1px solid #eee; padding:8px;'>{amountStr}</td>
                    </tr>
                    <tr>
                        <td style='border:1px solid #eee; padding:8px;'><strong>Next Retry</strong></td>
                        <td style='border:1px solid #eee; padding:8px;'>{nextRetryDate:dd MMMM yyyy}</td>
                    </tr>
                </table>

                <strong style='color:#B5A4DE'>🚀 Quick Reactivation Options:</strong>
                <ol style='margin-top:5px; padding-left:20px;'>
                    <li><strong>Update Payment Method:</strong> Open OvulaeApp to update card details</a></li>
                    <li><strong>Instant Retry:</strong> Updating your card will automatically retry payment</li>
                    <li><strong>Wait for Auto-Retry:</strong> We'll try again on {nextRetryDate:dd MMMM}</li>
                </ol>

                <strong style='color:#B5A4DE'>🔒 Temporary Restrictions:</strong>
                <ul style='margin-top:5px; padding-left:20px;'>
                    <li>Premium feature access suspended</li>
                    <li>Basic cycle tracking still available</li>
                    <li>Partner sharing disabled</li>
                </ul>

                <div style='margin-top:20px; padding:12px; background-color:#FFF5FF; border-radius:4px;'>
                    <strong>Need help?</strong> Contact <a href='mailto:{supportEmail}' style='color:#B5A4DE;'>{supportEmail}</a> or reply to this email.
                    We'll help restore your full access within 1 business day.
                </div>
            ";

            return EmailTemplateCover(
                fullName,
                message,
                "Ovulae Billing Team"
            );
        }

        public static string EmailTemplateCover(string clientName, string message, string fromDepartment)
        {
            return $@"
                <!DOCTYPE html>
                    <html>
                    <head>
                        <meta charset='UTF-8'>
                        <title>Ovulae Email</title>
                    </head>
                    <body style='margin:0; padding:0; background-color:#f0f0f5; font-family:Barlow, sans-serif;'>
                    
                        <table cellpadding='0' cellspacing='0' width='100%' style='background-color:#f0f0f5; padding: 40px 0;'>
                            <tr>
                                <td align='center'>
                    
                                    <!-- Main content container -->
                                    <table cellpadding='0' cellspacing='0' width='600' style='background:white; border-radius:8px; overflow:hidden; box-shadow:0 2px 10px rgba(0,0,0,0.15);'>
                                        
                                        <!-- Header -->
                                        <tr>
                                            <td style='padding: 20px; text-align:center; background-color:#FFF5FF; border-bottom:1px solid #B5A4DE;'>
                                                <div style='font-size:48px; font-weight:bold; color:#B5A4DE;'>Ovulae</div>
                                            </td>
                                        </tr>
                    
                                        <!-- Body -->
                                        <tr>
                                            <td style='padding: 30px; background:#ffffff; font-size:15px; line-height:1.6; color:#333;'>
                                                <h3 style='color:#021623; margin-top:0;'>Hi {clientName},</h3>
                    
                                                {message}
                    
                                                <p style='margin-top:30px; font-style:italic; color:#B5A4DE;font-size:12px'>
                                                    Empowering women at every stage of their health journey.
                                                </p>
                    
                                                <p style='margin-top:10px;'>Best regards,<br>
                                                <strong>{fromDepartment}</strong><br>
                                                Ovulae (Pty) Ltd<br>
                                                <a href='https://www.ovulae.com' target='_blank' style='color:#FF66C4;'>www.ovulae.com</a>
                                                </p>
                                            </td>
                                        </tr>
                    
                                        <!-- Footer -->
                                        <tr>
                                            <td style='padding: 20px; text-align:center; background-color:#B5A4DE; color:#fff; font-size:12px;'>
                                                &copy; 2025 <a href='https://www.ovulae.com' style='color:#fff; text-decoration:none;'>Ovulae.com</a>. All rights reserved.
                                            </td>
                                        </tr>
                    
                                    </table>
                    
                                </td>
                            </tr>
                        </table>
                    
                    </body>
                    </html>";
        }

        public static string EmailTemplateCoverPlainText(string clientName, string message, string fromDepartment)
        {
            return
                $@"Hi {clientName},
                   
                   {message}
                   
                   Best regards,
                   {fromDepartment}
                   Ovulae (Pty) Ltd 
                   https://www.ovulae.com";
        }
    }
}
