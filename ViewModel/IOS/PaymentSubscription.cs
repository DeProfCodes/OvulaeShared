
namespace OvulaeShared.ViewModel.IOS
{
    public class PaymentSubscription
    {
        public string Email { get; set; }

        public double SubscriptionAmount { get; set; }

        public string ReceiptBase64 { get; set; }

        public string ProductId { get; set; }

        public string Platform { get; set; }
    }
}
