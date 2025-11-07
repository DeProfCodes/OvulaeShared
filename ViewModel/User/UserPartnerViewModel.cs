
using OvulaeShared.Enums.Status;

namespace OvulaeShared.ViewModel.User
{
    public class UserPartnerViewModel
    {
        public string MainUserId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string CountryCode { get; set; }

        public string PhoneNumber { get; set; }

        public string MainUserFullname { get; set; }

        public string Journey { get; set; }

        public string TempPassword { get; set; }

        public DateTime InviteDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public AccountStatusType AccessStatus { get; set; }
    }
}
