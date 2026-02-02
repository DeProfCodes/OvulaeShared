using System.ComponentModel.DataAnnotations;

namespace OvulaeShared.Enums.ModuleEnums
{
    public enum MenopauseStage
    {
        [Display(Name = "")]    
        None,

        [Display(Name = "Premenopause")]
        Premenopause,

        [Display(Name = "Menopause")]
        Menopause,

        [Display(Name = "Postmenopause")]
        Postmenopause,
    }
}
