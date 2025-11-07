using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.Affiliate
{
    public enum AffiliateUpdateType
    {
        [Display(Name = "")]
        None,

        [Display(Name = "AndroidLinkClick")]
        AndroidLinkClick,

        [Display(Name = "IOSLinkClick")]
        IOSLinkClick,

        [Display(Name = "AddNewReferal")]
        AddNewReferal,
    }
}
