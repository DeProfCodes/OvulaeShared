
using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.HealthProfile
{
    public enum SymptomsTypes
    {
        [Display(Name = "")] None,

        //Menopause Symptoms
        [Display(Name = "Hot flashes")] HotFlashes,
        [Display(Name = "Night sweats")] NightSweats,
        [Display(Name = "Sleep problems")] SleepProblems,
        [Display(Name = "Mood changes")] MoodChanges,
        [Display(Name = "Vaginal dryness")] VaginalDryness,
        [Display(Name = "Weight gain")] WeightGain,
        [Display(Name = "Hair thinning")] HairThinning,
        [Display(Name = "Memory problems")] MemoryProblems,
        [Display(Name = "Loss of libido")] LossOfLibido,
        [Display(Name = "Joint pain")] JointPain

    }
}
