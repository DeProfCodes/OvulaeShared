using OvulaeShared.Enums.Audits;

namespace OvulaeShared.ViewModel.Audits
{
    public class AuditTrailViewModel
    {
        public string UserId { get; set; }

        public AuditTrailType AuditTrailType { get; set; }

        public string AuditTrailMessage { get; set; }

        public string AuditTrailJson { get; set; }
    }
}
