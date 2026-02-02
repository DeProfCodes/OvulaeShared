using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Models.Notifications
{
    public class PlannedApiNotification
    {
        public string UserId { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }

        public DateTime ScheduledTime { get; set; }

        public string ModuleType { get; set; } 
        public string NotificationType { get; set; } 

        public object Payload { get; set; } 
    }
}
