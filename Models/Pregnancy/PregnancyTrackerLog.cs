
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using OvulaeShared.Enums.ModuleEnums;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Pregnancy
{
    public class PregnancyTrackerLog
    {
        public int Id { get; set; }
        public int PregnancyNumber { get; set; }
        public DateTime? PregnancyStartDate { get; set; }
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdateDate { get; set; } = DateTime.UtcNow;
        public StatusType Status { get; set; } = StatusType.Active;

        public string LogJson { get; set; } // List<PregnancyLogEntryItem>
        public string BabyDetailsJson { get; set; } = ""; // List<BabyDetailsLog>

        public PregnancyTerminationType PregnancyTerminationType { get; set; }


        [NotMapped]
        public List<PregnancyLogEntryItem> Entries
        {
            get => JsonConvert.DeserializeObject<List<PregnancyLogEntryItem>>(LogJson ?? "[]");
            set => LogJson = JsonConvert.SerializeObject(value ?? new());
        }

        [NotMapped]
        public List<BabyDetailsLog> BabyDetails
        {
            get => JsonConvert.DeserializeObject<List<BabyDetailsLog>>(BabyDetailsJson ?? "[]");
            set => BabyDetailsJson = JsonConvert.SerializeObject(value ?? new());
        }
    }
}
