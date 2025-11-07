using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;
using OvulaeShared.Models.Affiliate;
using OvulaeShared.ViewModel.Affiliates;

namespace OvulaeShared.ViewModel.User
{
    public class UserAdminAffiliateDetailsViewModel
    {
        public string Email { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string CountryCode { get; set; }

        public string JoinDate { get; set; }

        public UserRoleType UserRole { get; set; }

        public AccountStatusType AccountStatus { get; set; }

        public string JoinCode { get; set; }

        public AffiliateWallet Wallet { get; set; }

        public AffiliateNetworkStatsViewModel AndroidStats { get; set; }

        public AffiliateNetworkStatsViewModel IOSStats { get; set; }

    }
}
