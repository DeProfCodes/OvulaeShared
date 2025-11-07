using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.User
{
    public enum UserRoleType
    {
        [Display(Name = "None")]
        None = 0,

        [Display(Name = "Admin")]
        Admin = 1,

        [Display(Name = "Client")]
        Client = 2,

        [Display(Name = "Doctor")]
        Doctor = 3,

        [Display(Name = "Affiliate")]
        Affiliate = 4,

        [Display(Name = "AffiliateManager")]
        AffiliateManager = 5,

        [Display(Name = "PartnerShare")]
        PartnerShare = 6,
    }
}
