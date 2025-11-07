using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums.App
{
    public enum OvulaeFeatureType
    {
        [Display(Name = "")]
        None = 0,

        [Display(Name = "Dashboard")]
        Dashboard = 1,

        [Display(Name = "Education")]
        Education = 2,

        [Display(Name = "Symptoms")]
        Symptoms = 3,

        [Display(Name = "Diet")]
        Diet = 4,

        [Display(Name = "Tips")]
        Tips = 5,

        [Display(Name = "All")]
        All = 100,
    }
}
