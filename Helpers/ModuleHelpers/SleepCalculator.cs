using OvulaeShared.Models.Menopause;

namespace OvulaeShared.Helpers.ModuleHelpers
{
    public class SleepCalculator
    {
        // Calculate total sleep (handles overnight)
        public static TimeSpan CalculateSleepDuration(TimeSpan sleepTime, TimeSpan wakeTime)
        {
            // If wake time is earlier (e.g., slept at 10 PM, woke at 6 AM)
            if (wakeTime < sleepTime)
            {
                // Crossed midnight: (24h - sleepTime) + wakeTime
                return TimeSpan.FromHours(24) - sleepTime + wakeTime;
            }
            return wakeTime - sleepTime;
        }

        // Identify sleep patterns
        public static string AnalyzeSleepPattern(List<MenopauseLogEntry> logs)
        {
            var sleepLogs = logs.Where(l => l.SleepTime.HasValue && l.WakeTime.HasValue).ToList();

            if (!sleepLogs.Any()) return "No sleep data";

            // Find common wake-up times (hot flash patterns!)
            var wakeTimesByHour = sleepLogs
                .GroupBy(l => l.WakeTime.Value.Hours)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            return $"You most often wake up at {wakeTimesByHour.Key}:00";
        }
    }
}
