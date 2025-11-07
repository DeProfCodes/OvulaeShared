using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Affiliate;
using OvulaeShared.Models.Transactions;
using OvulaeShared.Models.User;

namespace OvulaeShared.ViewModel.Affiliates
{
    public class AffiliateDashboardViewModel
    {
        public AffiliateClicks Clicks { get; set; }

        public List<Transaction> Transactions { get; set; }

        public AffiliateWallet Wallet { get; set; }

        public List<UserAffiliateReferalDetails> ReferalsDetails { get; set; }

        public UserModel User { get; set; }
    }
}
