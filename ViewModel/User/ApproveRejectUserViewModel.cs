using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.User;

namespace OvulaeShared.ViewModel.User
{
    public class ApproveRejectUserViewModel
    {
        public string Email { get; set; }

        public UserRoleType UserRole { get; set; }

        public bool ApproveUser { get; set; }
    }
}
