using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.ViewModel.Diet;
using OvulaeShared.ViewModel.Education;
using OvulaeShared.ViewModel.Symptoms;
using OvulaeShared.ViewModel.Tips;

namespace OvulaeShared.ViewModel.Pregnancy
{
    public class PregnancyAllData
    {
        public List<PregnancyDataGroupViewModel> PregnancyData {get; set;}

        public List<EducationGroupItemsViewModel> Education { get; set; }

        public List<DietGroupItemsViewModel> Diet { get; set; }

        public List<SymptomsGroupItemsViewModel> Symptoms { get; set; }

        public List<TipsGroupItemsViewModel> Tips { get; set; }
    }
}
