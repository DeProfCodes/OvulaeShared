using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Education
{
    public class EducationSubItem
    {
        public int Id { get; set; }  // Primary key
        public int EducationItemId { get; set; }  // FK

        public string Title { get; set; }

        public List<string> RawContent { get; set; } = new(); // Store as JSON using EF ValueConverter

        public StatusType Status { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
