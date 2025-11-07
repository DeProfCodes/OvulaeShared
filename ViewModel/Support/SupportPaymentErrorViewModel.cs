
using OvulaeShared.Enums.Support;
using OvulaeShared.Enums.Transactions;

namespace OvulaeShared.ViewModel.Support
{
    public class SupportPaymentErrorViewModel
    {
        public int TransactionId { get; set; }

        public int InvoiceId { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public TransactionType TransactionType { get; set; }

        public double Amount { get; set; }

        public SupportErrorType SupportErrorType { get; set; }

        public string ErrorMessage { get; set; }
    }
}
