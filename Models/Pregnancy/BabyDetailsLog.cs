
namespace OvulaeShared.Models.Pregnancy
{
    public class BabyDetailsLog
    {
        public int PregnancyTrackerLogId { get; set; }
        public int BabyNumber { get; set; } // 1, 2, 3...
        public string BabyName { get; set; }
        public string BabyGender { get; set; } // "Boy", "Girl", "Unknown"
        public bool IsPrimary { get; set; } // For UI ordering or if one baby is named first
    }
}
