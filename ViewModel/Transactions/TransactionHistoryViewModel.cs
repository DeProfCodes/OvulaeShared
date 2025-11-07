using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.Transactions;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.ViewModel.Transactions
{
    public class TransactionHistoryViewModel
    {
        public int TransactionId { get; set; }

        public TransactionType TransactionType { get; set; }

        public string PlanName { get; set; }

        public int PlanId { get; set; }

        public string UserId { get; set; }

        public UserBankDetailsViewModel BankDetails { get; set; }

        public double Amount { get; set; }

        public double Rate { get; set; }

        public DateTime TransactionDate { get; set; }

        public StatusType StatusType { get; set; }

        public DateTime TransactionApprovalDate { get; set; }

        public string Comment { get; set; }
    }
}
