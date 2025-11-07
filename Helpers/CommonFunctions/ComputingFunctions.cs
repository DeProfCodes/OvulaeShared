using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;
using OvulaeShared.Enums.Transactions;
using OvulaeShared.Models.Affiliate;
using OvulaeShared.Models.Transactions;

namespace OvulaeShared.Helpers.CommonFunctions
{
    public class ComputingFunctions
    {
        public static AffiliateWallet CreateLiveWallet(string userId, List<OvulaeReferal> userReferals, List<Transaction> userTransactions)
        {
            if (userReferals == null || userTransactions == null)
                return new();

            var totalPaidOut = userTransactions.Where(x => x.Type == TransactionType.AffiliatePayout && x.Status == StatusType.Paid).Sum(x => x.Amount);
            var totalEarned = userReferals.Where(x => x.ReferalStatus == StatusType.Active).Sum(x => x.Commission);

            var wallet = new AffiliateWallet
            {
                AffiliateUserId = userId,
                TotalRevenue = totalEarned,
                TotalPaidOut = totalPaidOut,
                CreateDate = DateTime.Now,
                Status = StatusType.Active,
                LastUpdateDate = DateTime.Now,
            };
            return wallet;
        }
    }
}
