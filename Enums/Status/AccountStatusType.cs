using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.Status
{
    public enum AccountStatusType
    {
        [Display(Name = "None", Description = "None")]
        None = 0,

        [Display(Name = "Active", Description = "Active")]
        Active = 1,

        [Display(Name = "Suspended", Description = "Suspended")]
        Suspended = 2,

        [Display(Name = "Paused", Description = "Paused")]
        Paused = 3,

        [Display(Name = "Deleted", Description = "Deleted")]
        Deleted = 4,

        [Display(Name = "InActive", Description = "InActive")]
        InActive = 5,

        [Display(Name = "Revoked", Description = "Revoked")]
        Revoked = 6,

        [Display(Name = "PendingAffiliate", Description = "Pending Affilate")]
        PendingAffiliate = 50,

        [Display(Name = "RejectedAffiliate", Description = "Rejected Affilate")]
        RejectedAffiliate = 51
    }
}
