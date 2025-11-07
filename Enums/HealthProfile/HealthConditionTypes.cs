
using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.HealthProfile
{
    public enum HealthConditionsTypes
    {
        [Display(Name = "", Description = "")] 
        None,

        [Display(Name = "Endometriosis", Description = "Endometriosis")] 
        Endometriosis,
        
        [Display(Name = "PCOS", Description = "PCOS (Polycystic Ovary Syndrome)")] 
        PCOS,
        
        [Display(Name = "Fibroids", Description = "Fibroids")] 
        Fibroids,
        
        [Display(Name = "Yeast", Description = "Yeast or vaginal infections")] 
        Yeast,
        
        [Display(Name = "Osteoporosis", Description = "Osteoporosis or bone loss")] 
        Osteoporosis,
        
        [Display(Name = "Thyroid", Description = "Thyroid issues")] 
        Thyroid,
        
        [Display(Name = "HeartDisease", Description = "Heart disease risk")] 
        HeartDisease,

        [Display(Name = "Diabetes", Description = "Diabetes or insulin resistance")]
        Diabetes,

        [Display(Name = "NoCondition", Description = "None of these")]
        NoCondition,
    }
}
