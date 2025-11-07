using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.Affiliate
{
    public enum DoctorNotesUpdateType
    {
        [Display(Name = "")]
        None,

        [Display(Name = "PregnancyNotes")]
        PregnancyNotes,

        [Display(Name = "PeriodTrackerNotes")]
        PeriodTrackerNotes,

        [Display(Name = "OvulationNotes")]
        OvulationNotes,

        [Display(Name = "MenopauseNotes")]
        MenopauseNotes,
    }
}
