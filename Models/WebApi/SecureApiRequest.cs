using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.User;

namespace OvulaeShared.Models.WebApi
{
    public class SecureApiRequest
    {
        public string UserId { get; set; } = "";

        public string Email { get; set; } = "";

        public UserRoleType UserRole { get; set; } = UserRoleType.Client;

        public string AuthToken { get; set; } = "";

        public string Sensitive1 { get; set; } = "";

        public bool BooleanParameter { get; set; }

        public object ModelData { get; set; } = "";
    }
}
