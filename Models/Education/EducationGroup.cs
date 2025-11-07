using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Education
{
    public class EducationGroup
    {
        public int Id { get; set; }  // Primary key
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImgSrc { get; set; }

        public List<int> Weeks { get; set; } = new(); // Stored as JSON string using EF ValueConverter
        public List<string> Categories { get; set; } = new(); // Same as above

        public StatusType Status { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
