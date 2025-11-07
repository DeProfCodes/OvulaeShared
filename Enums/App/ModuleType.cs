using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.App
{
    public enum ModuleType
    {
        [Display(Name = "", ShortName = "", Description = "")]
        None = 0,

        [Display(Name = "Pregnancy", ShortName = "Pregnancy", Description = "Pregnancy Tracker")]
        Pregnancy = 1,

        [Display(Name = "Ovulation", ShortName = "Ovulation", Description = "Fertility Tracker")]
        Ovulation = 2,

        [Display(Name = "PeriodTracker", ShortName = "Period", Description = "Period Tracker")]
        PeriodTracker = 3,

        [Display(Name = "MenopauseTracker", ShortName = "Menopause", Description = "Menopause Tracker")]
        MenopauseTracker = 4,

        [Display(Name = "PcosAndEdu", ShortName = "PCOS", Description = "")]
        PcosAndEdu = 5,

        [Display(Name = "All", ShortName = "All", Description = "")]
        All = 100,

    }
}
