using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace OvulaeShared.Models.Notifications
{
    public class NotificationSettings
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string PeriodOvulationNotificationsJson { get; set; }
        public string PregnancyNotificationsJson { get; set; }
        public string MenopauseNotificationsJson { get; set; }

        [NotMapped]
        public PeriodOvulationNotificationPreferences PeriodOvulationNotifications
        {
            get => JsonConvert.DeserializeObject<PeriodOvulationNotificationPreferences>(PeriodOvulationNotificationsJson ?? "{}");
            set => PeriodOvulationNotificationsJson = JsonConvert.SerializeObject(value ?? new PeriodOvulationNotificationPreferences());
        }

        [NotMapped]
        public PregnancyNotificationPreferences PregnancyNotifications
        {
            get => JsonConvert.DeserializeObject<PregnancyNotificationPreferences>(PregnancyNotificationsJson ?? "{}");
            set => PregnancyNotificationsJson = JsonConvert.SerializeObject(value ?? new PregnancyNotificationPreferences());
        }

        [NotMapped]
        public MenopauseNotificationPreferences MenopauseNotifications
        {
            get => JsonConvert.DeserializeObject<MenopauseNotificationPreferences>(MenopauseNotificationsJson ?? "{}");
            set => MenopauseNotificationsJson = JsonConvert.SerializeObject(value ?? new MenopauseNotificationPreferences());
        }
    }
}
