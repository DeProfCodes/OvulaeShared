using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.User;

namespace OvulaeShared.Models.User
{
    public class UserModel
    {
        public string UserId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string CountryCode { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileDevice { get; set; }

        public UserRoleType UserRole { get; set; }

        public AccountStatusType AccountStatus { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
