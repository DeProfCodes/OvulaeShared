using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.HealthProfile
{
    public enum PeriodIrregularityType
    {
        [Display(Name = "")]
        None,

        [Display(Name = "Regular")]
        Regular,

        [Display(Name = "Occasionally Irregular")]
        OccasionallyIrregular,

        [Display(Name = "Frequently Irregular")]
        FrequentlyIrregular,

        [Display(Name = "No Periods")]
        NoPeriods,

        [Display(Name = "Not Sure")]
        NotSure
    }
}
