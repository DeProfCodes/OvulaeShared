using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Tips;

namespace OvulaeShared.ViewModel.Tips
{
    public class TipsGroupItemsViewModel
    {
        public TipsGroup TipsGroup { get; set; }

        public List<TipItem> TipItems { get; set; }
    }
}
