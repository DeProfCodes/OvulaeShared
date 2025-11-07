using OvulaeShared.Enums.Audits;

namespace OvulaeShared.Models.Audits
{
    public class AuditTrail
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public AuditTrailType Type { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public string JsonRawData { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
