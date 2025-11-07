
using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.HealthProfile
{
    public enum TreatmentTypes
    {
        [Display(Name = "", Description = "")] 
        None,

        [Display(Name = "HRT", Description = "HRT (Hormone Replacement Therapy)")] 
        HRT,
        
        [Display(Name = "Vaginal Estrogen", Description = "Vaginal estrogen")]
        VaginalEstrogen,
        
        [Display(Name = "Antidepressants", Description = "Antidepressants")]
        Antidepressants,
        
        [Display(Name = "Natural remedies", Description = "Natural remedies")]
        NaturalRemedies,
        
        [Display(Name = "Acupuncture", Description = "Acupuncture")]
        Acupuncture,
        
        [Display(Name = "NoTreatment", Description = "No Treatment")]
        NoTreatment,
        
        [Display(Name = "Private", Description = "Prefer not to say")] 
        Private,

    }
}
