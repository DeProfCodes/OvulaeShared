
using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.HealthProfile
{
    public enum TamponUsageOptions
    {
        [Display(Name = "", Description = "")] 
        None,

        [Display(Name = "YesNoPain", Description = "Yes, I insert without pain")]
        YesNoPain,
        
        [Display(Name = "YesPain", Description = "Yes, I insert with pain")]
        YesPain,
        
        [Display(Name = "No", Description = "No, I dont use tampons")]
        No
    }
}
