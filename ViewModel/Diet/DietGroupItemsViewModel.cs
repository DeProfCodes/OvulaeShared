using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Diet;

namespace OvulaeShared.ViewModel.Diet
{
    public class DietGroupItemsViewModel
    {
        public DietGroup Group { get; set; }
        public List<DietItem> Items { get; set; }
    }
}
