using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums;

namespace OvulaeShared.Models.Tips
{
    public class UserLikedTip
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string LikedGroupTipIds { get; set; }

        public string LikedTipIds { get; set; }

        public DateTime CreateData { get; set; }

        public DateTime LastUpdateDate { get; set; }

    }
}
