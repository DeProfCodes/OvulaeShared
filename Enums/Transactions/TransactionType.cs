using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.Transactions
{
    public enum TransactionType
    {
        [Display(Name = "", Description = "-")]
        None = 0,

        [Display(Name = "Deposit", Description = "Deposit")]
        Deposit = 1,

        [Display(Name = "DepositTopUp", Description = "Deposit Top-up")]
        DepositTopUp = 2,

        [Display(Name = "Withdrawal", Description = "Withdrawal")]
        Withdrawal = 3,

        [Display(Name = "AffiliatePayout", Description = "Affiliate Payout")]
        AffiliatePayout = 4,

        [Display(Name = "Recurring", Description = "Recurring")]
        Recurring = 5
    }
}
