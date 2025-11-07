
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.ViewModel.Transactions
{
    public class RequestFundsViewModel
    {
        public UserBankDetailsViewModel BankDetails { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        public int TransactionId { get; set; }

        public double RequestedAmount { get; set; }

        public double TotalAmountAvailableForWithdrawal { get; set; }

        public double PendingWithdrawalAmount { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string CallBackUrl { get; set; }
    }
}
