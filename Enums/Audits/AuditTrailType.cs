using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.Audits
{
    public enum AuditTrailType
    {
        [Display(Name = "")]
        None = 0,

        [Display(Name = "Deposit")]
        Deposit = 1,

        [Display(Name = "Withdrawal")]
        Withdrawal = 2,

        [Display(Name = "Profile")]
        Profile = 3,
    }
}
