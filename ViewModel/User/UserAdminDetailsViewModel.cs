using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;

namespace OvulaeShared.ViewModel.User
{
    public class UserAdminDetailsViewModel
    {
        public string Email { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string CountryCode { get; set; }

        public string JoinDate { get; set; }

        public UserRoleType UserRole { get; set; }

        public AccountStatusType AccountStatus { get; set; }

        public StatusType SubscriptionStatus { get; set; }

        public string SubscriptionJoinDate { get; set; }

        public MobileDeviceType DeviceType { get; set; }

        public string ReferrerName { get; set; }
    }
}
