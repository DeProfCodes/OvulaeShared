using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.ModuleEnums
{
    public enum PregnancyTerminationType
    {
        [Display(Name = "None")]
        None,

        [Display(Name = "Terminated (Elective Abortion)")]
        Terminated,

        [Display(Name = "Miscarriage (Spontaneous Abortion)")]
        Miscarriage,

        [Display(Name = "Stillbirth")]
        Stillbirth,

        [Display(Name = "Natural Birth")]
        GaveNaturalBirth,

        [Display(Name = "C-Section Birth")]
        GaveCSectionBirth
    }
}
