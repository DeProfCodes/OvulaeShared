using OvulaeShared.Models.User;
using OvulaeShared.ViewModel.Affiliates;

namespace OvulaeShared.ViewModel.User
{
    public class UserFullProfileViewModel
    {
        public UserModel UserDetails { get; set; }

        public UserBodyMetric UserBodyMetrics { get; set; }

        public UserCycleProfile UserProfileCycle { get; set; }

        public UserSubscription UserSubscription { get; set; }

        public UserPartnerViewModel PartnerDetails { get; set; }

        public AffiliateOverviewDetails AffiliateDetailsOverview { get; set; }

        public string AffiliateJoinLink { get; set; }
    }
}
