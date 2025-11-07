using OvulaeShared.ViewModel.Email;

namespace OvulaeShared.Services.Email
{
    public class EmailDirectories
    {
        public static string EMAIL_HOST = "mail.ovulae.com";
        public static string GMAIL = "ovulae.app@gmail.com";

        private static string Domain = "@ovulae.com";

        public static EmailViewModel Accounts = new EmailViewModel
        {
            Email = $"accounts{Domain}",
            Password = "Accounts25!"
        };

        public static EmailViewModel Info = new EmailViewModel
        {
            Email = $"info{Domain}",
            Password = "Info123!"
        };

        public static EmailViewModel NoReply = new EmailViewModel
        {
            Email = $"noreply{Domain}",
            Password = "Noreply25!"
        };

        public static EmailViewModel Support = new EmailViewModel
        {
            Email = $"support{Domain}",
            Password = "Support25!"
        };

        public static EmailViewModel Payments = new EmailViewModel
        {
            Email = $"payments{Domain}",
            Password = "Payments25!"
        };

        public static EmailViewModel Affiliates = new EmailViewModel
        {
            Email = $"affiliates{Domain}",
            Password = "Affiliates25!"
        };

        public static EmailViewModel Queries = new EmailViewModel
        {
            Email = $"queries{Domain}",
            Password = "Queries25!"
        };

        public static EmailViewModel Admin = new EmailViewModel
        {
            Email = $"admin{Domain}",
            Password = "Admin123!"
        };

        public static EmailViewModel Withdrawals = new EmailViewModel
        {
            Email = $"withdrawals{Domain}",
            Password = $"Withdrawals25!",
        };

        public static EmailViewModel Deposits = new EmailViewModel
        {
            Email = $"deposits{Domain}",
            Password = $"Deposits25!",
        };

        public static EmailViewModel Billing = new EmailViewModel
        {
            Email = $"billing{Domain}",
            Password = $"Billing25!",
        };
    }
}
