using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Menopause
{
    public class MenopauseTrackerLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateDate { get; set; } = DateTime.UtcNow;
        public StatusType Status { get; set; } = StatusType.Active; // Active, Archived, etc.

        public string LogJson { get; set; } // Holds serialized list of MenopauseLogEntry

        [NotMapped]
        public List<MenopauseLogEntry> Entries
        {
            get => JsonConvert.DeserializeObject<List<MenopauseLogEntry>>(LogJson ?? "[]");
            set => LogJson = JsonConvert.SerializeObject(value ?? new List<MenopauseLogEntry>());
        }
    }
}
