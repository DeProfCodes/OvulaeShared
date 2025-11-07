using OvulaeShared.Models.User;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.ViewModel.Transactions
{
    public class WithdrawalFundsRequestViewModel
    {
        public UserBankDetailsViewModel BankDetails { get; set; }

        public UserBank BankDetailsModel { get; set; }

        public List<WithdrawFundsViewModel> PlansAvailableFunds { get; set; }

        public bool SaveBankDetails { get; set; }

        public string UserId { get; set; }

        public int PlanId { get; set; }

        public double Amount { get; set; }

        public int TransactionId { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }
    }
}
