using OvulaeShared.Enums.Transactions;

namespace OvulaeShared.ViewModel.Transactions
{
    public class AddNewInvoiceViewModel
    {
        public string Fullname { get; set; }

        public string Email { get; set; }

        public int InvoiceId { get; set; }

        public int SubscriptionId { get; set; }

        public string UserId { get; set; }

        public int TransactionId { get; set; }

        public double Amount { get; set; }

        public TransactionType TransactionType { get; set; }
    }
}
