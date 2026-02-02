namespace OvulaeShared.Models.Notifications
{
    public class MenopauseNotificationPreferences
    {
        public bool UseOwnTime { get; set; } = false;
        public TimeSpan PreferredNotificationTime { get; set; } = TimeSpan.FromHours(12);

        public bool NotifyHotFlashes { get; set; } = true;
        public bool NotifyNightSweats { get; set; } = true;
        public bool NotifyMoodSwings { get; set; } = true;

        // Add more settings as needed...
    }
}
