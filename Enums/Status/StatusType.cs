using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.Status
{
    public enum StatusType
    {
        [Display(Name = "None")]
        None,

        [Display(Name = "Paid")]
        Paid,

        [Display(Name = "Unpaid")]
        Unpaid,

        [Display(Name = "Paused")]
        Paused,

        [Display(Name = "Active")]
        Active,

        [Display(Name = "Pending")]
        Pending,

        [Display(Name = "Open")]
        Open,

        [Display(Name = "Closed")]
        Closed,

        [Display(Name = "Terminated")]
        Terminated,

        [Display(Name = "Deleted")]
        Deleted,

        [Display(Name = "Cancelled")]
        Cancelled,

        [Display(Name = "Success")]
        Success,

        [Display(Name = "Failed")]
        Failed,

        [Display(Name = "Error")]
        Error,

        [Display(Name = "Suspended")]
        Suspended
    }
}
