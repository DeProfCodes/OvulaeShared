
namespace OvulaeShared.Models.Affiliate
{
    public class AffiliateClicks
    {
        public int Id { get; set; }

        public string AffiliateUserId { get; set; }

        public int AndroidClicks { get; set; }

        public string AndroidReferalLink { get; set; }

        public int IOSClicks { get; set; }

        public string IOSReferalLink { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
