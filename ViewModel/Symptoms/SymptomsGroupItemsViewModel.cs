using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Symptoms;

namespace OvulaeShared.ViewModel.Symptoms
{
    public class SymptomsGroupItemsViewModel
    {
        public SymptomsGroup SymptomsGroup { get; set; }

        public List<SymptomItem> SymptomItems { get; set; }
    }
}
