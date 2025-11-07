using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.Transactions;

namespace OvulaeShared.ViewModel.Transactions
{
    public class TransactViewModel
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public TransactionType Type { get; set; }

        public double Amount { get; set; }

        public string Reference { get; set; }

        public StatusType Status { get; set; }

        public string PaymentGatewayID { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
