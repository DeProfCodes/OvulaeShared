namespace OvulaeShared.Models.Notifications
{
    public class PeriodOvulationNotificationPreferences
    {
        // 🔔 General
        public bool UseOwnTime { get; set; } = false;
        public TimeSpan PreferredNotificationTime { get; set; } = TimeSpan.FromHours(12);

        // 🩸 Period Tracking Notifications
        public bool NotifyPeriodStart { get; set; } = true;
        public bool NotifyFertileWindow { get; set; } = true;
        public bool NotifyOvulationDay { get; set; } = true;
        public bool NotifyPmsSymptoms { get; set; } = true;
        public bool NotifyLogMood { get; set; } = true;
        public bool NotifyHydration { get; set; } = true;
        public bool NotifyCycleTips { get; set; } = true;
        public bool NotifyDailyAffirmation { get; set; } = true;

        // 🌸 Ovulation Tracking Notifications
        public bool NotifyFollicularPhaseTips { get; set; } = true;
        public bool NotifyOvulationDayTips { get; set; } = true;
        public bool NotifyLutealPhaseTips { get; set; } = true;
        public bool NotifyCervicalMucusChanges { get; set; } = true;
        public bool NotifyTemperatureShiftReminder { get; set; } = true;
        public bool NotifySexTimingAdvice { get; set; } = true;

        // 🧠 Lifestyle & Education
        public bool NotifyFertilityNutritionTips { get; set; } = true;
        public bool NotifyMindfulnessAndRelaxation { get; set; } = true;
    }
}
