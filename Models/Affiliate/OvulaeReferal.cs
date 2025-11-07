using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Affiliate
{
    public class OvulaeReferal
    {
        public int Id { get; set; }

        public string AffiliateUserId { get; set; }

        public string ClientUserId { get; set; }

        public double Commission { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public StatusType ReferalStatus { get; set; }
    }
}
