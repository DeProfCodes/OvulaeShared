using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.Transactions
{
    public enum TransactionMethod
    {
        [Display(Name = "")]
        None,

        [Display(Name = "Bitcoin")]
        Bitcoin,

        [Display(Name = "USDT", ShortName = "$")]
        USDT,

        [Display(Name = "USD", ShortName = "$")]
        USD,

        [Display(Name = "ZAR", ShortName = "R")]
        ZAR,
    }
}
