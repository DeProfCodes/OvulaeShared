
using OvulaeShared.Enums.Status;
using OvulaeShared.Models.Affiliate;

namespace OvulaeShared.ViewModel.Affiliates
{
    public class AffiliateOverviewDetails
    {
        public string UserId { get; set; }

        public int AndroidJoins { get; set; }

        public int IOSJoins { get; set; }

        public string AndroidJoinLink { get; set; }

        public string IOSJoinLink { get; set; }

        public double TotalRevenue { get; set; }

        public AffiliateProfile AffiliateProfile {get; set; }

    }
}
