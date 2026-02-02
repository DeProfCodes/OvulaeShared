using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Models.Notifications
{
    public class SentNotification
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime SentAt { get; set; }

        public string NotificationType { get; set; } 

        public string TimeSlot { get; set; } 
    }
}
