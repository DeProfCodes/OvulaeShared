using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Education;

namespace OvulaeShared.ViewModel.Education
{
    public class EducationGroupItemsViewModel
    {
        public EducationGroup Book { get; set; }

        public List<EducationDiagram> Diagrams { get; set; }

        public List<EducationItem> BookContents { get; set; } = new();
    }
}
