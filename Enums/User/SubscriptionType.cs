using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.User
{
    public enum SubscriptionType
    {
        [Display(Name = "")]
        None,

        [Display(Name = "PremiumMonthly")]
        PremiumMonthly,

        [Display(Name = "PremiumYearly")]
        PremiumYearly,
    }
}
