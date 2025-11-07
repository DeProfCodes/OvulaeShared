using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.PeriodTracker
{
    public class PeriodTrackerLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateDate { get; set; } = DateTime.UtcNow;

        public StatusType Status { get; set; } = StatusType.Active;// Active, Archived, etc.

        public string PeriodLogJson { get; set; }

        [NotMapped]
        public List<PeriodLogEntry> Logs
        {
            get => JsonConvert.DeserializeObject<List<PeriodLogEntry>>(PeriodLogJson ?? "[]");
            set => PeriodLogJson = JsonConvert.SerializeObject(value ?? new List<PeriodLogEntry>());
        }
    }
}
