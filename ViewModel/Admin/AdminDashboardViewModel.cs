using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Models.Affiliate;
using OvulaeShared.Models.Transactions;
using OvulaeShared.Models.User;
using OvulaeShared.ViewModel.Affiliates;

namespace OvulaeShared.ViewModel.Admin
{
    public class AdminDashboardViewModel
    {
        public List<UserModel> AllUsers { get; set; }

        public List<AffiliateDashboardViewModel> AllAffiliatesData { get; set; }

        public List<AffiliateClicks> AllClicks { get; set; }

        public List<UserSubscription> AllSubscriptions { get; set; }

        public List<AffiliateWallet> AllWallets { get; set; }

        public List<Transaction> AllTransactions { get; set; }
        
        public List<OvulaeReferal> AllReferals { get; set; }
    }
}
