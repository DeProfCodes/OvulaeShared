using OvulaeShared.Models.Menopause;
using OvulaeShared.Models.Ovulation;
using OvulaeShared.Models.PeriodTracker;
using OvulaeShared.Models.Pregnancy;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Shared;

namespace OvulaeShared.Services.APIs.ModuleServices
{
    public interface IModuleLogsApi
    {
        // Pregnancy
        Task<PregnancyTrackerLog> GetPregnancyLogs(string userId);
        Task<GenericResult> UpdatePregnancyLogEntry(string userId, PregnancyLogEntryItem pregnancyLog);
        Task<GenericResult> UpdatePregnancyLogEntryDR(string userId, PregnancyLogEntryItem pregnancyLog);
        Task<GenericResult> UpdateBabyDetails(string userId, List<BabyDetailsLog> babyLogs);

        // Period
        Task<PeriodTrackerLog> GetPeriodLogs(string userId);
        Task<GenericResult> UpdatePeriodLogEntry(string userId, PeriodLogEntry periodLog);
        Task<GenericResult> UpdatePeriodLogEntryDR(string userId, PeriodLogEntry periodLog);

        // Ovulation
        Task<OvulationTrackerLog> GetOvulationLogs(string userId);
        Task<GenericResult> UpdateOvulationLogEntry(string userId, OvulationCycleLog ovulationLog);
        Task<GenericResult> UpdateOvulationLogEntryDR(string userId, OvulationCycleLog ovulationLog);

        // Menopause
        Task<MenopauseTrackerLog> GetMenopauseLogs(string userId);
        Task<GenericResult> UpdateMenopauseLogEntry(string userId, MenopauseLogEntry menopauseLog);
        Task<GenericResult> UpdateMenopauseLogEntryDR(string userId, MenopauseLogEntry menopauseLog);
    }
}
