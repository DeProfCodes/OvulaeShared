using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Affiliate
{
    public class AffiliateProfile
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string UserEmail { get; set; }

        public string FacebookHandleLink { get; set; }

        public int FacebookFollowers { get; set; }

        public string TiktokHandleLink { get; set; }

        public int TiktokFollowers { get; set; }

        public string YouTubeHandleLink { get; set; }

        public int YouTubeFollowers { get; set; }

        public string InstagramHandleLink { get; set; }

        public int InstagramFollowers { get; set; }

        public string XHandleLink { get; set; }

        public int XFollowers { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public StatusType ProfileStatus { get; set; }
    }
}
