using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Pregnancy;

namespace OvulaeShared.ViewModel.Pregnancy
{
    public class PregnancyDataGroupViewModel
    {
        public PregnancyWeekContent PregnancyInfo { get; set; }

        public PregnancyBabyData BabyDevelopmentDetails { get; set; }
    }
}
