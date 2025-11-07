using OvulaeShared.Enums.Transactions;

namespace OvulaeShared.ViewModel.Transactions
{
    public class DepositFundsViewModel
    {
        public double Amount { get; set; }

        public string UserId { get; set; }

        public int TransactionId { get; set; }

        public TransactionType TransactionType { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
