using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Education
{
    public class EducationItem
    {
        public int Id { get; set; }  // Primary key
        public int EducationBookId { get; set; }  // FK

        public string Title { get; set; }
        public string Description { get; set; }

        public StatusType Status { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }

        // Navigation
        public List<EducationSubItem> RawContentsItems { get; set; }
    }
}
