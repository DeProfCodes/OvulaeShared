using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.Transactions
{
    public enum EarningsType
    {
        [Display(Name = "", Description = "-")]
        None = 0,

        [Display(Name = "Referal", Description = "Referal")]
        Referal = 1,

        [Display(Name = "BonusEarn", Description = "Bonus Earn")]
        BonusEarn = 2,
    }
}
