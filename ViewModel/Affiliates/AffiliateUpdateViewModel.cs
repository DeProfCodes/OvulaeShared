using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Affiliate;
using OvulaeShared.Enums.User;

namespace OvulaeShared.ViewModel.Affiliates
{
    public class AffiliateUpdateViewModel
    {
        public AffiliateUpdateType AffiliateUpdateType { get; set; }

        public string AffiliateUserId { get; set; }

        public string ReferalMobileLink { get; set; }

        public string ClientUserId { get; set; }

        public SubscriptionType SubscriptionType { get; set; }
    }
}
