using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Ovulation
{
    public class OvulationTrackerLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateDate { get; set; } = DateTime.UtcNow;
        public StatusType Status { get; set; } = StatusType.Active; // or Archived, Deleted, etc.

        public string CycleTrackingHistoryJson { get; set; }

        [NotMapped]
        public List<OvulationCycleLog> CycleTrackingHistory
        {
            get => JsonConvert.DeserializeObject<List<OvulationCycleLog>>(CycleTrackingHistoryJson ?? "[]");
            set => CycleTrackingHistoryJson = JsonConvert.SerializeObject(value ?? new List<OvulationCycleLog>());
        }
    }
}
