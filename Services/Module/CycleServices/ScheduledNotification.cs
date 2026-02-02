
namespace OvulaeShared.Services.Module.CycleServices
{
    public class ScheduledNotification
    {
        public string Title { get; internal set; }
        public object Message { get; internal set; }
        public string NotificationType { get; set; }
        public DateTime ScheduledTime { get; internal set; }
    }
}