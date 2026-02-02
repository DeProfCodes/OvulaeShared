using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Models.Notifications
{
    public class PregnancyNotificationPreferences
    {
        public bool UseOwnTime { get; set; }
        public TimeSpan PreferredNotificationTime { get; set; } = TimeSpan.FromHours(12);

        // 📅 Core Pregnancy Tracking
        public bool NotifyWeeklyUpdates { get; set; } = true;
        public bool NotifyLogSymptoms { get; set; } = true;
        public bool NotifyEducationalTips { get; set; } = true;
        public bool NotifyAppointmentReminders { get; set; } = true;
        public bool NotifyJournalReminder { get; set; } = true;
        public bool NotifyHydration { get; set; } = true;
        public bool NotifySupplements { get; set; } = true;

        // 💗 Emotional & Motivational
        public bool NotifyAffirmations { get; set; } = true;
        public bool NotifyMilestoneCelebrations { get; set; } = true;

        // 👶 Baby Development
        public bool NotifyKickCount { get; set; } = true;
        public bool NotifyUltrasoundProgress { get; set; } = true;

        // 🌿 Lifestyle & Community
        public bool NotifyPartnerTips { get; set; } = true;
        public bool NotifyProductOffers { get; set; } = true;
        public bool NotifyCommunityEvents { get; set; } = true;
    }
}
