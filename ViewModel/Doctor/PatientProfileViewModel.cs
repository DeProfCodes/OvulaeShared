using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.App;
using OvulaeShared.Models.Menopause;
using OvulaeShared.Models.Ovulation;
using OvulaeShared.Models.PeriodTracker;
using OvulaeShared.Models.Pregnancy;
using OvulaeShared.Models.User;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.ViewModel.Doctor
{
    public class PatientProfileViewModel
    {
        public UserFullProfileViewModel UserFullProfile { get; set; }

        // Current active tracker
        public string CurrentTracker { get; set; } // "Pregnancy", "Period", "Ovulation", "Menopause"

        // All logs grouped by module
        public List<PregnancyLogEntryItem> PregnancyLogs { get; set; } = new();
        public List<PeriodLogEntry> PeriodLogs { get; set; } = new();
        public List<OvulationCycleLog> OvulationLogs { get; set; } = new();
        public List<MenopauseLogEntry> MenopauseLogs { get; set; } = new();

        // Additional data
        public List<BabyDetailsLog> BabyDetails { get; set; } = new();
        public PregnancyTrackerLog CurrentPregnancy { get; set; }
    }
}
