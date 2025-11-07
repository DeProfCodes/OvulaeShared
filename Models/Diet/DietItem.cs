using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Diet
{
    public class DietItem
    {
        public int Id { get; set; }
        public int DietGroupId { get; set; } // FK

        public string FullHeading { get; set; }
        public string SubHeading { get; set; }
        public string ImageSrc { get; set; }
        public string Importance { get; set; }

        public List<string> DietListDetails { get; set; } = new(); // Store via JSON

        public StatusType Status { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
