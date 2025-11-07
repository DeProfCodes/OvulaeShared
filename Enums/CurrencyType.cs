using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Enums
{
    public enum CurrencyType
    {
        [Display(Name = "")]
        None,

        [Display(Name = "Rand", ShortName = "R")]
        Rand,

        [Display(Name = "Dollar", ShortName = "$")]
        Dollar,
    }
}
