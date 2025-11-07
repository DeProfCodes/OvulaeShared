
using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;

namespace OvulaeShared.Models.User
{
    public class UserSubscription
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public SubscriptionType SubscriptionType { get; set; }

        public StatusType Status { get; set; }

        public MobileDeviceType MobileDeviceType { get; set; }

        public string AuthorizationCode { get; set; }

        public int PaymentRetryCount { get; set; }

        //public string SubscriptionOriginalAmount{ get; set; }

        //public string SubscriptionCurrency { get; set; }

        //public double SubscriptionAmount { get; set; }

        public string? LastPaymentReference { get; set; }

        public DateTime ActiveDate { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
