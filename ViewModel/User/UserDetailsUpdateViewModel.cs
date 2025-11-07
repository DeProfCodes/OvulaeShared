using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.ViewModel.User
{
    public class UserDetailsUpdateViewModel
    {
        public string UserId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int BirthYear { get; set; }
    }
}
