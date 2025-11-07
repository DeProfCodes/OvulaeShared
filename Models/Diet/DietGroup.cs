using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Diet
{
    public class DietGroup
    {
        public int Id { get; set; }  // maps from diet_id
        public string Title { get; set; }
        public string Type { get; set; }
        public string CoverImageSrc { get; set; }

        public List<int> Weeks { get; set; } = new(); // Store via JSON ValueConverter

        public StatusType Status { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public List<DietItem> DietItems { get; set; }
    }
}
