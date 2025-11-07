using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;

namespace OvulaeShared.ViewModel.Account
{
    public class RegisterViewModel
    {
        public string Email { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string PhoneNumber { get; set; }

        public string CountryCode { get; set; }

        public string Password { get; set; }

        public string MobileDevice { get; set; }

        public AccountStatusType AccountStatusType { get; set; }

        public UserRoleType UserRole { get; set; }
    }
}
