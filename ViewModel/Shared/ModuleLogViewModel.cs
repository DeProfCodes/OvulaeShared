using OvulaeShared.Models.Menopause;
using OvulaeShared.Models.Ovulation;
using OvulaeShared.Models.PeriodTracker;
using OvulaeShared.Models.Pregnancy;

namespace OvulaeShared.ViewModel.Shared
{
    public class ModuleLogViewModel
    {
        public string UserId { get; set; }

        // Pregnancy
        public PregnancyLogEntryItem PregnancyLogEntryItem { get; set; }
        public List<BabyDetailsLog> BabyDetails { get; set; }
        public PregnancyTrackerLog PregnancyTrackerLog { get; set; }

        // Period
        public PeriodLogEntry PeriodLogEntry { get; set; }
        public PeriodTrackerLog PeriodTrackerLog { get; set; }

        // Ovulation
        public OvulationCycleLog OvulationCycleLog { get; set; }
        public OvulationTrackerLog OvulationTrackerLog { get; set; }

        // Menopause
        public MenopauseLogEntry MenopauseLogEntry { get; set; }
        public MenopauseTrackerLog MenopauseTrackerLog { get; set; }
    }
}
