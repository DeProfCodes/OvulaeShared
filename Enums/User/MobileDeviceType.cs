using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.User
{
    public enum MobileDeviceType
    {
        [Display(Name = "Unknown")]
        Unknown,

        [Display(Name = "Android")]
        Android,

        [Display(Name = "IOS")]
        IOS,
    }
}
